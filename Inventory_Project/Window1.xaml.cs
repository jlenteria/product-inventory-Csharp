/*
 * Created by SharpDevelop.
 * User: HackDaFOX
 * Date: 04/10/2018
 * Time: 11:52 PM
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
using System.ComponentModel;

namespace Inventory_Project
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public class product
	{
		public int Selected{get;set;}
		public string Name{get;set;}
		public string Image{get;set;}
		public string Image1{get;set;}
		public string Image2{get;set;}
		public string Image3{get;set;}
		public string Image4{get;set;}
		public int IdNo{get;set;}
		public string Description{get;set;}
		public string Category{get;set;}
		public  int TotalQuantity{get;set;}
		public int Quantity{get;set;}
		public string Brand{get;set;}
		public string Supplier{get;set;}
		public double OriginalPrice{get;set;}
		public string DateExpiration{get;set;}
		public double RetailPrice{get;set;}
		public string Status{get;set;}
		public string DateofOrder{get;set;}
		
		public int totalsell{get;set;}
		public int totalpurchased{get;set;}
		
		public double Totalprice{get;set;}
		public double Totalretail{get;set;}
		
		public double categorytotalprofit{get;set;}
		public int categorycostumer{get;set;}
		public int categorysold{get;set;}
		public int categoryreturned{get;set;}
		public int categorypurchased{get;set;}
		public int catergorydisposed{get;set;}
		public int caterogoryallproducts{get;set;}
		

		
	}
	public partial class Window1 : Window
	{
		
	
		public string GroupBinding = "Category";
		double totalprce=0;
		double totalretail=0;
		string dateoforder;
		int tquantity = 0;
		int totalinventory =0;
		int totalcustomers=0;
		int totalsoldProducts=0;
		int totalunsoldProducts=0;
		double totalProfits = 0;
		double newprice = 0;
		double newprice1 =0;double newprice2 =0;double newprice3 =0;double newprice4 =0;double newprice5 =0;
		double newretail1 = 0;double newretail2 = 0;double newretail3 = 0;double newretail4 = 0;double newretail5 = 0;
		double newretail = 0;
		int solds = 0;
		int removve = 0;
		int unsolds =0;
		 double categoryprofit = 0; double categoryprofit1 = 0; double categoryprofit2 = 0; double categoryprofit3 = 0; double categoryprofit4 = 0;
		 int customers = 0;int customers1 = 0;int customers2 = 0;int customers3 = 0;int customers4 = 0;
		 int sold = 0; int sold1 = 0; int sold2 = 0; int sold3 = 0; int sold4 = 0;
		 int disposedd = 0; int disposed1 = 0; int disposed2 = 0; int disposed3 = 0; int disposed4 = 0;
		 int returned = 0; int returned1 = 0; int returned2 = 0; int returned3 = 0; int returned4 = 0;
		 int purchased = 0;int purchased1 = 0;int purchased2 = 0;int purchased3 = 0;int purchased4 = 0;
		 int productt=0;int productt1=0;int productt2=0;int productt3=0;int productt4=0;
		
		List<product>product_list;//SUPPLIER'S PRODUCT
		List<product>product_purchase;//2nd tab
		List<product>inventory_list;//INVENTORY PRODUCT
	
		public Window1()
		{
			
			
			product_purchase = new List<product>(){};
			InitializeComponent();
			
			
			totalcostumer.IsEnabled = false;
			totalinventoryy.IsEnabled = false;
			totalprofit.IsEnabled = false;
			totalsold.IsEnabled = false;
			totalunsold.IsEnabled = false;
			
		
		inventory_list = new List<product>{
				new product(){Name = "Paracetamol", RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic 4.png",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\paracetamol.jpg",DateofOrder = "10/08/2018", IdNo = 100001, Description = " Is used for relief fom headache and fever, as well as, minor aches and pains such as backache, menstrual cramps, muscular aches, minor arthritis pain, toothache,  and pain associated with the common cold and flu.",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 10,DateExpiration = "15/01/2020",Status = "Normal"},
				new product(){Name = "Buscopan",RetailPrice = 20,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan.jpg",DateofOrder = "10/08/2018",IdNo = 100002, Description = " If effectively takes away the cause of the pain because it develops a muscle-relaxing effect, actinf only where the pains occurs, in the abdomen",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 15,DateExpiration = "15/01/2020",Status = "Normal"},
				new product(){Name = "Medicol Advance",RetailPrice = 20,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 2.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Medicol Advance.png",DateofOrder = "10/08/2018",IdNo = 100003, Description = "The product contain ibuprofen which belongs to a group of medicine called nonsteroidal anti-inflammatory drugs(NSAIDs).	",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 17,DateExpiration = "15/01/2020",Status = "Normal"},
				new product(){Name = "Aik Cheong Matcha",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\aik.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\aik 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\aik 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\aik 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\aik.jpg",IdNo = 100063, Description = "Aik Cheong Matcha is made only from green tea.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Matcha",Supplier = "Alibaba",Status = "Normal", OriginalPrice = 215,RetailPrice = 220, DateExpiration = "02/06/2020", DateofOrder = "10/08/2015"},
				new product(){Name = "Del Monte 10% Pineapple Juice",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\4 BEVERAGES\pine 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\pine 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\pine 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\pine 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\pineapple.jpg",IdNo = 100061, Description = "With vitamins A-C-E to support the immune system",Category = "Beverages",TotalQuantity = 5, Quantity = 5,Brand = "Del Monte",Supplier = "Alibaba",OriginalPrice = 32,DateExpiration = "18/08/2020",Status = "Normal",DateofOrder = "10/08/2015"},
				new product(){Name = "Lipton Lemon Iced Tea 2.71 kg",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\lipton 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\lipton 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\lipton 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\lipton 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\lipton.jpg",IdNo = 100062, Description = "It relish a vibrant green tea with mint",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Lipton",Supplier = "Alibaba",OriginalPrice = 554,DateExpiration = "15/03/2019",Status = "Normal",DateofOrder = "10/08/2015"},
				new product(){Name = "Huawei Nova 3i",RetailPrice = 15000,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Huawei Nova 3i.jpeg",IdNo = 100032, Description = "Dare to be colourful,Four AI cameras, Dare to be bold",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Huawei",Supplier = "Jonel Tandugon",OriginalPrice = 14900,DateExpiration = "1-3 years lifespan",Status = "Normal"},
				new product(){Name = "Oppo F7",RetailPrice = 22000,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Oppo F7.jpg",IdNo = 100031, Description = "With a glossy unique design to suit your personal style.",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Oppo",Supplier = "Jonel Tandugon",OriginalPrice = 21990,DateExpiration = "1-3 years lifespan",Status = "Normal"},
				new product(){Name = "Xiaomi Redmi S2",RetailPrice = 10000,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Xiaomi Redmi S2.jpg",IdNo = 100033, Description = "16MP AI selfies.	",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Xiaomi",Supplier = "Jonel Tandugon",OriginalPrice = 9890,DateExpiration = "1-3 years lifespan",Status = "Normal"},
				new product(){Name = "Lebron Soldier 10",RetailPrice = 9500,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Shoes\lebron soldier 10.jpg",IdNo = 100017, Description = "One of the basketball shoes of lebron James ; Color black , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 9483,DateExpiration = "N/A",Status = "Normal"},
				new product(){Name = "Lebron Witness II",RetailPrice = 6985,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Shoes\Lebron Witness 2.jpg",IdNo = 100018, Description = "One of the basketball shoes of lebron James ; Color balck , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 6785,DateExpiration = "N/A",Status = "Normal"},
				new product(){Name = "Ambasador 7",RetailPrice = 10000,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Shoes\ambassador 7.jpg",IdNo =100016, Description = "One of the basketball shoes of lebron James ; Color black , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 9899,DateExpiration = "N/A",Status = "Normal"},
				new product(){Name = "Intensive Whitening BB Cream",RetailPrice = 400,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\bb.jpg",IdNo = 100046, Description = "Instant cover blemishes and imperfections as it works to intensively whiten skin",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "Belo",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan",Status = "Normal"},
				new product(){Name = "Blush Stick",RetailPrice = 410,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\blush.jpg",IdNo = 100047, Description = "It provides long-lasting, natural-looking color to your cheeks",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "Fashion 21",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan",Status = "Normal"},
				new product(){Name = "Eye Make Up Remover",RetailPrice = 400,DateofOrder = "10/08/2018",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\eyemakeupremover.jpg",IdNo = 100048, Description = "Gently removes all the types of eye make-up and impurities while moisturizing the skin around the eye area with organic Jojoba Oil",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "Misline",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan",Status = "Normal"},
			};
			
			Inventoy_Product.ItemsSource = inventory_list;
			Sell_Inventory.ItemsSource = inventory_list;
			Return_Inventory.ItemsSource = inventory_list;
			dispose_Inventory.ItemsSource = inventory_list;
			update_Product.ItemsSource = inventory_list;
			
			product_list = new List<product>{
				new product(){Name = "Paracetamol",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\biogesic 4.png",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\paracetamol.jpg",DateofOrder = "10/10/2018", IdNo = 100001, Description = " Is used for relief fom headache and fever, as well as, minor aches and pains such as backache, menstrual cramps, muscular aches, minor arthritis pain, toothache,  and pain associated with the common cold and flu.",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 10,DateExpiration = "15/01/2020"},
				new product(){Name = "Buscopan",RetailPrice = 20,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\buscopan.jpg",DateofOrder = "10/10/2018",IdNo = 100002, Description = " If effectively takes away the cause of the pain because it develops a muscle-relaxing effect, actinf only where the pains occurs, in the abdomen",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 15,DateExpiration = "15/01/2020"},
				new product(){Name = "Medicol Advance",RetailPrice = 20,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\medicol 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Medicol Advance.png",DateofOrder = "10/10/2018",IdNo = 100003, Description = "The product contain ibuprofen which belongs to a group of medicine called nonsteroidal anti-inflammatory drugs(NSAIDs).	",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 17,DateExpiration = "15/01/2020"},
				new product(){Name = "Loperamide",RetailPrice = 12, Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\loperamide  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\loperamide 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\loperamide 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\loperamide 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Loperamide.jpg",IdNo = 100004, Description = "This medicine contain loperamide,  an antidiarrheal agent which slow internal movement and reduces fluid and salt loss in the intestines, resulting in improved stool consistency",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 16.50,DateExpiration = "15/01/2020"},
				new product(){Name = "Dolfenal",RetailPrice = 12,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\dolfenal  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\dolfenal 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\dolfenal 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\dolfenal 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Dolfenal.jpg",IdNo = 100005, Description = "For the relief of pain associated with muscoskeletal and joint disorder including osteoathritis and rheumatoid athritis",Category = "Medicine",TotalQuantity = 12, Quantity = 2,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 18.50,DateExpiration = "15/01/2020"},
				new product(){Name = "Solmux",RetailPrice = 12,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\solmux  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\solmux 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\solmux 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\solmux 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\solmux.jpg",IdNo = 100006, Description = "Relief of cough characterized by excessive or sticky sputum or phlegm to help treat respiratory tract disorder such as acute or chronic bronchitis and chronic obstuctive pulmonary desease(COPD).",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 15,DateExpiration = "15/01/2020"},
				new product(){Name = "Allerkid",RetailPrice = 12,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\allerkid  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\allerkid 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\allerkid 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\allerkid 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Allerkid.jpg",IdNo = 100007, Description = "Allergic rhinitis such as sneezing, runny, itchy  nose, and itchy water eyes.",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 130,DateExpiration = "15/01/2020"},
				new product(){Name = "Appebon Kid",RetailPrice = 12,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\appebon  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\appebon 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\appebon 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\appebon 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Appebon Kid.jpg",IdNo =100008, Description = "A dietary supplement to help provide children with nutrients essentials for energy and to help improve appetite.",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice =170,DateExpiration = "15/01/2020"},
				new product(){Name = "Ascorbic Acid",RetailPrice = 12,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ascorbic  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ascorbic 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ascorbic 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ascorbic 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ascorbic acid.jpg",IdNo = 100009, Description = "Nutritional supplements are used for the prevention and treatment of Vitamins C deficiency in infants and children",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 200,DateExpiration = "15/01/2020"},
				new product(){Name = "Decolgen Forte",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\decolgen  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\decolgen 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\decolgen 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\decolgen 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Decolgen Forte.jpg",IdNo = 100010, Description = " Relief of clogged nose, runy rose, postnasal drip, itchy and watery eyes, sneezing, headache, body aches, and fever associated with the common cold, allergic rhitinis, sinusitis, flu, and othe minor respiratory tract infection",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 14.50,DateExpiration = "15/01/2020"},
				new product(){Name = "Alaxan FR",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\alaxan  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\alaxan 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\alaxan 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\alaxan 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Alaxan FR.png",IdNo = 100011, Description = "Relief of mild to moderately severe pain of muscoskeletal origin suc as muscle pain myalgia, athritis, rheumatism, sprain, strin, bursitis, tendonitis, backache and stiff neck",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 9.50,DateExpiration = "15/01/2020"},
				new product(){Name = "Ferlin",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ferlin  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ferlin 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ferlin 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ferlin 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ferlin.jpg",IdNo = 100012, Description = "Used  for the prevention and treatment of iron deficiency anemia in infants and children",Category = "Medicine",TotalQuantity =7, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 30,DateExpiration = "15/01/2020"},
				new product(){Name = "Nutroplex",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\nutriflex  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\nutriflex 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\nutriflex 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\nutriflex 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Nutroplex.jpg",IdNo = 100013, Description = "A nutritional supplement to help provide essential vitamins and minerals for mental allertness, to help prevent iron defciency anemia",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice =90,DateExpiration = "15/01/2020"},
				new product(){Name = "Colecalciferol",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\cole  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\cole 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\cole 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\cole 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Colecalciferol.jpg",IdNo = 100014, Description = "Contains Vitamins D is required for normal bone formation",Category = "Medicine",TotalQuantity =8, Quantity = 2,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice = 70,DateExpiration = "15/01/2020"},
				new product(){Name = "Oral Rehydration Salt",RetailPrice = 15,Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ors  1.jpg", Image2 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ors 2.jpg",Image3 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ors 3.jpg",Image4= @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\ors 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\MEDICINE\Oral Rehydration Salt.jpg",IdNo = 100015, Description = "The treatment of children and adults with dehydration due the diarrhea",Category = "Medicine",TotalQuantity = 5, Quantity = 5,Brand = "Unilab",Supplier = "Jonel's Medical Supplies",OriginalPrice =25,DateExpiration = "15/01/2020"},	
				
				
				
				
				new product(){Name = "Aik Cheong Matcha",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\aik.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\aik 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\aik 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\aik 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\aik.jpg",IdNo = 100063, Description = "Aik Cheong Matcha is made only from green tea.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Matcha",Supplier = "Alibaba", OriginalPrice = 215,RetailPrice = 220, DateExpiration = "02/06/2020", DateofOrder = "02/06/2015"},
				new product(){Name = "Del Monte 10% Pineapple Juice",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\pine 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\pine 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\pine 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\pine 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\pineapple.jpg",IdNo = 100061, Description = "With vitamins A-C-E to support the immune system",Category = "Beverages",TotalQuantity = 5, Quantity = 5,Brand = "Del Monte",Supplier = "Alibaba",OriginalPrice = 32,DateExpiration = "18/08/2020"},
				new product(){Name = "Lipton Lemon Iced Tea 2.71 kg",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\lipton 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\lipton 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\lipton 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\lipton 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\lipton.jpg",IdNo = 100062, Description = "It relish a vibrant green tea with mint",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Lipton",Supplier = "Alibaba",OriginalPrice = 554,DateExpiration = "15/03/2019"},
				new product(){Name = "Birch Tree Fortified 300g",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\birch 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\birch 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\birch 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\birch 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\birch tree.jpg",IdNo = 100064, Description = "Only milk drink with FibroBoost.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Cow Head",Supplier = "Alibaba",OriginalPrice = 105,DateExpiration = "31/03/2019"},
				new product(){Name = "Jolly Coconut Milk",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\jolly 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\jolly 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\jolly 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\jolly 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\jolly.jpg",IdNo = 100065, Description = "Purely in coconut milk",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Jolly",Supplier = "Alibaba",OriginalPrice = 72,DateExpiration = "22/06/2020"},
				new product(){Name = "Green Coffee",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\grren 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\green 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\Green 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\green 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\green tea.jpg",IdNo = 100066, Description = "One of the popular beverages and coffee beans are source of coffee powder.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Green Coffee",Supplier = "Alibaba",OriginalPrice = 108,DateExpiration = "01/04/2020"},
				new product(){Name = "Nestea Honey Blend 450g",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\nestea 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\nestea 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\nestea 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\nestea4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\nestea.jpg",IdNo = 100067, Description = "A flavored juice and nutritious with vitamin C.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Nestea",Supplier = "Alibaba",OriginalPrice = 173,DateExpiration = "19/08/2019"},
				new product(){Name = "Vita Plus Dalandan",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\vita 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\vita 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\vita 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\vita 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\vita plus.jpg",IdNo = 100068, Description = "The juicy tangy and sharp but sweet pulps are definitely orange in color.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Vita Plus",Supplier = "Alibaba",OriginalPrice = 280,DateExpiration = "12/05/2019"},
				new product(){Name = "Ensure Gold 1.6",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\ensure 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\ensre 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\ensure 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\ensure 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\ensure.jpg",IdNo = 100069, Description = "It contains well-balanced proportions of macronutrients.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Ensure",Supplier = "Alibaba",OriginalPrice = 2380,DateExpiration = "01/02/2020"},
				new product(){Name = "Richarge",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\richarge 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\richarge 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\richarge 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\richarge 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\richarge.jpg",IdNo = 100070, Description = "A juice drink loaded with 7 potent antioxidants.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Royale",Supplier = "Alibaba",OriginalPrice = 390,DateExpiration = "28/06/2020"},
				new product(){Name = "5 pcs. Tang Juice 25g ",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\tang1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\tang 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\tang 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\tang 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\tang.jpg",IdNo = 100071, Description = "A flavored juice and nutritious drinks.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Tang",Supplier = "Alibaba",OriginalPrice = 60,DateExpiration = "18/08/2020"},
				new product(){Name = "Dragon Fruit Soda",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\dragon 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\dtagon 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\dragon 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\dragon 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\dragon fruit.jpg",IdNo = 100072, Description = "All natural and 30 calories per serving.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "French Soda",Supplier = "Alibaba",OriginalPrice = 250,DateExpiration = "30/08/2021"},
				new product(){Name = "Sprite Soda Drink 1.5L",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\sprite1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\sprite2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\sprite 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\sprite 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\sprite.jpg",IdNo = 100073, Description = "A light drink for snack time and for lunch.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Sprite",Supplier = "Alibaba",OriginalPrice = 55,DateExpiration = "22/01/2019"},
				new product(){Name = "Bundaberg Apple Cider 4 pack", Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\bundaberg 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\bundaberg 2.png",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\bundaberg 3.png",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\bundaberg 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\bundaberg.jpg",IdNo = 100074, Description = "A brewed soft drink is made the school way.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Bundaberg Brewed Drinks",Supplier = "Alibaba",OriginalPrice = 280,DateExpiration = "10/02/2019"},
				new product(){Name = "Japan Calpis Water 490ml",Image1 = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\calpis 1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\calpis 2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\calpis 3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\4 BEVERAGES\calpis 4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\BEVRERAGES PIC\calpis.jpg",IdNo = 100075, Description = "A milk based beverage widely loved in Japan.",Category = "Beverages",TotalQuantity = 5,Quantity = 5,Brand = "Calpis",Supplier = "Alibaba",OriginalPrice = 199,DateExpiration = "10/02/2019"},
				
					
			
				new product(){Name = "Intensive Whitening BB Cream",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\bb.jpg",IdNo = 100046, Description = "Instant cover blemishes and imperfections as it works to intensively whiten skin",Category = "Cosmetics",TotalQuantity =10,Quantity = 5,Brand = "Belo",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Blush Stick",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\blush.jpg",IdNo = 100047, Description = "It provides long-lasting, natural-looking color to your cheeks",Category = "Cosmetics",TotalQuantity = 11,Quantity = 5,Brand = "Fashion 21",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Eye Make Up Remover",Image =@"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\eyemakeupremover.jpg",IdNo = 100048, Description = "Gently removes all the types of eye make-up and impurities while moisturizing the skin around the eye area with organic Jojoba Oil",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "Misline",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Face Makeup Primer",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\facemakeup.jpg",IdNo = 100049, Description = "The answer to unwanted shine, fighting against excess oil to ensure a matte makeup result",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "Sace Lady",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},		
				new product(){Name = "Color Icon Eyeshadow Palette", Image =@"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\gg.jpg",IdNo = 100050, Description = "It has a five amazing shades in one convenient package",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "Wet n Wild",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Liquid Eyelash Growth Serum Enhancer",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\liquideyelash.jpg",IdNo = 100051, Description = "Helps in making the eyelashes naturally grow",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "BioAqua",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Professional Makeup Ombre Blush",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\prof.jpg",IdNo = 100052, Description = "Contains a must-have formula features two silky colors blended into one perfectly coordinated shade comnbo",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Super Stay Matte Ink Liquid Lipstick",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\super.jpg",IdNo = 100053, Description = "Intensely perfect matte lipstick that ink you lips up to 16 HR saturated liquid matte",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Tinted Lip Balm",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\tinted.jpg",IdNo = 100054, Description = "A blend of cocoa butter, beeswax, and all-natural plant oils that keeps your lips soft and moisturized throughout the day",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Two-way cake pressed powder with spf 35",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\twoway.jpg",IdNo = 100055, Description = "Combines the goodness of foundation and powder in one with added protection from UV rays with whitening effect",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Makeup Brush Set",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\Shopee_4b8c3018e4ee05e4bc9462f2c899c86b.jpg",IdNo = 100056, Description = "Made from high-density synthetic hair, soft and silky to touch",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Long-Lasting Liquid Matte Lipstick",Image =@"C:\Users\zenit\Desktop\semi_project\semi_project\Beauty Products\Shopee_a7a15687f420bc8479e615f1e1120248.jpg",IdNo = 100057, Description = "'Contains  Vitamin-E and rosehip seed-oil that helps in hydrating and softening your lips",Category = "Cosmetics",TotalQuantity=5, Quantity = 5,Brand = "BLK",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "No Seburn Blur Primer",Image =@"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\Shopee_b4124c865ef67bd10fc41f0f32c4b825.jpg",IdNo = 100058, Description = "A primer that makes the skin texture smooth and bright",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Browfessional Eyebrow",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\Shopee_edc5108602733f59259c582e8e63dc54.jpg",IdNo = 100059, Description = "Enriched with Vitamin E to boost,strengthen and condition brows plus Vitamin C to help promote hair growth",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				new product(){Name = "Delight Tony Tint",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Beauty Products\Shopee_f2421c355c08060a412d19e492f0abeb.jpg",IdNo = 100060, Description = "Contains the nourishing combination of Rosehip",Category = "Cosmetics",TotalQuantity = 5,Quantity = 5,Brand = "NYX",Supplier = "Shopee",OriginalPrice = 390,DateExpiration = "2-3 Years Lifespan"},
				
			
				new product(){Name = "Ambasador 7",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\ambasador 7.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\ambasador 7.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\ambassador 7.3jpg.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\ambassador 7.5jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\ambassador 7.jpg",IdNo =100016, Description = "One of the basketball shoes of lebron James ; Color black , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 9899,DateExpiration = "N/A"},
				new product(){Name = "Lebron Soldier 10",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\soldier 10.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\soldier 10.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\soldier 10.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\soldier 10.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\lebron soldier 10.jpg",IdNo = 100017, Description = "One of the basketball shoes of lebron James ; Color black , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 9483,DateExpiration = "N/A"},
				new product(){Name = "Lebron Witness II",	Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron witness 2.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron witness 2.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron witness 2.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron witness 2.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\lebron witness 2.jpg",IdNo = 100018, Description = "One of the basketball shoes of lebron James ; Color balck , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 6785,DateExpiration = "N/A"},
				new product(){Name = "Lebron XV EP 5",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron xv ep 15.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron xv ep 15.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron xv ep 15.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron xv ep 15.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\lebron xv ep 15.jpg",IdNo = 100019, Description = "One of the basketball shoes of lebron James ; Color black , blue,red",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 12594,DateExpiration = "N/A"},
				new product(){Name = "Lebron XII Low",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron 7.1 low.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron 7.2 low.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron 7.3 low.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\lebron 7.4low.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Shoes\lebron 7 .4low.jpg",IdNo = 100020, Description = "One of the basketball shoes of lebron James ; Colo:photo blue,University gold,gym blue",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 15080,DateExpiration = "N/A"},
				new product(){Name = "Kobe XI",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xi.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xi.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xi.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xi.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kobe xii.jpg",IdNo = 100021, Description = "One of the shoes of Kobe Bryan; color: Anthracite/Metalic silver-black lucid green",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 8535,DateExpiration = "N/A"},
				new product(){Name = "Kobe XII",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xii.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xii.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xii.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe xii.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kobe xii.jpg",IdNo = 100022, Description = "One of the shoes of Kobe Bryan; color: Blood red, White men",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 5975,DateExpiration = "N/A"},
				new product(){Name = "Kobe A.D",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe A.D.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe A.D.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe A.D.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe A.D.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kobe A.D.jpg",IdNo = 100023, Description = "Mighty ITPE Basketball shoes ;color:red white",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 7675,DateExpiration = "N/A"},
				new product(){Name = "Mamba Rage ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\mamba rage.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\mamba rage.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\mamba rage.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\mamba rage.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\mamba rage.jpg",IdNo = 100024, Description = "One of the shoes of Kobe Bryan; color: White , Grey",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 14299,DateExpiration = "N/A"},
				new product(){Name = "Kobe IX ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe IX.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe IX.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe IX.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kobe IX.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kobe IX.jpg",IdNo = 100025, Description = "One of the shoes of Kobe Bryan; color: Blue , Yellow,Light Blue",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 7995,DateExpiration = "N/A"},
				new product(){Name = "KD 10 ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd10.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd10.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd10.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd10.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\KD 10.jpg",IdNo = 100026, Description = "One of the basketball shoes of Kevin Durant;Color:Black White",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 8500,DateExpiration = "N/A"},
				new product(){Name = "KD 9 ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd99.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd9.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd9.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd9.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kd 9.jpg",IdNo = 100027, Description = "One of the basketball shoes of Kevin Durant;Color:Red, White",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 8495,DateExpiration = "N/A"},
				new product(){Name = "KD 8 elite ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd8.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd8.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd8.3.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd8.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kd 8 elite.jpg",IdNo = 100028, Description = "One of the basketball shoes of Kevin Durant;Color:Red, White",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 11989,DateExpiration = "N/A"},
				new product(){Name = "KD 7 Floral ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd7.1.jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd7.2.jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd7.3jpg.jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd7.4.jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kd 7 floral.jpg",IdNo = 100029, Description = "One of the basketball shoes of Kevin Durant;Color:Black, FLower Print",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 8500,DateExpiration = "N/A"},
				new product(){Name = "KD 6 ",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd 6.1.png",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd 6.2.png",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd 6.3png.png",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\SHOES\kd 6.4.png",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\SHOES\kd 6.jpg",IdNo = 100030, Description = "One of the basketball shoes of Kevin Durant;Color:Black, Red, Grey",Category = "Shoes",TotalQuantity = 5,Quantity = 5,Brand = "Nike",Supplier = "Bonfox NikeShoes",OriginalPrice = 9585,DateExpiration = "N/A"},
				
			
				
				
				new product(){Name = "Oppo F7",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo F7(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo F7(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo F7(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo F7(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Oppo F7.jpg",IdNo = 100031, Description = "With a glossy unique design to suit your personal style.",Category = "Mobile",TotalQuantity = 14, Quantity = 6,Brand = "Oppo",Supplier = "Jonel Tandugon",OriginalPrice = 21990,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Huawei Nova 3i",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Huawei Nova 3i(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Huawei Nova 3i(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Huawei Nova 3i(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Huawei Nova 3i(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Huawei Nova 3i.jpeg",IdNo = 100032, Description = "Dare to be colourful,Four AI cameras, Dare to be bold",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Huawei",Supplier = "Jonel Tandugon",OriginalPrice = 14900,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Xiaomi Redmi S2",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi_Redmi S2(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi_Redmi S2(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi_Redmi S2(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi_Redmi S2(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Xiaomi Redmi S2.jpg",IdNo = 100033, Description = "16MP AI selfies.	",Category = "Mobile",TotalQuantity =5, Quantity = 3,Brand = "Xiaomi",Supplier = "Jonel Tandugon",OriginalPrice = 9890,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Asus Zenfone 5Z",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone 5Z(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone 5Z(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone 5Z(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone 5Z(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Asus Zenfone 5Z.jpeg",IdNo = 100034, Description = "Ai powered performance, we <3 Photo",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Asus",Supplier = "Jonel Tandugon",OriginalPrice = 29990,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Xiaomi Redmi Note 5",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi Redmi Note 5(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi Redmi Note 5(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi Redmi Note 5(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Xiaomi Redmi Note 5(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Xiaomi Redmi Note 5.png",IdNo = 100035, Description = "Redmi Note 5 India's all-rounder",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Xiaomi",Supplier = "Jonel Tandugon",OriginalPrice = 11000,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Oppo Find X",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo Find X(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo Find X(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo Find X(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Oppo Find X(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Oppo Find X.jpeg",IdNo = 100036, Description = "Simple,Find the future, FIND X.",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Oppo",Supplier = "Jonel Tandugon",OriginalPrice = 49990,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Vivo Y71",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo Y71(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo Y71(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo Y71(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo Y71(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Vivo Y71.jpg",IdNo = 100037, Description = "An incredible smartphone with more on both power and poise.",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Vivo",Supplier = "Jonel Tandugon",OriginalPrice = 6990,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Asus Zenfone Max Pro (M1)",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone Max Pro(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone Max Pro(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone Max Pro(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Asus Zenfone Max Pro(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Asus Zenfone Max Pro.jpeg",IdNo = 100038, Description = "Zenfone Max Pro is your enduring companion, always ready to capture every special moment.",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Asus",Supplier = "Jonel Tandugon",OriginalPrice =13995,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Samsung Galaxy J7 Pro",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\ASUS ROG Phone(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\ASUS ROG Phone(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\ASUS ROG Phone(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\ASUS ROG Phone(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Samsung Galaxy J7 Pro.jpeg",IdNo = 100039, Description = "Elegant Metal and Glass finish, Stunning HD display,Incredible low light photos. Beyond expectations. Within reach.",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Samsung",Supplier = "Jonel Tandugon",OriginalPrice = 10990,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Asus ROG phone",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\AppleiPhoneX(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\AppleiPhoneX(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\AppleiPhoneX(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\AppleiPhoneX(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Asus ROG Phone.jpeg",IdNo = 100040, Description = "World's Fastest 2.96GHZ QUALCOMM SDM845,INNOVATIVE 3D VAPOR-CHAMBER cooling, BUILT BY GAMERS FOR GAMERS",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Asus",Supplier = "Jonel Tandugon",OriginalPrice = 482006,DateExpiration = "1-3 years lifespan"},
				
				new product(){Name = "POCCO PHONE 1",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Xiaomi POCOPHONE F1.jpg",IdNo = 100041, Description = "Master of speed, the flagship killer killer",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Pocco",Supplier = "Jonel Tandugon",OriginalPrice = 16990,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Apple Iphone X",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Apple iPhoneX(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Apple iPhoneX(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Apple iPhoneX(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Apple iPhoneX(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Apple iPhone X.jpeg",IdNo = 100042, Description = "It's an Iphone, Think different",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Iphone",Supplier = "Jonel Tandugon",OriginalPrice = 64834,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Vivo V11",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo V11(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo V11(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo V11(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Vivo V11(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Vivo V11.jpeg",IdNo = 100043, Description = "In display finger print scanner, Perfect shot perfect view",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Vivo",Supplier = "Jonel Tandugon",OriginalPrice =19999,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Samsung Galaxy S9",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Samsung Galaxy S9(1).jpg",IdNo = 100044, Description = "The camera reimagined, film your story as you intended",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Samsung",Supplier = "Jonel Tandugon",OriginalPrice = 31000,DateExpiration = "1-3 years lifespan"},
				new product(){Name = "Nokia 7 Plus",Image1 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Nokia 7 Plus(1).jpg",Image2 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Nokia 7 Plus(2).jpg",Image3 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Nokia 7 Plus(3).jpg",Image4 = @"C:\Users\zenit\Desktop\semi_project\semi_project\Mobile\Nokia 7 Plus(4).jpg",Image = @"C:\Users\zenit\Desktop\Inventory_Project\Inventory_Project\Mobile\Nokia 7 Plus.jpeg",IdNo = 100045	, Description = "A phone you can rely on",Category = "Mobile",TotalQuantity = 5, Quantity = 5,Brand = "Nokia",Supplier = "Jonel Tandugon",OriginalPrice =17690,DateExpiration = "1-3 years lifespan"},				
				
			};
			
			foreach(product product in inventory_list)
			{
				
				totalinventory = totalinventory+product.Quantity;
				totalProfits = totalprce-totalretail;
				
				if(product.Category == "Medicine")
				{
					productt += product.TotalQuantity;
				}
				if(product.Category == "Shoes")
				{
					productt2+=product.TotalQuantity;
				}
				if(product.Category == "Cosmetics")
				{
					productt3+=product.TotalQuantity;
				}
				if(product.Category == "Beverages")
				{
					productt4+=product.TotalQuantity;
				}
				if(product.Category == "Mobile")
				{
					productt1+=product.TotalQuantity;
				}
					
				
			}
			
			refresh();
		}
		void refresh(){
			
			
			
			Supplier_Products.ItemsSource = null;
			Supplier_Products.ItemsSource = product_list;
				
			totalinventoryy.Text = totalinventory.ToString();
			totalunsold.Text = totalunsoldProducts.ToString();
			totalsold.Text = totalsoldProducts.ToString();
			totalprofit.Text = totalProfits.ToString();
			totalcostumer.Text = totalcustomers.ToString();	
			medicine_profit.Text = categoryprofit.ToString();mobile_profit.Text = categoryprofit1.ToString();beverages_profit.Text = categoryprofit2.ToString();shoes_profit.Text = categoryprofit3.ToString();cosmetics_profit.Text = categoryprofit4.ToString();

			medicine_costumer.Text = customers.ToString();
			medicine_allproducts.Text =productt.ToString();
			medicine_purchased.Text = purchased.ToString();
			medicine_returned.Text = returned.ToString();
			medicine_sold.Text = sold.ToString();
			medicine_disposed.Text =disposedd.ToString();
	
			mobile_costumer.Text = customers1.ToString();
			mobile_disposed.Text = disposed1.ToString();
			mobile_purchased.Text = purchased1.ToString();
			mobile_returned.Text = returned1.ToString();
			mobile_sold.Text = sold1.ToString();
			mobile_totalproducts.Text=productt1.ToString();
			
			shoes_products.Text = productt2.ToString();
			shoes_purchased.Text =purchased2.ToString();
			shoes_returened.Text = returned2.ToString();
			shoes_sold.Text = sold2.ToString();
			shoes_disposed.Text = disposed2.ToString();
			shoes_costumer.Text = customers2.ToString();
				
			cosmetics_purchased.Text = purchased3.ToString();
			cosmetics_disposed.Text = disposed3.ToString();
			cosmetics_allproducts.Text = productt3.ToString();
			cosmetics_sold.Text =sold3.ToString();
			cosmetics_costumer.Text =customers3.ToString();
			cosmetics_returned.Text = returned3.ToString();
				
			beverages_sold.Text = sold4.ToString();
			beverages_returned.Text = returned4.ToString();
			beverages_disposed.Text = disposed4.ToString();
			beverages_costumer.Text = customers4.ToString();
			beverages_allproducts.Text = productt4.ToString();
			beverage_purchased.Text = purchased4.ToString();
			
	
			
		}
		void groupItems()
		{
			var view = (CollectionView)CollectionViewSource.GetDefaultView(Inventoy_Product.ItemsSource);
			view.GroupDescriptions.Clear();
			var groupDescription = new PropertyGroupDescription(GroupBinding);
			view.GroupDescriptions.Add(groupDescription);
		}
		void SortItems(List<string> sortItems, ListSortDirection sortDirection)
		{
			var view = (CollectionView)CollectionViewSource.GetDefaultView(Inventoy_Product.ItemsSource);
			foreach(var item in sortItems){
				var sortDescription = new SortDescription(item,sortDirection);
				view.SortDescriptions.Add(sortDescription);
			}
		}
		void DataGridItem_click(object sender,System.Windows.Input.MouseEventArgs e)
		{
			
			 var view_data = Supplier_Products.SelectedItem as product;
			 var view = new inventoryinfo();
			int.TryParse(totalinventoryy.Text,out totalinventory);
			int.TryParse(totalcostumer.Text,out totalcustomers);
			double.TryParse(totalprofit.Text,out totalProfits);
			int.TryParse(totalsold.Text,out totalsoldProducts);
			int.TryParse(totalunsold.Text,out totalunsoldProducts);
			double.TryParse(medicine_profit.Text,out categoryprofit);
			double.TryParse(mobile_profit.Text,out categoryprofit1);
			double.TryParse(beverages_profit.Text,out categoryprofit2);
			double.TryParse(shoes_profit.Text,out categoryprofit3);
			double.TryParse(cosmetics_profit.Text,out categoryprofit4);
		
			
			if(view_data!=null)
			{
			
			 view.sell.IsEnabled = false;
			 view.purchase.IsEnabled =true;
			 view.returns.IsEnabled = false;
			 view.dispose.IsEnabled = false;
			 view.updates.IsEnabled = false;
			
			 
			if(view_data.Selected == 0){
			 	view.cc.IsEnabled = false;
				view.a.IsEnabled = false;
				view.b.IsEnabled = false;
				view.c.IsEnabled = false;
				view.d.IsEnabled = false;
				view.ee.IsEnabled = false;
				view.f.IsEnabled = false;
				view.g.IsEnabled = false;
				view.h.IsEnabled = false;
				view.j.IsEnabled = false;
				view.k.IsEnabled = false;
				view.l.IsEnabled =false;
				
			 	 view.set(view_data);			 			
				 view.ShowDialog();
				 
			 	if(view.closes == 0){
				 	
					product_purchase.Add(view_data);
					Purchase_Product.ItemsSource = null;
					Purchase_Product.ItemsSource= product_purchase;
					view_data.Selected = 1;
					
				}
			 	
			}
			else{
				MessageBox.Show("Invalid Duplicate!");
				return;
			}
			
			var info = new info(view_data);
		
			if(view.p == 1)
			{
				info.ShowDialog();
			}
			view_data.totalpurchased = info.quantity;
			newprice += info.totalprice;
			
			foreach(product gg in product_purchase)
			{
				
				if(gg.Category == "Medicine")
				{
					newprice1 += gg.Totalprice;
					
				}
				if(gg.Category == "Mobile")
				{
					newprice2 += gg.Totalprice;
				}
				if(gg.Category == "Shoes")
				{
					newprice3 += gg.Totalprice;
				}
				if(gg.Category == "Cosmetics")
				{
					newprice4 += gg.Totalprice;
				}
				if(gg.Category == "Beverages")
				{
					newprice5 += gg.Totalprice;
				}
			
			}

			tquantity = info.quantity;
			dateoforder = info.dateoforder_textbox.Text;
			}
			else
			{
			return;
			}
			}
		void confirm_Click(object sender, RoutedEventArgs e)
		{	
	
			var scan_data = Supplier_Products.SelectedItem as product;
		if(scan_data != null)
		{

		if(MessageBox.Show("Do you want to confirm purchase?","",MessageBoxButton.OKCancel,MessageBoxImage.Information)== MessageBoxResult.OK)
		{
		int g = 0;
		
		
		foreach(product productss in inventory_list)
		{
			if(productss.Name==scan_data.Name)
			{
				g++;
				
				productss.TotalQuantity+=tquantity;
				productss.Quantity+=tquantity;
				totalinventory+=tquantity;
			
				productss.DateofOrder = dateoforder;
				productss.Status = "NEW";

			}
			
			}
			foreach(product gg in product_purchase)
			{
				if(gg.Category == "Medicine")
				{
					purchased+=tquantity;
					productt+=tquantity;
					
				}
				if(gg.Category == "Mobile")
				{
					purchased1+=tquantity;
					productt1+=tquantity;
				}
				if(gg.Category == "Shoes")
				{
					purchased2+=tquantity;
					productt2+=tquantity;
				}
				if(gg.Category == "Cosmetics")
				{
					purchased3+=tquantity;
					productt3+=tquantity;
				}
				if(gg.Category == "Beverages")
				{
					purchased4+=tquantity;
					productt4+=tquantity;
				}
				
			}
		
		
		if(g==0){

				inventory_list.Add(scan_data);
				scan_data.Status = "NEW";
				 scan_data.TotalQuantity += tquantity;
				scan_data.Quantity +=tquantity;
				Inventoy_Product.ItemsSource = null;
				Inventoy_Product.ItemsSource = inventory_list;
				
				totalinventory += tquantity;
				scan_data.DateofOrder = dateoforder;
				
				
				
		}

		
			Inventoy_Product.ItemsSource = null;
			Inventoy_Product.ItemsSource = inventory_list;
			Purchase_Product.ItemsSource = null;
			Sell_Inventory.ItemsSource = null;
			Sell_Inventory.ItemsSource = inventory_list;
			Return_Inventory.ItemsSource = null;
			Return_Inventory.ItemsSource = inventory_list;
			
		
			totalprce += newprice;
			totalProfits = totalprce-totalretail;
			if(totalretail==0){
				totalProfits = 0;
			}
			scan_data.Selected = 0;
			refresh();
			MessageBox.Show("Product Successfully added to the Inventory!");
		}
		else{
		return;
		}
		}
		else{
			return;
		}
		
		}
			
		void remove_Click(object sender, RoutedEventArgs e)
		{
			var removes = Purchase_Product.SelectedItem as product;
			if(removes !=null)
			{
				product_purchase.Remove(removes);
				Purchase_Product.ItemsSource = null;
				Purchase_Product.ItemsSource = product_purchase;
				MessageBox.Show("Remove successfully!");
				removes.Selected = 0;
			}
			else
			{
				MessageBox.Show("Please Select Product First!","",MessageBoxButton.OK,MessageBoxImage.Error);
			}

			
		}
		//PERFORM
		void clear_Click(object sender, RoutedEventArgs e)
		{
			
			var removes = Purchase_Product.SelectedItem as product;
		
			
				if(MessageBox.Show("Do you want to clear all?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					foreach(product pr in product_list)
					{
						product_purchase.Remove(pr);
						pr.Selected = 0;
					}
					Purchase_Product.ItemsSource = null;
					Purchase_Product.ItemsSource = product_purchase;
					MessageBox.Show("Cleared successfully!");
				}
				else{
					return;
				}


		}
		//viewinventoryclick
		void listbox_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var view = new inventoryinfo();
			 var view_data = Inventoy_Product.SelectedItem as product;
			 view.sell.IsEnabled = false;
			 view.purchase.IsEnabled = false;
			 view.returns.IsEnabled = false;
			 view.dispose.IsEnabled = false;
			 view.updates.IsEnabled = false;
			 		
			view.cc.IsEnabled = false;
			view.a.IsEnabled = false;
			view.b.IsEnabled = false;
			view.c.IsEnabled = false;
			view.d.IsEnabled = false;
			view.ee.IsEnabled = false;
			view.f.IsEnabled = false;
			view.g.IsEnabled = false;
			view.h.IsEnabled = false;
			view.j.IsEnabled = false;
			view.k.IsEnabled = false;
			view.l.IsEnabled =false;
		
			view.set(view_data);
			view.ShowDialog();
		}
		//sellclick
		void listbox_Click1(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var data = new product();
			var view = new inventoryinfo();
			 var view_data = Sell_Inventory.SelectedItem as product;
			 data = Sell_Inventory.SelectedItem as product;
			 view.sell.IsEnabled = true;
				 view.purchase.IsEnabled =false;
				 view.returns.IsEnabled = false;
				 view.dispose.IsEnabled = false;
				 view.updates.IsEnabled = false;
	
			if(data!=null)
			{
						
				if(data.Selected == 0){
					
					view.cc.IsEnabled = false;
					view.a.IsEnabled = false;
					view.b.IsEnabled = false;
					view.c.IsEnabled = false;
					view.d.IsEnabled = false;
					view.ee.IsEnabled = false;
					view.f.IsEnabled = false;
					view.g.IsEnabled = false;
					view.h.IsEnabled = false;
					view.j.IsEnabled = false;
					view.k.IsEnabled = false;
					view.l.IsEnabled =false;
					
					var selll = new sellproduct(data);
					
					
					view.set(view_data);
					view.ShowDialog();
					if(view.closes == 0){
						
						product_purchase.Add(data);
						Sell_Product.ItemsSource = null;
						Sell_Product.ItemsSource = product_purchase;
						
						data.Selected = 1;

					}
				}
				else{
					MessageBox.Show("Invalid Duplicate!");
					return;
				}
				
				var sellview = new sellproduct(data);
			
				if(view.s==1)
				{
					sellview.ShowDialog();
					
				}
				if(sellview.closess == 1)
					{
						product_purchase.Remove(data);
						Sell_Product.ItemsSource = null;
						Sell_Product.ItemsSource = product_purchase;
						
						data.Selected=0;
					}
				
				data.totalsell = sellview.quantity;
				
				newretail = sellview.totalretail;
				solds++;
			
				
			}
			
		
		}
		//returnclick
		void listbox_Click2(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var data = new product();
			var view = new inventoryinfo();
			 var view_data = Return_Inventory.SelectedItem as product;
			 data = Return_Inventory.SelectedItem as product;
			view.sell.IsEnabled = false;
			view.purchase.IsEnabled =false;
			view.returns.IsEnabled = true;
			view.dispose.IsEnabled = false;
			view.updates.IsEnabled = false;

			if(data!=null)
			{
						
				if(data.Selected == 0){
					view.cc.IsEnabled = false;
					view.a.IsEnabled = false;
					view.b.IsEnabled = false;
					view.c.IsEnabled = false;
					view.d.IsEnabled = false;
					view.ee.IsEnabled = false;
					view.f.IsEnabled = false;
					view.g.IsEnabled = false;
					view.h.IsEnabled = false;
					view.j.IsEnabled = false;
					view.k.IsEnabled = false;
					view.l.IsEnabled =false;
					
					view.set(view_data);
					view.ShowDialog();
					if(view.closes == 0){
						if(data.Status == "Expired")
						{
							product_purchase.Add(data);
							Return_Product.ItemsSource = null;
							Return_Product.ItemsSource = product_purchase;
							unsolds++;
							data.Selected = 1;
							MessageBox.Show("Product Added to the selected Product TAB Successfully!");
						}
						else{
							MessageBox.Show("You cannot returned this product!\n Expired Product Only!","",MessageBoxButton.OK,MessageBoxImage.Error);
							return;
						}
					}
				}
				else{
					MessageBox.Show("Invalid Duplicate!");
					return;
				}
			}
			
			
			
		}
		//disposeclick
		void listbox_Click3(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			var data = new product();
			var view = new inventoryinfo();
			var view_data = dispose_Inventory.SelectedItem as product;
			data = dispose_Inventory.SelectedItem as product;
			view.sell.IsEnabled = false;
			view.purchase.IsEnabled =false;
			view.returns.IsEnabled = false;
			view.dispose.IsEnabled = true;
			view.updates.IsEnabled = false;
			if(data!=null)
			{
						
				if(data.Selected == 0){
					view.cc.IsEnabled = false;
					view.a.IsEnabled = false;
					view.b.IsEnabled = false;
					view.c.IsEnabled = false;
					view.d.IsEnabled = false;
					view.ee.IsEnabled = false;
					view.f.IsEnabled = false;
					view.g.IsEnabled = false;
					view.h.IsEnabled = false;
					view.j.IsEnabled = false;
					view.k.IsEnabled = false;
					view.l.IsEnabled =false;
					
					view.set(view_data);
					view.ShowDialog();
					if(view.closes == 0){
						product_purchase.Add(data);
						dispose_Product.ItemsSource = null;
						dispose_Product.ItemsSource = product_purchase;
						data.Selected = 1;
						unsolds++;
							MessageBox.Show("Product Added to the selected Product TAB Successfully!");
					
						
					}
				}
				else{
					MessageBox.Show("Invalid Duplicate!");
					return;
				}
			}
			
			
			
			
		}	
		
		
		//updateclick
		void listbox_Click4(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			
				var view = new inventoryinfo();
				 var view_data = update_Product.SelectedItem as product;
				 view.sell.IsEnabled = false;
				 view.purchase.IsEnabled =false;
				 view.returns.IsEnabled = false;
				 view.dispose.IsEnabled = false;
				 view.updates.IsEnabled = true;
				view.cc.IsEnabled = true;
				view.a.IsEnabled = true;
				view.b.IsEnabled = true;
				view.c.IsEnabled = true;
				view.d.IsEnabled = true;
				view.ee.IsEnabled = true;
				view.f.IsEnabled = true;
				view.g.IsEnabled = true;
				view.h.IsEnabled = true;
				view.j.IsEnabled = true;
				view.k.IsEnabled = true;
				view.l.IsEnabled =false;
				
				 view.set(view_data);
				view.ShowDialog();	
			
		}
		void confirmsell_Click(object sender, RoutedEventArgs e)
		{
		
			var data = Sell_Inventory.SelectedItem as product;
			
			if(MessageBox.Show("Do you want to confirm Sell?","",MessageBoxButton.OKCancel,MessageBoxImage.Information)== MessageBoxResult.OK)
			{
				
				totalinventory -= data.totalsell;
				totalcustomers++;
				data.Quantity -= data.totalsell;
				data.TotalQuantity -=data.totalsell;
				data.Status = "Sold";
				
				Inventoy_Product.ItemsSource = null;
				Inventoy_Product.ItemsSource = inventory_list;
				Sell_Inventory.ItemsSource = null;
				Sell_Inventory.ItemsSource = inventory_list;
				Return_Inventory.ItemsSource = null;
				Return_Inventory.ItemsSource = inventory_list;
				dispose_Inventory.ItemsSource = null;
				dispose_Inventory.ItemsSource = inventory_list;
				
				var datass = new sellproduct(data);
				Sell_Product.ItemsSource = null;
				totalsoldProducts = solds-removve;
				totalretail += newretail;
				totalProfits =  totalprce - totalretail;

				foreach(product gg in product_purchase)
				{
					
					if(gg.Category == "Medicine")
					{
						newretail1 += gg.Totalprice;
						
					}
					if(gg.Category == "Mobile")
					{
						newretail2 += gg.Totalprice;
					}
					if(gg.Category == "Shoes")
					{
						newprice3 += gg.Totalprice;
					}
					if(gg.Category == "Cosmetics")
					{
						newretail4 += gg.Totalprice;
					}
					if(gg.Category == "Beverages")
					{
						newretail5 += gg.Totalprice;
					}
				
				}
				
				if(totalprce==0 || totalprce<totalretail)
				{
					totalProfits = 0;
				}
				foreach(product gg in product_purchase)
				{
					if(gg.Category == "Medicine")
					{
						categoryprofit = newprice1-newretail;
						if(totalprce==0 || totalprce<totalretail)
						{
							totalProfits = 0;
						}
						customers++;
						sold++;
						
					}
					if(gg.Category == "Mobile")
					{
						categoryprofit1 = totalprce - totalretail;
						if(totalprce==0 || totalprce<totalretail)
						{
							totalProfits = 0;
						}
						customers1++;
						sold1++;
					}
					if(gg.Category == "Shoes")
					{
						categoryprofit2 = totalprce - totalretail;
						if(totalprce==0 || totalprce<totalretail)
						{
							totalProfits = 0;
						}
						customers2++;
						sold2++;
					}
					if(gg.Category == "Cosmetics")
					{
						categoryprofit3 = totalprce - totalretail;
						if(totalprce==0 || totalprce<totalretail)
						{
							totalProfits = 0;
						}
						customers3++;
						sold3++;
					}
					if(gg.Category == "Beverages")
					{
						categoryprofit4 = totalprce - totalretail;
						if(totalprce==0 || totalprce<totalretail)
						{
							totalProfits = 0;
						}
						customers4++;
						sold4++;
					}
					
				}
				data.Selected = 0;
				Sell_Product.ItemsSource = null;
				refresh();
				
			}
			else{
				return;
			}
		}
		void removesel_Click(object sender, RoutedEventArgs e)
		{
			
			var removes = Sell_Product.SelectedItem as product;
			if(removes !=null)
			{
				if(MessageBox.Show("Do you want to Remove?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					product_purchase.Remove(removes);
					Purchase_Product.ItemsSource = null;
					Purchase_Product.ItemsSource = product_purchase;
					MessageBox.Show("Remove successfully!");
					removve++;
					removes.Selected = 0;
					
				}
				else{
					return;
				}
				
			}
			else
			{
				MessageBox.Show("Please Select Product First!","",MessageBoxButton.OK,MessageBoxImage.Error);
			}
			
		}
		void clearsel_Click(object sender, RoutedEventArgs e)
		{
			
			var removes = Sell_Product.SelectedItem as product;
			
				if(MessageBox.Show("Do you want to clear all?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					
					foreach(product pr in inventory_list)
					{
						product_purchase.Remove(pr);
						pr.Selected = 0;
					}
					Sell_Product.ItemsSource = null;
					Sell_Product.ItemsSource = product_purchase;
					MessageBox.Show("Cleared successfully!");
					
					removve++;
					
				}
				else{
					return;
				}
			

		}
		void confirmreturn_Click(Object sender, RoutedEventArgs e)
		{
			var data = Return_Inventory.SelectedItem as product;
		
				if(MessageBox.Show("Do you want to return?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					product_purchase.Clear();
					
					data.Status = "Returned";
					data.Quantity = 5;
					MessageBox.Show("Product Successfully Returned!");
					totalunsoldProducts += unsolds-removve;
					totalinventory--;
					data.Selected = 0;
				foreach(product gg in product_purchase)
				{
					
					if(gg.Category == "Medicine")
					{
						returned++;
						
					}
					if(gg.Category == "Mobile")
					{
						returned1++;
					}
					if(gg.Category == "Shoes")
					{
						returned2++;
					}
					if(gg.Category == "Cosmetics")
					{
						returned3++;
					}
					if(gg.Category == "Beverages")
					{
						returned4++;
					}
				
					}
					Purchase_Product.ItemsSource = null;
						refresh();
				}
				else
				{
					return;
				}
			
		}
		void removereturn_Click(Object sender, RoutedEventArgs e)
		{
			var removes =Return_Inventory.SelectedItem as product;
			if(removes !=null)
			{
				if(MessageBox.Show("Do you want to Remove?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					product_purchase.Remove(removes);
					Return_Product.ItemsSource = null;
					Return_Product.ItemsSource = product_purchase;
					MessageBox.Show("Remove successfully!");
					removve++;
					removes.Selected = 0;
				}
				else{
					return;
				}
				
			}
			else
			{
				MessageBox.Show("Please Select Product First!","",MessageBoxButton.OK,MessageBoxImage.Error);
			}
		}
		void clearreturn_Click(Object sender, RoutedEventArgs e)
		{
			var removes = Return_Inventory.SelectedItem as product;
				
				if(MessageBox.Show("Do you want to clear all?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
				{
					MessageBox.Show("Remove successfully!");
					removve++;
					product_purchase.Clear();
					Return_Product.ItemsSource = null;
				}
				else{
					return;
				}
		}
		void confirmdispose_Click(Object sender, RoutedEventArgs e)
		{
			
			var data = dispose_Inventory.SelectedItem as product;
			if(MessageBox.Show("Are you sure you want to Delete this product from Inventory?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
			{
				foreach(product pr in product_purchase)
				{
					inventory_list.Remove(pr);
				}
				
				Inventoy_Product.ItemsSource = null;
				Inventoy_Product.ItemsSource = inventory_list;
				
				dispose_Product.ItemsSource = null;
				MessageBox.Show("Remove Successfully!");
				data.Selected =0;
				totalinventory -= unsolds-removve;
				totalunsoldProducts += unsolds-removve;
			foreach(product gg in product_purchase)
			{
				
				if(gg.Category == "Medicine")
				{
					disposedd++;
					
				}
				if(gg.Category == "Mobile")
				{
					disposed1++;
				}
				if(gg.Category == "Shoes")
				{
					disposed2++;
				}
				if(gg.Category == "Cosmetics")
				{
					disposed3++;
				}
				if(gg.Category == "Beverages")
				{
					disposed4++;
				}
			
			}
				refresh();
			}
			else
			{
				return;
			}
		}
		void removedispose_Click(Object sender, RoutedEventArgs e)
		{
			var removes = dispose_Inventory.SelectedItem as product;
			if(MessageBox.Show("Do you want to Remove?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
			{
				product_purchase.Remove(removes);
				dispose_Product.ItemsSource = null;
				dispose_Product.ItemsSource = product_purchase;
				
				MessageBox.Show("Remove successfully!");
				removve++;
				removes.Selected = 0;
			}
			else{
				return;
			}
		}
		void cleardispose_Click(Object sender, RoutedEventArgs e)
		{
			var data = dispose_Inventory.SelectedItem as product;
			if(MessageBox.Show("Do you want to Clear All?","",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
			{
					MessageBox.Show("Remove successfully!");
				
					removve++;
					dispose_Product.ItemsSource = null;
					product_purchase.Clear();
					dispose_Product.ItemsSource = null;
					
			}
			else{
				return;
			}
			data.Selected = 0;
		}
		public void purchase_Click(object sender, RoutedEventArgs e)
		{
			
			product_purchase.Clear();
			return_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Visible;
			view_inventory.Visibility = Visibility.Hidden;
			update_inventory.Visibility = Visibility.Hidden;
			sell_inventory_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Hidden;
		}
		public void sell_Click(object sender, RoutedEventArgs e)
		{
			product_purchase.Clear();
			return_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Hidden;
			update_inventory.Visibility = Visibility.Hidden;
			sell_inventory_tab.Visibility = Visibility.Visible;
			dispose_tab.Visibility = Visibility.Hidden;
		}
		public void return_Click(object sender, RoutedEventArgs e)
		{
			product_purchase.Clear();
			return_tab.Visibility = Visibility.Visible;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Hidden;
			update_inventory.Visibility = Visibility.Hidden;
			sell_inventory_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Hidden;
		}
		public void dispose_Click(object sender, RoutedEventArgs e)
		{
			
			product_purchase.Clear();
			return_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Hidden;
			update_inventory.Visibility = Visibility.Hidden;
			sell_inventory_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Visible;
		}
		public void dash_Click(object sender, RoutedEventArgs e)
		{
			
			product_purchase.Clear();
			sell_inventory_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Visible;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Hidden;
			update_inventory.Visibility = Visibility.Hidden;
			return_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Hidden;
		
		}
		public void update_Click(object sender, RoutedEventArgs e)
		{
	
			product_purchase.Clear();
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Hidden;
			update_inventory.Visibility = Visibility.Visible;
			return_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Hidden;
		}
		public void view_product_click(object sender, RoutedEventArgs e)
		{
			exit_button.Visibility =Visibility.Hidden;
			GroupBinding = "None";
			groupItems();
			
			var sortitem = new List<string>();
			sortitem.Add("Name");
			
			SortItems(sortitem, ListSortDirection.Ascending);		
			product_purchase.Clear();
			sell_inventory_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Visible;
			update_inventory.Visibility = Visibility.Hidden;
			return_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Hidden;
		}
		public void view_category_click(object sender, RoutedEventArgs e)
		{
			exit_button.Visibility =Visibility.Hidden;
			GroupBinding = "Category";
			groupItems();
			
			product_purchase.Clear();
			sell_inventory_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Visible;
			update_inventory.Visibility = Visibility.Hidden;
			return_tab.Visibility = Visibility.Hidden;
			dispose_tab.Visibility = Visibility.Hidden;
		}
		public void view_status_click(object sender, RoutedEventArgs e)
		{
			exit_button.Visibility =Visibility.Hidden;
			
			GroupBinding = "Status";
			groupItems();
			
			product_purchase.Clear();
			dispose_tab.Visibility = Visibility.Hidden;
			sell_inventory_tab.Visibility = Visibility.Hidden;
			Dashboard_inventory.Visibility = Visibility.Hidden;
			perform_inventory.Visibility = Visibility.Hidden;
			view_inventory.Visibility = Visibility.Visible;
			update_inventory.Visibility = Visibility.Hidden;
			return_tab.Visibility = Visibility.Hidden;
		}
		public void Search_Click(object sender, EventArgs e)
	    {
			searchh.IsHitTestVisible = false;
			searchh.Visibility = Visibility.Hidden;
			exit_button.Visibility = Visibility.Visible;
			bool search = true;
			
			
			if(search)
			{
				
				
				int number;
				List<product>s_item;
				s_item = new List<product>(){};
				if(int.TryParse(search_box.Text,out number))
				{
					foreach(product item in inventory_list)
					{
						if(int.Parse(search_box.Text)== item.IdNo)
						{
							s_item.Add(item);
						}
					}
					
				}else	
					foreach(product item in inventory_list)
					{
						if(search_box.Text == item.Name){
							s_item.Add(item);
						}
					
					
					}
				if(s_item.Count == 0)
				{
					
					MessageBox.Show("No item matched!","",MessageBoxButton.OK,MessageBoxImage.Error);
					search_box.Text = null;
					return;
				}
				else{
					Inventoy_Product.ItemsSource = null;
					Inventoy_Product.ItemsSource = s_item;
					search = false;
				}
				
			}
			searchh.Visibility = Visibility.Hidden;
	    }
		public void exit_Click(object sender, RoutedEventArgs e)
		{
			search_box.Text = null;
			searchh.IsHitTestVisible = true;
			searchh.Visibility = Visibility.Visible;
		
			exit_button.Visibility = Visibility.Hidden;
			Inventoy_Product.ItemsSource = inventory_list;
		}


	}
}