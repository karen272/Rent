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
            this.lstRents = new System.Windows.Forms.ListBox();
            this.lblViewRents = new System.Windows.Forms.Label();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.lblCreateRent = new System.Windows.Forms.Label();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRents
            // 
            this.lstRents.FormattingEnabled = true;
            this.lstRents.Location = new System.Drawing.Point(12, 14);
            this.lstRents.Name = "lstRents";
            this.lstRents.Size = new System.Drawing.Size(278, 290);
            this.lstRents.TabIndex = 13;
            this.lstRents.SelectedIndexChanged += new System.EventHandler(this.lstRents_SelectedIndexChanged);
            // 
            // lblViewRents
            // 
            this.lblViewRents.AutoSize = true;
            this.lblViewRents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblViewRents.Location = new System.Drawing.Point(573, 20);
            this.lblViewRents.Name = "lblViewRents";
            this.lblViewRents.Size = new System.Drawing.Size(120, 25);
            this.lblViewRents.TabIndex = 15;
            this.lblViewRents.Text = "View Rents";
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAddUsers.Location = new System.Drawing.Point(40, 59);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(92, 48);
            this.btnAddUsers.TabIndex = 19;
            this.btnAddUsers.Text = "Create User";
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Do you want to create\r\n a new user?";
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnUpdateRent.Location = new System.Drawing.Point(22, 309);
            this.btnUpdateRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(114, 49);
            this.btnUpdateRent.TabIndex = 21;
            this.btnUpdateRent.Text = "Update Rent";
            this.btnUpdateRent.UseVisualStyleBackColor = false;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateRent_Click);
            // 
            // btnDeleteRent
            // 
            this.btnDeleteRent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDeleteRent.Location = new System.Drawing.Point(158, 309);
            this.btnDeleteRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(114, 49);
            this.btnDeleteRent.TabIndex = 22;
            this.btnDeleteRent.Text = "Delete Rent";
            this.btnDeleteRent.UseVisualStyleBackColor = false;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);
            // 
            // lblCreateRent
            // 
            this.lblCreateRent.AutoSize = true;
            this.lblCreateRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCreateRent.Location = new System.Drawing.Point(277, 24);
            this.lblCreateRent.Name = "lblCreateRent";
            this.lblCreateRent.Size = new System.Drawing.Size(127, 25);
            this.lblCreateRent.TabIndex = 14;
            this.lblCreateRent.Text = "Create Rent";
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSelectUser.Location = new System.Drawing.Point(13, 25);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(97, 20);
            this.lblSelectUser.TabIndex = 11;
            this.lblSelectUser.Text = "Select User";
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(111, 235);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(121, 21);
            this.cmbItemType.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblName.Location = new System.Drawing.Point(13, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 109);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(121, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDescription.Location = new System.Drawing.Point(13, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblBasePrice.Location = new System.Drawing.Point(13, 151);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(97, 20);
            this.lblBasePrice.TabIndex = 6;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(111, 151);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(121, 20);
            this.txtBasePrice.TabIndex = 7;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(111, 193);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(121, 20);
            this.txtDays.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblType.Location = new System.Drawing.Point(13, 235);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(111, 24);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 21);
            this.cmbUsers.TabIndex = 10;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRent.Location = new System.Drawing.Point(74, 303);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(113, 49);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblSelectUser);
            this.panel1.Controls.Add(this.cmbUsers);
            this.panel1.Controls.Add(this.txtDays);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBasePrice);
            this.panel1.Controls.Add(this.lblBasePrice);
            this.panel1.Controls.Add(this.btnRent);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.cmbItemType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(217, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 366);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "WELCOME! ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(20, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "RENT EVERYTHING";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAddUsers);
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 121);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnDeleteRent);
            this.panel3.Controls.Add(this.btnUpdateRent);
            this.panel3.Controls.Add(this.lstRents);
            this.panel3.Location = new System.Drawing.Point(481, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 370);
            this.panel3.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblViewRents);
            this.Controls.Add(this.lblCreateRent);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstRents;
        private System.Windows.Forms.Label lblViewRents;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.Button btnDeleteRent;
        private System.Windows.Forms.Label lblCreateRent;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

