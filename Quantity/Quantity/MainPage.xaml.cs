using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quantity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sub(object sender, EventArgs e)
        {
            if (int.Parse(lblNumber.Text) > 0)
            {
                lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
            }
        }

        private void Soma(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
        }
    }
}
