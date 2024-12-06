using Alquileres.Controllers;
using Alquileres.Factorys;
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
            if (cmbUsers.SelectedItem == null || !(cmbUsers.SelectedItem is User user))
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            if (!ValidateForm(out decimal basePrice, out int days))
                return;

            try
            {
                // Obtener datos del formulario
                string itemType = cmbItemType.SelectedItem.ToString();
                string name = txtName.Text;
                string description = txtDescription.Text;

                // Obtener la estrategia de precios usando el Factory
                IPriceStrategy strategy = PriceStrategyFactory.GetStrategy(itemType);

                // Realizar el alquiler
                decimal total = _controller.RentItem(user, itemType, name, description, basePrice, days, strategy);

                // Mostrar resultado
                lstRents.Items.Add($"{user.Name} rented: {name}, Total: ${total}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
        private bool ValidateForm(out decimal basePrice, out int days)
        {
            basePrice = 0;
            days = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("The name field cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("The description field cannot be empty.");
                return false;
            }

            if (!decimal.TryParse(txtBasePrice.Text, out basePrice) || basePrice <= 0)
            {
                MessageBox.Show("Please enter a valid base price greater than zero.");
                return false;
            }

            if (!int.TryParse(txtDays.Text, out days) || days <= 0)
            {
                MessageBox.Show("Please enter a valid number of days greater than zero.");
                return false;
            }

            if (cmbItemType.SelectedItem == null)
            {
                MessageBox.Show("Please select an item type.");
                return false;
            }

            return true;
        }
    }
       

}


    
