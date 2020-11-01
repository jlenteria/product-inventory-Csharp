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
using System.Windows.Input;

namespace Inventory_Project
{
	/// <summary>
	/// Interaction logic for inventoryinfo.xaml
	/// </summary>
	public partial class inventoryinfo : Window
	{
		int id = 0;
		int totalquantity =0;
		int availablequantity=0;
		int originalprice=0;
		int retailprice=0;
		public int updatess;
		public int infor;
		public int closes = 0;
		public int p=0;
		public int s = 0;
		public int r =0;
		public int dd =0;
		public int update = 0;
		int picturenum;
		product products;
		bool is_input;
		public product datacontext{get;set;}
	
		public inventoryinfo(bool is_view_only = false)
		{
			InitializeComponent();
			
			l.IsEnabled = false;
			Previous.IsEnabled = false;
			is_input = false;
		}
		public void set(product value)
		{
			products =value;
			DataContext=products;
		}
		
		void Next_Click(object sender, RoutedEventArgs e)
		{
			Previous.IsEnabled = true;
			picturenum++;
			
			if(picturenum == 0)
			{
				image.Visibility = Visibility.Visible;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Hidden;
			}
			else if(picturenum == 1)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Visible;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Hidden;
				
			}
			else if(picturenum == 2)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Visible;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Hidden;
				
			}
			else if(picturenum == 3)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Visible;
				image4.Visibility = Visibility.Hidden;
				
			}
			else if(picturenum == 4)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Visible;
				Next.IsEnabled = false;
			}
		}
		void Previous_Click(object sender, RoutedEventArgs e)
		{
			Next.IsEnabled = true;
			picturenum--;
			
			if(picturenum == 0)
			{
				Previous.IsEnabled = false;
				image.Visibility = Visibility.Visible;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Hidden;
				
				
			}
			else if(picturenum == 1)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Visible;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Hidden;
			
			}
			else if(picturenum == 2)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Visible;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Hidden;
				
			}
			else if(picturenum == 3)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Visible;
				image4.Visibility = Visibility.Hidden;
				
			}
			else if(picturenum == 4)
			{
				image.Visibility = Visibility.Hidden;
				image1.Visibility = Visibility.Hidden;
				image2.Visibility = Visibility.Hidden;
				image3.Visibility = Visibility.Hidden;
				image4.Visibility = Visibility.Visible;
				Next.IsEnabled =false;
				
			}
			
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			
			closes = 1;
			
			Close();
		}
		void purchase_Click(object sender, RoutedEventArgs e)
		{
			p =1;
			Close();
		}
		void sell_Click(object sender, RoutedEventArgs e)
		{
			s=1;
			Close();
		}
		void returns_Click(object sender, RoutedEventArgs e)
		{
			Close();
			
		}
		void Update_Click(object sender, RoutedEventArgs e)
		{
			
		
			int.TryParse(d.Text,out originalprice);
			int.TryParse(c.Text,out retailprice);
			int.TryParse(h.Text,out availablequantity);
			int.TryParse(g.Text,out totalquantity);
			
			
			l.Text = id.ToString();
			d.Text = originalprice.ToString();
			c.Text = retailprice.ToString();
			h.Text = availablequantity.ToString();
			g.Text = totalquantity.ToString();
			
		
			if(l.Text == "" || d.Text == "" || c.Text == "" || h.Text == "" ||g.Text =="" || a.Text== "" ||b.Text == "" ||ee.Text == "" || f.Text == "" || j.Text == "" ||k.Text == "")
			{
				MessageBox.Show("Please Input data first!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(originalprice>retailprice)
			{
				MessageBox.Show("Please input retail price bigger .than the original price!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(originalprice<0 || retailprice<0)
			{
				MessageBox.Show("Please Input a valid Price!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(availablequantity<0 || totalquantity<0)
			{
				MessageBox.Show("Please a valid Quantity!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}
			else if(availablequantity>totalquantity)
			{
				MessageBox.Show("Please Input lower available quantity!","",MessageBoxButton.OK,MessageBoxImage.Error);
				return;
			}

			
			
		
			
			else if(MessageBox.Show("Are u sure you want to update?","",MessageBoxButton.YesNo,MessageBoxImage.Information)== MessageBoxResult.Yes)
			{
				Close();
			}
			else
			{
				return;
			}
			
			
		}
		void dispose_Click(object sender, RoutedEventArgs e)
		{
			
			Close();
		}
		
	}
}