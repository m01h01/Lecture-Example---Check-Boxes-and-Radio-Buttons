using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture_Example___Check_Boxes_and_Radio_Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            Preload();
        }

        void Preload()
        {
            rbSmall.IsChecked = true;
            cbPepporoni.IsChecked = true;
            rbDrinkSmall.IsChecked = true;
        }
        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            double amount = 0;
            rtbRunReceipts.Text = ""; 

            string cName = tbName.Text;
            rtbRunReceipts.Text = $"Customer Name: {cName}\n";
          

            bool sizeSmall = rbSmall.IsChecked.Value;
            bool sizeMedium = rbMedium.IsChecked.Value; 
            bool sizeLarge =  rbLarge.IsChecked.Value;
            bool sizeExtraLarge = rbExtraLarge.IsChecked.Value;

            bool hasPepporoni = cbPepporoni.IsChecked.Value;
            bool hasCheese = cbCheese.IsChecked.Value;
            bool hasMushroom = cbMushroom.IsChecked.Value;
            bool hasPineapple = cbPineapple.IsChecked.Value;
            bool hasOnion = cbOnion.IsChecked.Value;

            bool drinkSmall = rbDrinkSmall.IsChecked.Value;
            bool drinkMedium = rbDrinkMedium.IsChecked.Value;
            bool drinkLarge = rbDrinkLarge.IsChecked.Value;
            bool drinkXl = rbDrinkXL.IsChecked.Value;

            double sizePrice = 0;
          
            if (sizeSmall)
            {
                sizePrice = 5.25;
                rtbRunReceipts.Text += $"Small Pizza - {sizePrice.ToString("C")}";
                amount += sizePrice;
            }
            else if (sizeMedium)
            {
                sizePrice = 7.50;
                rtbRunReceipts.Text += $"Medium Pizza - {sizePrice.ToString("C")}";
                amount += sizePrice;
            }
            else if (sizeLarge)
            {
                sizePrice = 10.75;
                rtbRunReceipts.Text += $"Large Pizza - {sizePrice.ToString("C")}";
                amount += sizePrice;
            }
            else if (sizeExtraLarge)
            {
                sizePrice = 12;
                rtbRunReceipts.Text += $"Extra Large Pizza - {sizePrice.ToString("C")}";
                amount += sizePrice;
            }

            double toppingPrice = 0;
            rtbRunReceipts.Text += "\n\nTopping: \n";
            if (hasPepporoni)
            {
                toppingPrice = 3;
                rtbRunReceipts.Text += $"Pepporoni - {toppingPrice.ToString("C")}\n";
                amount += toppingPrice;
            }
            if (hasCheese)
            {
                toppingPrice = 1.50;
                rtbRunReceipts.Text += $"Cheese - {toppingPrice.ToString("C")}\n";
                amount += toppingPrice;
            }
            if (hasMushroom)
            {
                toppingPrice = 2.50;
                rtbRunReceipts.Text += $"Mushroom - {toppingPrice.ToString("C")} \n";
                amount += toppingPrice;
            }
            if (hasPineapple)
            {
                toppingPrice = 3.50;
                rtbRunReceipts.Text += $"Pineapple - {toppingPrice.ToString("C")} \n";
                amount += toppingPrice;
            }
            if (hasOnion)
            {
                toppingPrice = 0.95;
                rtbRunReceipts.Text += $"Onion - {toppingPrice.ToString("C")} \n";
                amount += toppingPrice;
            }

            double drinkPrice = 0;
            rtbRunReceipts.Text += "\nDrink Size: \n";
            if (drinkSmall)
            {
               drinkPrice = 2.25;
               rtbRunReceipts.Text += $"Small - {drinkPrice.ToString("C")}";
                amount += drinkPrice;
            }
            else if (drinkMedium)
            {
                drinkPrice = 3.99;
                rtbRunReceipts.Text += $"Medium- {drinkPrice.ToString("C")}";
                amount += drinkPrice;
            }
            else if (drinkLarge)
            {
               drinkPrice = 5.25;
                rtbRunReceipts.Text += $"Large - {drinkPrice.ToString("C")}";
                amount += drinkPrice;
            }
            else if (drinkXl)
            {
                drinkPrice = 6.50;
                rtbRunReceipts.Text += $"Extra Large - {drinkPrice.ToString("C")}";
                amount += drinkPrice;
            }
           
            rtbRunReceipts.Text += $"\n\nTotal: {amount.ToString("C")}\n";


        }

        
    }
}
