using FeeTypeForm.Logins;
using FeeTypeForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace FeeTypeForm.Repositories
{
    public class SqlFeeTypeRepository : IFeeTypeRepository
    {
        public DataTable GetAll()
            {
                 string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                 var con = new SqlConnection(connectionstring);
                 var da = new SqlDataAdapter(@"select f.FeeTypeID,f.FeeName,f.ApplicableGradeID,f.Amount,f.ActiveStatus,g.GradeName from dbo.MstFeeTypes f
                                               join dbo.MstGrades g on f.ApplicableGradeID = g.GradeID;", con);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
        public void AddFeeType(FeeType feetype)
        {
            string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (var con = new SqlConnection(connectionstring))
            {
                con.Open();
                using (var cmd = new SqlCommand("INSERT INTO dbo.MstFeeTypes (FeeName, Amount,ApplicableGradeID,ActiveStatus, CreatedDate,CreatedBy, ModifiedDate,ModifiedBy) " +
                                                              "VALUES (@FeeName, @Amount,@ApplicableGradeID, @ActiveStatus, @CreatedDate,@CreatedBy,@ModifiedDate,@ModifiedBy)", con))
                {
                    cmd.Parameters.AddWithValue("@FeeName", feetype.FeeName);
                    cmd.Parameters.AddWithValue("@Amount", feetype.Amount);
                    cmd.Parameters.AddWithValue("@ApplicableGradeID", feetype.ApplicableGradeID);
                    cmd.Parameters.AddWithValue("@ActiveStatus", feetype.ActiveStatus);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ModifiedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@CreatedBy", Session.CurrentUser); // Assuming a default created by value
                    cmd.Parameters.AddWithValue("@ModifiedBy", DBNull.Value); // Assuming a default modified by value
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateFeeType(FeeType feetype)
        {
            string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (var con = new SqlConnection(connectionstring))
            {
                con.Open();
                using (var cmd = new SqlCommand("UPDATE dbo.MstFeeTypes SET FeeName=@FeeName, Amount=@Amount, ApplicableGradeID=@GradeID,ActiveStatus=@ActiveStatus,ModifiedBy=@ModifiedBy WHERE FeeTypeID=@FeeTypeID", con))
                {
                    cmd.Parameters.AddWithValue("@FeeTypeID", feetype.FeeTypeID);
                    cmd.Parameters.AddWithValue("@FeeName", feetype.FeeName);
                    cmd.Parameters.AddWithValue("@Amount", feetype.Amount);
                    cmd.Parameters.AddWithValue("@GradeID", feetype.ApplicableGradeID);
                    cmd.Parameters.AddWithValue("@ActiveStatus", feetype.ActiveStatus);
                    cmd.Parameters.AddWithValue("@ModifiedBy", Session.CurrentUser); // Assuming a default modified by value
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteFeetype(int FeeTypeID)
        {
            string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (var con = new SqlConnection(connectionstring))
            {
                con.Open();
                using (var cmd = new SqlCommand("DELETE FROM dbo.MstFeeTypes WHERE FeeTypeID = @FeeTypeID", con))
                {
                    cmd.Parameters.AddWithValue("@FeeTypeID", FeeTypeID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
