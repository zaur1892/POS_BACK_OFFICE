using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_BACK_OFFICE
{
    public class PermissionChecker
    {
        private string connectionString;

        public PermissionChecker(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool HasPermission(string userId, string permissionField)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                string permissionQuery = @"
                SELECT OK
                FROM Permission p
                JOIN PermissionGroup pg ON p.GroupID = pg.id
                JOIN PermissionForUsers pfu ON pfu.PermitGroupId = pg.ID
                WHERE Filed = @Filed
                AND pfu.UserId = @UserId
                AND OK = N'V'";

                using (SqlCommand permissionCommand = new SqlCommand(permissionQuery, connection))
                {
                    permissionCommand.Parameters.AddWithValue("@UserId", userId);
                    permissionCommand.Parameters.AddWithValue("@Filed", permissionField);
                    SqlDataReader reader = permissionCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        string permission = reader["OK"].ToString();
                        return permission == "V";
                    }
                    reader.Close();
                }
            }

            return false;
        }
    }

}
