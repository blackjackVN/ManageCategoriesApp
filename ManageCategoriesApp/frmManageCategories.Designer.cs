namespace ManageCategoriesApp
{
    partial class frmManageCategories
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
            lbCategoryID = new Label();
            lbCategoryName = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCategories = new DataGridView();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(57, 25);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(66, 15);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(57, 76);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(87, 15);
            lbCategoryName.TabIndex = 1;
            lbCategoryName.Text = "CategoryName";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(57, 379);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(211, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(370, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(47, 119);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowTemplate.Height = 25;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(415, 222);
            dgvCategories.TabIndex = 5;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(169, 22);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(293, 23);
            txtCategoryID.TabIndex = 6;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(169, 73);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(293, 23);
            txtCategoryName.TabIndex = 7;
            // 
            // frmManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 441);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(dgvCategories);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCategoryID);
            Name = "frmManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoryID;
        private Label lbCategoryName;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCategories;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
    }
}