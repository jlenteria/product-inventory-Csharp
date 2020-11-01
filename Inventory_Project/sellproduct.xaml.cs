/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 10/05/2018
 * Time: 11:06
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
	/// Interaction logic for sellproduct.xaml
	/// </summary>
	public partial class sellproduct : Window
	{
		public int closess;
		public product datas{get;set;}
		public int quantity = 0;
		int availablequantity =0;
		public int newquantity = 0;
		public double totalretail = 0;
		
		public sellproduct(product data)
		{
			InitializeComponent();
			
			datas = data;
			DataContext = datas;
						
			total_quantity.Text = quantity.ToString();
			
			retailprice.Text = totalretail.ToString();
			available_quantity.IsEnabled = false;
			retailprice.IsEnabled = false;
			
		}
		void OK_Click(object sender, RoutedEventArgs e)
		{
			int.TryParse(total_quantity.Text,out quantity);
			double.TryParse(retailprice.Text, out totalretail);
			int.TryParse(available_quantity.Text, out availablequantity);
			
			if(availablequantity==0)
			{
				closess = 1;
				
				MessageBox.Show("Out of Stock you cannot sell this product!");
				Close();
			}
			else{
			retailprice.Text = totalretail.ToString();
			available_quantity.Text = availablequantity.ToString();
			total_quantity.Text = quantity.ToString();
			
			newquantity = availablequantity-quantity;
			totalretail *= quantity;
			
			if(quantity>availablequantity)
			{
				MessageBox.Show("Insufficient quantity!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			
			else if(quantity==0 || total_quantity.Text == "")
			{
				MessageBox.Show("Invalid! Please Input Quantity!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(costumername.Text == "")
			{
				MessageBox.Show("Invalid! Please Input the Costumer Name!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(MessageBox.Show("Total price is P"+totalretail+"\n Continue to sell?","",MessageBoxButton.OKCancel,MessageBoxImage.Information) == MessageBoxResult.OK)
			{
				datas.Totalretail = totalretail;
			
				datas = DataContext as product;
				Close();
			}
			else{
				return;
			}
				MessageBox.Show("Product Added to the selected Product TAB Successfully!");
			}
			
		}
	}
}