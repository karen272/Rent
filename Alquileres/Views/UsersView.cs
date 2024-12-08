using Alquileres.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquileres.Views
{
    public partial class UsersView : Form
    {
        private readonly RentController _controller;
        private readonly UserController _userController;
        private readonly Form1 _form1;

        public UsersView(RentController controller, UserController userController, Form1 form1)
        {
            InitializeComponent();
            _controller = controller;
            _userController = userController;
            _form1 = form1;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = txtNameUser.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter both name.");
                return;
            }

            try
            {
                _userController.AddUser(name);

                _form1.UpdateUserComboBox();

                txtNameUser.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
