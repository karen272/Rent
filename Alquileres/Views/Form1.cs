using Alquileres.Controllers;
using Alquileres.Factorys;
using Alquileres.Models;
using Alquileres.Services;
using Alquileres.Services.Interfaces;
using Alquileres.Services.Strategy;
using Alquileres.Views;
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

            if (!ValidateForm(out decimal basePrice, out int days))
                return;

            try
            {
                string itemType = cmbItemType.SelectedItem.ToString();
                string name = txtName.Text;
                string description = txtDescription.Text;
                User user = (User)cmbUsers.SelectedItem;

                // Obtengo la estrategia de precios usando el Factory
                IPriceStrategy strategy = PriceStrategyFactory.GetStrategy(itemType);

                // Realizo el alquiler
                _controller.RentItem(user, itemType, name, description, basePrice, days, strategy);

                UpdateListRents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            LimpiarCampos();
        }

        //Igresar a la ventana para agregar Usuarios
        private void btnAddUser_Click(object sender, EventArgs e)
        {

            UsersView form2 = new UsersView(_controller, _userController, this);
            form2.ShowDialog();

        }

        private void btnUpdateRent_Click(object sender, EventArgs e)
        {

            if (!ValidateForm(out decimal basePrice, out int days))
                return;

            try
            {
                string itemType = cmbItemType.SelectedItem.ToString();
                string name = txtName.Text;
                string description = txtDescription.Text;
                User user = (User)cmbUsers.SelectedItem;

                IPriceStrategy strategy = PriceStrategyFactory.GetStrategy(itemType);
                _controller.UpdateRent(user, itemType, name, description, basePrice, days, strategy);

                _deleteRent();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            LimpiarCampos();
        }

        private void btnDeleteRent_Click(object sender, EventArgs e)
        {
            _deleteRent();
        }

        private void lstRents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si hay un elemento seleccionado
            if (lstRents.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            // Verifica si el elemento seleccionado es del tipo Rent
            var selectedRent = lstRents.SelectedItem as Rent;
            if (selectedRent == null)
            {
                MessageBox.Show("The selected item is not a valid Rent object.");
                return;
            }

            // Mostrar los datos actuales en los campos de entrada
            cmbUsers.SelectedItem = selectedRent.User;
            txtName.Text = selectedRent.Item.Name;
            txtDescription.Text = selectedRent.Item.Description;
            txtBasePrice.Text = selectedRent.Item.BasePrice.ToString();
            txtDays.Text = selectedRent.Days.ToString();
            cmbItemType.SelectedItem = selectedRent.ItemType;
        }
        public void _deleteRent()
        {
            // Verifica si hay un elemento seleccionado
            if (lstRents.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            // Verifica si el elemento seleccionado es del tipo Rent
            var selectedRent = lstRents.SelectedItem as Rent;
            if (selectedRent == null)
            {
                MessageBox.Show("The selected item is not a valid Rent object.");
                return;
            }

            try
            {
                // Llama al controlador para eliminar el objeto Rent
                _controller.DeleteRentItem(selectedRent);

                // Actualiza la lista de rentas
                UpdateListRents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void UpdateListRents()
        {
            lstRents.Items.Clear();
            lstRents.Items.AddRange(_controller.GetAllRents().ToArray());
        }
        private void LimpiarCampos()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtBasePrice.Clear();
            txtDays.Clear();
        }
        public void UpdateUserComboBox()
        {
            cmbUsers.Items.Clear();
            cmbUsers.Items.AddRange(_userController.GetAllUsers().ToArray());
        }
        private bool ValidateForm(out decimal basePrice, out int days)
        {
            basePrice = 0;
            days = 0;

            if (cmbUsers.SelectedItem == null || !(cmbUsers.SelectedItem is User user))
            {
                MessageBox.Show("Please select a user.");
                return false;
            }
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



