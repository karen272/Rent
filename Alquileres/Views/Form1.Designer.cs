namespace Alquileres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lstRents = new System.Windows.Forms.ListBox();
            this.lblCreateRent = new System.Windows.Forms.Label();
            this.lblViewRents = new System.Windows.Forms.Label();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(113, 324);
            this.cmbItemType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(160, 24);
            this.cmbItemType.TabIndex = 0;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(87, 387);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(151, 60);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 129);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 120);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(36, 166);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(141, 162);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(132, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(40, 209);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(76, 16);
            this.lblBasePrice.TabIndex = 6;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(141, 205);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(132, 22);
            this.txtBasePrice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days: ";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(141, 249);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(132, 22);
            this.txtDays.TabIndex = 9;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(141, 61);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(160, 24);
            this.cmbUsers.TabIndex = 10;
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(36, 71);
            this.lblSelectUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(77, 16);
            this.lblSelectUser.TabIndex = 11;
            this.lblSelectUser.Text = "Select User";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(45, 334);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // lstRents
            // 
            this.lstRents.FormattingEnabled = true;
            this.lstRents.ItemHeight = 16;
            this.lstRents.Location = new System.Drawing.Point(331, 59);
            this.lstRents.Margin = new System.Windows.Forms.Padding(4);
            this.lstRents.Name = "lstRents";
            this.lstRents.Size = new System.Drawing.Size(369, 388);
            this.lstRents.TabIndex = 13;
            this.lstRents.SelectedIndexChanged += new System.EventHandler(this.lstRents_SelectedIndexChanged);
            // 
            // lblCreateRent
            // 
            this.lblCreateRent.AutoSize = true;
            this.lblCreateRent.Location = new System.Drawing.Point(128, 18);
            this.lblCreateRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateRent.Name = "lblCreateRent";
            this.lblCreateRent.Size = new System.Drawing.Size(78, 16);
            this.lblCreateRent.TabIndex = 14;
            this.lblCreateRent.Text = "Create Rent";
            // 
            // lblViewRents
            // 
            this.lblViewRents.AutoSize = true;
            this.lblViewRents.Location = new System.Drawing.Point(484, 18);
            this.lblViewRents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewRents.Name = "lblViewRents";
            this.lblViewRents.Size = new System.Drawing.Size(74, 16);
            this.lblViewRents.TabIndex = 15;
            this.lblViewRents.Text = "View Rents";
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Location = new System.Drawing.Point(861, 203);
            this.btnAddUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(123, 59);
            this.btnAddUsers.TabIndex = 19;
            this.btnAddUsers.Text = "Create User";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Do you want to create\r\n a new user?";
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.Location = new System.Drawing.Point(387, 470);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(102, 45);
            this.btnUpdateRent.TabIndex = 21;
            this.btnUpdateRent.Text = "Update Rent";
            this.btnUpdateRent.UseVisualStyleBackColor = true;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateRent_Click);
            // 
            // btnDeleteRent
            // 
            this.btnDeleteRent.Location = new System.Drawing.Point(516, 470);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(102, 45);
            this.btnDeleteRent.TabIndex = 22;
            this.btnDeleteRent.Text = "Delete Rent";
            this.btnDeleteRent.UseVisualStyleBackColor = true;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDeleteRent);
            this.Controls.Add(this.btnUpdateRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.lblViewRents);
            this.Controls.Add(this.lblCreateRent);
            this.Controls.Add(this.lstRents);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.cmbItemType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ListBox lstRents;
        private System.Windows.Forms.Label lblCreateRent;
        private System.Windows.Forms.Label lblViewRents;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.Button btnDeleteRent;
    }
}

