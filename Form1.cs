using FeeTypeForm.Models;
using FeeTypeForm.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeeTypeForm
{
    public partial class FrmFee : Form
    {
        const int ShowLeftPos = 224;
        private readonly IFeeTypeRepository _FeeTyperepo;
        private int selectedGradeID = -1;
        public FrmFee()
        {
            InitializeComponent();
            _FeeTyperepo = new SqlFeeTypeRepository();
            dataGridView1.ReadOnly = true; // Make DataGridView read-only
            dataGridView1.RowHeadersVisible = false; // Hide row headers
            dataGridView1.AllowUserToAddRows = false; // Disable adding new rows
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select full rows
            dataGridView1.MultiSelect = true; // Allow multiple row selection
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete; // Handle DataBindingComplete event
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged; // Handle SelectionChanged event to update the selected row
            txtGridSearch.TextChanged += txtGridSearch_TextChanged;

            //cmbGrade.DisplayMember = "ApplicableGradeID";  // Show names
            //cmbGrade.ValueMember = "ApplicableGradeID";

            cmbdvRight.Items.Add("FeeName");
            cmbdvRight.SelectedIndex = 0;
        }

        public void ShowGrid()
        {
            while (gvpanel.Left > ShowLeftPos)
            {
                gvpanel.Left = gvpanel.Left - 10;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowGrid();
            btnHide.Enabled = true;
            btnShow.Enabled = false;
            var dt = _FeeTyperepo.GetAll();
            dataGridView1.DataSource = dt;
        }

        public void HideGrid()
        {
            while (gvpanel.Left < MainPanel.Width + 20)
            {
                gvpanel.Left = gvpanel.Left + 10;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            HideGrid();
            btnHide.Enabled = false;
            btnShow.Enabled = true;
        }

        private void LoadGrades()
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = "SELECT GradeID, GradeName FROM dbo.MstGrades";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbGrade.DataSource = dt;
                cmbGrade.DisplayMember = "GradeName";  // show name
                cmbGrade.ValueMember = "GradeID";      // store ID
            }
        }


        private void FrmFee_Load(object sender, EventArgs e)
        {
            var dt = _FeeTyperepo.GetAll();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["FeeTypeID"].Visible = false;
            dataGridView1.Columns["ApplicableGradeID"].Visible = false;
            //dataGridView1.Columns["GradeName"].Visible = false;
            //dataGridView1.Columns["createdby"].Visible = false;
            //dataGridView1.Columns["createdDate"].Visible = false;
            //dataGridView1.Columns["modifiedby"].Visible = false;
            //dataGridView1.Columns["modifieddate"].Visible = false;
            //dataGridView1.Columns["IsDeleted"].Visible = false;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            LoadGrades();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SelectLastRealRow();
        }

        private void SelectLastRealRow()
        {
            if (dataGridView1.Rows.Count == 0) return;

            int lastIndex = dataGridView1.Rows.Count - 1;

            // If the last row is the placeholder new row, step back
            if (dataGridView1.AllowUserToAddRows && dataGridView1.Rows[lastIndex].IsNewRow)
            {
                lastIndex--;
            }

            if (lastIndex < 0) return;

            dataGridView1.ClearSelection();
            dataGridView1.Rows[lastIndex].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = lastIndex;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            var row = dataGridView1.SelectedRows[0];
            if (row.Cells["FeeTypeID"].Value == null)
                return;

            selectedGradeID = Convert.ToInt32(row.Cells["FeeTypeID"].Value);
            //txtgradeid.Text = selectedGradeID.ToString();
            txtfeename.Text = row.Cells["FeeName"].Value?.ToString() ?? string.Empty;
            numericUpDownamount.Text = row.Cells["Amount"].Value?.ToString() ?? string.Empty;
            cmbGrade.SelectedValue = row.Cells["ApplicableGradeID"].Value;
            checkboxactivestatus.Checked = Convert.ToBoolean(row.Cells["ActiveStatus"].Value);
        }

        private void txtGridSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                string filterColumn = cmbdvRight.SelectedItem.ToString();
                string searchValue = txtGridSearch.Text.Replace("'", "' '"); // Escape single quotes for SQL-like filtering
                if (!string.IsNullOrEmpty(searchValue))
                {
                    dt.DefaultView.RowFilter = $"{filterColumn} LIKE '%{searchValue}%'";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty; // Clear filter if search text is empty
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfeename.Text))
            {
                MessageBox.Show("Fee type Name is required.");
                return;
            }

            var feetype = new FeeType
            {
                FeeName = txtfeename.Text.Trim(),
                Amount = numericUpDownamount.Value,
                ApplicableGradeID = (int)cmbGrade.SelectedValue,
                ActiveStatus = checkboxactivestatus.Checked,
            };

            try
            {
                _FeeTyperepo.AddFeeType(feetype);
                MessageBox.Show("Record added successfully.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtfeetypeid.Clear();
            numericUpDownamount.Value = 0;
            txtfeename.Clear();
            cmbGrade.SelectedValue = 0;
            checkboxactivestatus.Checked = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedGradeID < 0)
            {
                MessageBox.Show("Please select a Fee Type to edit.");
                return;
            }

            var feetype = new FeeType
            {
                FeeTypeID = selectedGradeID,
                FeeName = txtfeename.Text.Trim(),
                Amount = numericUpDownamount.Value,
                ApplicableGradeID = (int)cmbGrade.SelectedValue,
                ActiveStatus = checkboxactivestatus.Checked,
            };
            try
            {
                _FeeTyperepo.UpdateFeeType(feetype);
                MessageBox.Show("Record updated successfully.");
                ClearForm();
                selectedGradeID = -1; // Reset the selected ID
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGradeID < 0)
            {
                MessageBox.Show("Please select a Fee Type to delete.");
                return;
            }
            try
            {
                _FeeTyperepo.DeleteFeetype(selectedGradeID);
                MessageBox.Show("Record deleted successfully.");
                ClearForm();
                selectedGradeID = -1; // Reset the selected ID
                // Refresh the DataGridView
                var dt = _FeeTyperepo.GetAll();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
        }
    }
}
