using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace RestaurantApp
{
    public partial class OrderForm : Form
    {
        private GetAll getAll;
        private MakeOrder makeOrder;
        private List<Dish> dishes;

        public OrderForm()
        {
            InitializeComponent();
            getAll = new GetAll();
            makeOrder = new MakeOrder();
            dishes = new List<Dish>();
            foreach (var i in getAll.Dishes)
            {
                DishesComboBox.Items.Add(i.Name);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dishes.Add(getAll.Dishes.Find(x=>x.Name==DishesComboBox.SelectedItem.ToString()));
            OrderTextBox.Text += DishesComboBox.SelectedItem.ToString() + " ";
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is gonna be ready in " + Convert.ToString(makeOrder.Make(dishes)) + " minutes");
            OrderTextBox.Text = "";
            dishes = new List<Dish>();
        }

    }
}
