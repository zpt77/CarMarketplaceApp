using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarMarketplaceApp.API;

namespace CarMarketplaceApp
{
    public partial class Form1 : Form
    {

        CarMarketplaceAPIClient client = new CarMarketplaceAPIClient();

        public Form1()
        {
            
            InitializeComponent();
            LoadData(AllData());
        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<Car> cars = new List<Car>();

            ContentValidator();
            cars.AddRange(client.GetCars(
                MakeSearchText.Text,
                ModelSearchText.Text,
                Convert.ToInt32(MinEngSearchText.Text),
                Convert.ToInt32(MaxEngSearchText.Text),
                Convert.ToInt32(MinYearSearchText.Text),
                Convert.ToInt32(MaxYearSearchText.Text),
                Convert.ToInt32(MinPriceSearchText.Text),
                Convert.ToInt32(MaxPriceSearchText.Text))
                );
            
            LoadData(cars);
        
        }

        private void LoadData(List<Car> cars)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Marka");
            dt.Columns.Add("Model");
            dt.Columns.Add("Poj. silnika");
            dt.Columns.Add("Rok produkcji");
            dt.Columns.Add("Cena [zł]");

            foreach(Car c in cars)
            {
                dt.Rows.Add(c.Make, c.Model, c.EngineSize, c.ProductionYear, c.Price);
            }

            carsGrid.DataSource = dt;
        }

        private List<Car> AllData()
        {
            List<Car> cars = new List<Car>();
            cars.AddRange(client.GetAllCars());
            return cars;
        }
               
        private void ContentValidator()
        {
            List<TextBox> tb = new List<TextBox>()
            { MinEngSearchText,
                MaxEngSearchText,
                MinYearSearchText,
                MaxYearSearchText,
                MinPriceSearchText,
                MaxPriceSearchText 
            };
                
            foreach(TextBox t in tb)
            {
                if (string.IsNullOrEmpty(t.Text))
                {
                    t.Text = "0";
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {


            client.AddCars(
                MakeAddText.Text,
                ModelAddText.Text,
                EngAddText.Text,
                Convert.ToInt32(YearAddText.Text),
                Convert.ToInt32(PriceAddText.Text)
                );

            LoadData(AllData());
        }  
    }
}
