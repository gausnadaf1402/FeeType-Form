namespace FeeTypeForm
{
    partial class FrmFee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new CodeVendor.Controls.Grouper();
            this.gvpanel = new System.Windows.Forms.Panel();
            this.lblselect = new System.Windows.Forms.Label();
            this.cmbdvRight = new System.Windows.Forms.ComboBox();
            this.txtGridSearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblselectionwindow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHide = new System.Windows.Forms.Button();
            this.checkboxactivestatus = new System.Windows.Forms.CheckBox();
            this.lblactivestatus = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.txtfeename = new System.Windows.Forms.TextBox();
            this.txtfeetypeid = new System.Windows.Forms.TextBox();
            this.numericUpDownamount = new System.Windows.Forms.NumericUpDown();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblfeename = new System.Windows.Forms.Label();
            this.lblfeetypeid = new System.Windows.Forms.Label();
            this.groupBox1 = new CodeVendor.Controls.Grouper();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainPanel.SuspendLayout();
            this.gvpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownamount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPanel.BackgroundGradientColor = System.Drawing.SystemColors.HighlightText;
            this.MainPanel.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
            this.MainPanel.BorderColor = System.Drawing.Color.Black;
            this.MainPanel.BorderThickness = 1F;
            this.MainPanel.Controls.Add(this.gvpanel);
            this.MainPanel.Controls.Add(this.checkboxactivestatus);
            this.MainPanel.Controls.Add(this.lblactivestatus);
            this.MainPanel.Controls.Add(this.lblgrade);
            this.MainPanel.Controls.Add(this.cmbGrade);
            this.MainPanel.Controls.Add(this.txtfeename);
            this.MainPanel.Controls.Add(this.txtfeetypeid);
            this.MainPanel.Controls.Add(this.numericUpDownamount);
            this.MainPanel.Controls.Add(this.lblamount);
            this.MainPanel.Controls.Add(this.lblfeename);
            this.MainPanel.Controls.Add(this.lblfeetypeid);
            this.MainPanel.CustomGroupBoxColor = System.Drawing.Color.PeachPuff;
            this.MainPanel.GroupImage = null;
            this.MainPanel.GroupTitle = "";
            this.MainPanel.Location = new System.Drawing.Point(2, -10);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainPanel.PaintGroupBox = false;
            this.MainPanel.RoundCorners = 10;
            this.MainPanel.ShadowColor = System.Drawing.Color.Gray;
            this.MainPanel.ShadowControl = true;
            this.MainPanel.ShadowThickness = 4;
            this.MainPanel.Size = new System.Drawing.Size(866, 341);
            this.MainPanel.TabIndex = 0;
            // 
            // gvpanel
            // 
            this.gvpanel.AutoScroll = true;
            this.gvpanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.gvpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gvpanel.BackgroundImage")));
            this.gvpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gvpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvpanel.Controls.Add(this.lblselect);
            this.gvpanel.Controls.Add(this.cmbdvRight);
            this.gvpanel.Controls.Add(this.txtGridSearch);
            this.gvpanel.Controls.Add(this.lblsearch);
            this.gvpanel.Controls.Add(this.lblselectionwindow);
            this.gvpanel.Controls.Add(this.dataGridView1);
            this.gvpanel.Controls.Add(this.btnHide);
            this.gvpanel.Location = new System.Drawing.Point(297, 13);
            this.gvpanel.Name = "gvpanel";
            this.gvpanel.Size = new System.Drawing.Size(563, 320);
            this.gvpanel.TabIndex = 21;
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.BackColor = System.Drawing.Color.Transparent;
            this.lblselect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselect.ForeColor = System.Drawing.Color.Blue;
            this.lblselect.Location = new System.Drawing.Point(102, 280);
            this.lblselect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(57, 19);
            this.lblselect.TabIndex = 328;
            this.lblselect.Text = "Select";
            // 
            // cmbdvRight
            // 
            this.cmbdvRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdvRight.FormattingEnabled = true;
            this.cmbdvRight.Location = new System.Drawing.Point(171, 276);
            this.cmbdvRight.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdvRight.Name = "cmbdvRight";
            this.cmbdvRight.Size = new System.Drawing.Size(136, 24);
            this.cmbdvRight.TabIndex = 327;
            // 
            // txtGridSearch
            // 
            this.txtGridSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtGridSearch.Location = new System.Drawing.Point(383, 276);
            this.txtGridSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtGridSearch.Name = "txtGridSearch";
            this.txtGridSearch.Size = new System.Drawing.Size(155, 22);
            this.txtGridSearch.TabIndex = 326;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Blue;
            this.lblsearch.Location = new System.Drawing.Point(309, 278);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(64, 19);
            this.lblsearch.TabIndex = 325;
            this.lblsearch.Text = "Search";
            // 
            // lblselectionwindow
            // 
            this.lblselectionwindow.AutoSize = true;
            this.lblselectionwindow.BackColor = System.Drawing.Color.Transparent;
            this.lblselectionwindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectionwindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblselectionwindow.Location = new System.Drawing.Point(200, 20);
            this.lblselectionwindow.Name = "lblselectionwindow";
            this.lblselectionwindow.Size = new System.Drawing.Size(185, 25);
            this.lblselectionwindow.TabIndex = 270;
            this.lblselectionwindow.Text = "Selection Window";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(10, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 223);
            this.dataGridView1.TabIndex = 269;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FloralWhite;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHide.ImageIndex = 5;
            this.btnHide.ImageList = this.imageList1;
            this.btnHide.Location = new System.Drawing.Point(10, 276);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(84, 28);
            this.btnHide.TabIndex = 268;
            this.btnHide.Text = "Hide";
            this.btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // checkboxactivestatus
            // 
            this.checkboxactivestatus.AutoSize = true;
            this.checkboxactivestatus.Location = new System.Drawing.Point(197, 293);
            this.checkboxactivestatus.Name = "checkboxactivestatus";
            this.checkboxactivestatus.Size = new System.Drawing.Size(18, 17);
            this.checkboxactivestatus.TabIndex = 20;
            this.checkboxactivestatus.UseVisualStyleBackColor = true;
            // 
            // lblactivestatus
            // 
            this.lblactivestatus.AutoSize = true;
            this.lblactivestatus.Location = new System.Drawing.Point(74, 294);
            this.lblactivestatus.Name = "lblactivestatus";
            this.lblactivestatus.Size = new System.Drawing.Size(84, 16);
            this.lblactivestatus.TabIndex = 19;
            this.lblactivestatus.Text = "Active Status";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Location = new System.Drawing.Point(74, 246);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(45, 16);
            this.lblgrade.TabIndex = 18;
            this.lblgrade.Text = "Grade";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(197, 238);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(170, 24);
            this.cmbGrade.TabIndex = 17;
            // 
            // txtfeename
            // 
            this.txtfeename.Location = new System.Drawing.Point(197, 124);
            this.txtfeename.Name = "txtfeename";
            this.txtfeename.Size = new System.Drawing.Size(170, 22);
            this.txtfeename.TabIndex = 16;
            // 
            // txtfeetypeid
            // 
            this.txtfeetypeid.Location = new System.Drawing.Point(197, 76);
            this.txtfeetypeid.Name = "txtfeetypeid";
            this.txtfeetypeid.Size = new System.Drawing.Size(170, 22);
            this.txtfeetypeid.TabIndex = 15;
            // 
            // numericUpDownamount
            // 
            this.numericUpDownamount.DecimalPlaces = 2;
            this.numericUpDownamount.Location = new System.Drawing.Point(197, 182);
            this.numericUpDownamount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownamount.Name = "numericUpDownamount";
            this.numericUpDownamount.Size = new System.Drawing.Size(170, 22);
            this.numericUpDownamount.TabIndex = 14;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(74, 182);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(52, 16);
            this.lblamount.TabIndex = 13;
            this.lblamount.Text = "Amount";
            // 
            // lblfeename
            // 
            this.lblfeename.AutoSize = true;
            this.lblfeename.Location = new System.Drawing.Point(74, 130);
            this.lblfeename.Name = "lblfeename";
            this.lblfeename.Size = new System.Drawing.Size(71, 16);
            this.lblfeename.TabIndex = 6;
            this.lblfeename.Text = "Fee Name";
            // 
            // lblfeetypeid
            // 
            this.lblfeetypeid.AutoSize = true;
            this.lblfeetypeid.Location = new System.Drawing.Point(74, 76);
            this.lblfeetypeid.Name = "lblfeetypeid";
            this.lblfeetypeid.Size = new System.Drawing.Size(82, 16);
            this.lblfeetypeid.TabIndex = 4;
            this.lblfeetypeid.Text = "Fee Type ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.BackgroundGradientColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
            this.groupBox1.BorderColor = System.Drawing.Color.Black;
            this.groupBox1.BorderThickness = 1F;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.CustomGroupBoxColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.GroupImage = null;
            this.groupBox1.GroupTitle = "";
            this.groupBox1.Location = new System.Drawing.Point(2, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.PaintGroupBox = false;
            this.groupBox1.RoundCorners = 10;
            this.groupBox1.ShadowColor = System.Drawing.Color.Gray;
            this.groupBox1.ShadowControl = true;
            this.groupBox1.ShadowThickness = 3;
            this.groupBox1.Size = new System.Drawing.Size(866, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.ImageIndex = 3;
            this.btnShow.ImageList = this.imageList1;
            this.btnShow.Location = new System.Drawing.Point(309, 18);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 28);
            this.btnShow.TabIndex = 266;
            this.btnShow.Text = "Show";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageIndex = 4;
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(753, 18);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 267;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(11, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 28);
            this.btnAdd.TabIndex = 268;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(103, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 28);
            this.btnEdit.TabIndex = 269;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(195, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 270;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Edit-icon.png");
            this.imageList1.Images.SetKeyName(2, "delete.jpg");
            this.imageList1.Images.SetKeyName(3, "show-icon.png");
            this.imageList1.Images.SetKeyName(4, "exit-ico.png");
            this.imageList1.Images.SetKeyName(5, "hide-ico.png");
            // 
            // FrmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFee";
            this.Text = "FeeType";
            this.Load += new System.EventHandler(this.FrmFee_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.gvpanel.ResumeLayout(false);
            this.gvpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownamount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CodeVendor.Controls.Grouper MainPanel;
        private CodeVendor.Controls.Grouper groupBox1;
        private System.Windows.Forms.Label lblfeename;
        private System.Windows.Forms.Label lblfeetypeid;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txtfeename;
        private System.Windows.Forms.TextBox txtfeetypeid;
        private System.Windows.Forms.NumericUpDown numericUpDownamount;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.CheckBox checkboxactivestatus;
        private System.Windows.Forms.Label lblactivestatus;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Panel gvpanel;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.ComboBox cmbdvRight;
        private System.Windows.Forms.TextBox txtGridSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblselectionwindow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList1;
    }
}

