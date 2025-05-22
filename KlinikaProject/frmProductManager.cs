using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace POS_BACK_OFFICE
{
    public partial class frmProductManager : Form
    {
        private string jsonPath = Path.Combine(Application.StartupPath, "products.json");
        private List<Product> productList = new List<Product>();

        public frmProductManager()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                productList = JsonSerializer.Deserialize<List<Product>>(json);
            }

            dgvProducts.Rows.Clear();
            foreach (var p in productList)
            {
                dgvProducts.Rows.Add(p.Code, p.Name);
            }
        }

        private void SaveProducts()
        {
            string json = JsonSerializer.Serialize(productList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonPath, json);
            LoadProducts(); // yenilə
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name)) return;

            if (productList.Any(p => p.Code == code))
            {
                MessageBox.Show("Bu kod artıq mövcuddur.");
                return;
            }

            productList.Add(new Product { Code = code, Name = name });
            SaveProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();

            var product = productList.FirstOrDefault(p => p.Code == code);
            if (product != null)
            {
                product.Name = name;
                SaveProducts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            var product = productList.FirstOrDefault(p => p.Code == code);
            if (product != null)
            {
                productList.Remove(product);
                SaveProducts();
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var row = dgvProducts.SelectedRows[0];
                txtCode.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
            }
        }
    }

}
