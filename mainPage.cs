using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
// using Microsoft.EntityFrameworkCore;

namespace PizzaApp_v1
{


    public class PizzaItem {

        public int PizzaItemId
        {
            get; set;
        }


        public String Name
        {
            get; set;
        }


        public String Url
        {
            get; set;
        }

        public PizzaItem()
        {
            this.Name = "";
            this.Url = "";
        }

        public PizzaItem(String name, String url) {
            this.Name = name;
            this.Url = url;
        }
};


    public class PizzaOrderItem
    {

        public PizzaItem PizzaItem
        {
            get; set;
        }

        public bool IsFavourite 
        {
            get; set;
        }

        public int PizzaItemId
        {
            get; set;
        }

        public String Ingredients
        {
            set; get;
        }


        public PizzaOrderItem()
        {
            this.Ingredients = "";
           
        }

       
    };


    /*
    public class OrderContext : DbContext
    {



        public DbSet<PizzaOrderItem> Orders { get; set; }
      

        public OrderContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "orders.db3");
            string connectionString = $"Filename={dbPath}";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
    */






    public partial class MainPage : ContentPage
    {

        public List<PizzaItem> Pizzas
        {

            set; get;
            
            
           // new PizzaItem("Formaggi", "https://www.talkwalker.com/images/2020/blog-headers/image-analysis.png")
             }

        public MainPage()
        {
            InitializeComponent();




             var images = new List<String>
              {
              "https://www.talkwalker.com/images/2020/blog-headers/image-analysis.png",
                "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg",
               "https://q-xx.bstatic.com/xdata/images/hotel/840x460/78809294.jpg?k=cf850d507a9671cf7ff85d598435ea329a28cd4f1b1abc25c1892c91156d36ad&o="
              };



            Pizzas = new List<PizzaItem>
             {
             new PizzaItem("Formaggi", "https://www.talkwalker.com/images/2020/blog-headers/image-analysis.png"),
              new PizzaItem("Salami", "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg"),
               new PizzaItem("Cheese", "https://q-xx.bstatic.com/xdata/images/hotel/840x460/78809294.jpg?k=cf850d507a9671cf7ff85d598435ea329a28cd4f1b1abc25c1892c91156d36ad&o=")
             };


            MainCarouselView.ItemsSource = Pizzas;


            void OnButtonClickeda(object sender, EventArgs args)
            {
                Console.WriteLine("Hello");
            };


           

             void collectionView_SelectionChanged(object sender, EventArgs e)
            {
                Console.WriteLine("WOW");

                // ingredientView
                Console.WriteLine(IngredientView.SelectedItems.Count);
               // Console.WriteLine(inSelectedItems.Length);

            }


        }


        private void collectionView_SelectionChanged(object sender, EventArgs e)
        {

            if (IngredientView.SelectedItems.ToList().Count > 0) {
                Console.WriteLine("WOW");
                Console.WriteLine(IngredientView.SelectedItems[0]);
            };




            Console.WriteLine("Ingredients: ");

            for (var i = 0; i < IngredientView.SelectedItems.ToList().Count; i++)
            {
              
                Console.WriteLine(IngredientView.SelectedItems[i]);
            };

            // Console.WriteLine(collectionView.selectedItems.Length);

        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Calls.");
            Console.WriteLine(((PizzaItem)MainCarouselView.CurrentItem).Name);

            var pizzaItem = Array.Find(Pizzas.ToArray(), element => element.Name == MainCarouselView.CurrentItem.ToString());

            if (pizzaItem != null) {
                Console.WriteLine("Selected: " + pizzaItem.Name); 
            }

         
               
        }
    }
}
