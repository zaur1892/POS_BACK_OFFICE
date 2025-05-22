using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BACK_OFFICE
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnSetDoctorPercent_Click(object sender, EventArgs e)
        {
            frmHekimFaizlerininTeyini fhft = new frmHekimFaizlerininTeyini();
            fhft.ShowDialog();
        }

        private void btnDoctorPercentList_Click(object sender, EventArgs e)
        {
            //frmHekimFaizleriListi fhfl = new frmHekimFaizleriListi();
            // fhfl.ShowDialog();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmAddDoctor fad = new frmAddDoctor();
            fad.ShowDialog();
        }

        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            frmAddService fas = new frmAddService();
            fas.ShowDialog();
        }

        private void btnAddSettings_Click(object sender, EventArgs e)
        {
            frmAppSettingsList fasl = new frmAppSettingsList();
            fasl.ShowDialog();
        }
    }
}
