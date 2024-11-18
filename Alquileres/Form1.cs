using Alquileres.Controllers;
using Alquileres.Models;
using Alquileres.Services;
using Alquileres.Services.Interfaces;
using Alquileres.Services.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquileres
{
    public partial class Form1 : Form
    {
        private readonly RentController _controller;
        private readonly UserController _userController;
        public Form1(RentController controller, UserController userController)
        {
            InitializeComponent();
            _controller = controller;
            _userController = userController;
            InitializeComboBox();
            cmbUsers.DisplayMember = "Name";
        }
        private void InitializeComboBox()
        {
            cmbItemType.Items.AddRange(new string[] { "Vehicle", "Appliance", "Tool", "Machinery", "Costume" });
            cmbItemType.SelectedIndex = 0;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem is User user)
            {
                string itemType = cmbItemType.SelectedItem.ToString();
                string name = txtName.Text;
                string description = txtDescription.Text;
                decimal basePrice = decimal.Parse(txtBasePrice.Text);
                int days = int.Parse(txtDays.Text);

                IPriceStrategy strategy =  new PriceStrategy();

                decimal total = _controller.RentItem(user, itemType, name, description, basePrice, days, strategy);
                lstRents.Items.Add($"{user.Name} rented: {name}, Total: ${total}");
            }
            else
            {
                MessageBox.Show("Please select a user");
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtBasePrice.Clear();
            txtDays.Clear();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter both name.");
                return;
            }

            try
            {
                _userController.AddUser(name);

                UpdateUserComboBox();

                txtUserName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUserComboBox()
        {
            cmbUsers.Items.Clear();
            cmbUsers.Items.AddRange(_userController.GetAllUsers().ToArray());
        }
    }
       

}


    
