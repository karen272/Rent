namespace Alquileres.Views
{
    partial class UsersView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(167, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(94, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(188, 67);
            this.txtNameUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(96, 20);
            this.txtNameUser.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAddUser.Location = new System.Drawing.Point(151, 133);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(107, 42);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.txtNameUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(58, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 204);
            this.panel1.TabIndex = 4;
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsersView";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel1;
    }
}