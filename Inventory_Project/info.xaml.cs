/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 05/10/2018
 * Time: 11:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Inventory_Project
{
	/// <summary>
	/// Interaction logic for info.xaml
	/// </summary>
	public partial class info : Window
	{
		
		public product datacontext{get;set;}
		public int quantity =0;
		int availables = 0;
		int price = 0;
		int newquantity = 0;
		public double totalprice = 0;
		public info(product data)
		{
			InitializeComponent();
			datacontext = data;
			DataContext = datacontext;
			price_textbox.IsEnabled = false;
			available.IsEnabled = false;
			quantity_textbox.Text = quantity.ToString();
			price_textbox.Text = price.ToString();
			available.Text = availables.ToString();
		}
		void Ok_Click(object sender, RoutedEventArgs e)
		{
			
			int.TryParse(quantity_textbox.Text,out quantity);
			int.TryParse(price_textbox.Text,out price);
			int.TryParse(available.Text, out availables);
			
			newquantity = quantity;
			totalprice = datacontext.OriginalPrice*quantity;
			
			datacontext.DateofOrder = dateoforder_textbox.Text;
			
			if(quantity>datacontext.Quantity)
			{
				MessageBox.Show("Insufficient quantity!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
		
			else if(quantity==0 || quantity_textbox.Text == "")
			{
				MessageBox.Show("Invalid! Please Input quantity!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(dateoforder_textbox.Text == "")
			{
				MessageBox.Show("Invalid! Please Input Date of Order!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(MessageBox.Show("The total price is P"+totalprice+"\n Do you want to continue?","",MessageBoxButton.OKCancel,MessageBoxImage.Information) == MessageBoxResult.OK)
			{
				
				datacontext.Totalprice = totalprice;
				
				datacontext.Status = "NEW";
				datacontext = DataContext as product;
				Close();
			}
			else{
				return;
			}
			MessageBox.Show("Product Added to the selected Product TAB Successfully!");
		}
	}
}