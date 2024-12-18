using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanleyCEbaySales
{
    public partial class Form1 : Form
    {
        private string Category;
        const string ELECTRONICS = "Electronics";
        const string CLOTHING = "Clothing";
        const string BOOKS = "Books";

        private Form2 settingForm;

        private string EbayTransactionLog = "EbayTransactionLog.txt";
        public string EbayConfig = "EbayConfig.txt";

        private double electronicsFee;
        private double clothingFee;
        private double booksFee;
        
        // ICA 8 Properties
        public double ElectronicsFee
        {
            get { return electronicsFee; }
            set { electronicsFee = value; }
        }
        public double ClothingFee
        {
            get { return clothingFee; }
            set { clothingFee = value; }
        }
        public double BooksFee
        {
            get { return booksFee; }
            set { booksFee = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtProfit.Clear();
            txtShippingCost.Clear();
            lstOut.Items.Clear();
            // focus changes the active control.
            // So the line below changes the active control to txtCustomer name
            txtCustomerName.Focus();
            rdoElectronics.Checked = true;
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            // Variables should be declared at the beginning of the procedure
            double ProductCost, ShippingCost, Profit, totalCustPrice;
            string EbayCustName;
            bool ProductValid, ShippingValid, ProfitValid;
            double StoreFee = 0;
            // declare the object sw which is an instance of the class StreamWrite
            StreamWriter sw;

            //input
            // Parse converts string to double
            // FlightPrice = double.Parse(txtTicketPrice.Text);
            // convert parse to tryparse
            ProductValid = double.TryParse(txtProductCost.Text, out ProductCost);
            ProfitValid = double.TryParse(txtProfit.Text, out Profit);
            ShippingValid = double.TryParse(txtShippingCost.Text, out ShippingCost);
            if (ProductValid && ProfitValid && ShippingValid)
            {
                switch (Category)
                {
                    case ELECTRONICS:
                        StoreFee = ElectronicsFee;
                        break;
                    case CLOTHING:
                        StoreFee = ClothingFee;
                        break;
                    case BOOKS:
                        StoreFee = BooksFee;
                        break;
                    default:
                        lstOut.Items.Add("This should never happen");
                        break;
                }
                // it is a good idea to save string input to a variable
                EbayCustName = txtCustomerName.Text;
                // Processing
                totalCustPrice = ProductCost + Profit + ShippingCost + StoreFee;
                //Output
                lstOut.Items.Add("Customer Name is " + EbayCustName);
                // updated output
                lstOut.Items.Add("Category is " + Category);
                lstOut.Items.Add("Store Fee is " + StoreFee.ToString("C"));
                // toString will convert numbers to string C indicates currency (Money) N - number
                // P - Percentage - Later we will take about D, T & G ( date and time stuff)
                // a number after P, C and N indicate number of decimeal places
                lstOut.Items.Add("Product Cost is " + ProductCost.ToString("C2"));
                lstOut.Items.Add("Profit is: " + Profit.ToString("C2"));
                lstOut.Items.Add("Shipping Cost is " + ShippingCost.ToString("C2"));
                lstOut.Items.Add("Total Customer Price is " + totalCustPrice.ToString("C2"));
                sw = File.AppendText(EbayTransactionLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + " **********");
                sw.WriteLine("Customer Name is " + EbayCustName);
                // updated output
                sw.WriteLine("Category is " + Category);
                sw.WriteLine("Store Fee is " + StoreFee.ToString("C"));
                sw.WriteLine("Product Cost is " + ProductCost.ToString("C2"));
                sw.WriteLine("Profit is " + Profit.ToString("C2"));
                sw.WriteLine("Shipping Cost is " + ShippingCost.ToString("C2"));
                sw.WriteLine("Total Customer Price is " + totalCustPrice.ToString("C2"));

                sw.Close();

                btnClear.Focus();
            }
            else
            {
                if (!ProductValid)
                {
                    lstOut.Items.Add("Please enter a numeric entry for product cost");
                }
                if (!ProfitValid)
                {
                    lstOut.Items.Add("Please enter a numeric entry for profit.");
                }
                if (!ShippingValid)
                {
                    lstOut.Items.Add("Please enter a numeric entry for shipping cost");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want to Quit?", "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                // this will close the form and end the program..
                // Note closing a form doesn't always end the program
                this.Close();
            }
        }

        private void rdoElectronics_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoElectronics.Checked)
            {
                Category = ELECTRONICS;
            }
        }

        private void rdoClothing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoClothing.Checked)
            {
                Category = CLOTHING;
            }
        }

        private void rdoBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBooks.Checked)
            {
                Category = BOOKS;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingForm = new Form2(this);
            rdoElectronics.Checked = true;
            StreamReader reader;
            bool valValid;
            bool fileBad = true;
            do
            {
                try
                {
                    reader = File.OpenText(EbayConfig);
                    fileBad = false;
                    double tempValue;
                    //skipping validity checks so as not to confuse the input
                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    // optional error checking could be done here

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    ElectronicsFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    ClothingFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    BooksFee = tempValue;
                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuation file was not found. Please select a different file \n Error message was: " +
                        ex.Message
                        );
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();
                    //this takes the file the user slected and puts in the variable for the file we need
                    EbayConfig = openFileDialog1.FileName;


                }
            } while (fileBad);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingForm.txtElectronicsFee.Text = ElectronicsFee.ToString();
            settingForm.txtClothingFee.Text = ClothingFee.ToString();
            settingForm.txtBooksFee.Text = BooksFee.ToString();

            settingForm.ShowDialog();
        }

        public void setValuesOnSecondForm()
        {
            settingForm.txtElectronicsFee.Text = ElectronicsFee.ToString();
            settingForm.txtClothingFee.Text = ClothingFee.ToString();
            settingForm.txtBooksFee.Text = BooksFee.ToString();
        }

        private void btnDisplayLog_Click(object sender, EventArgs e)
        {
            const int MAX_LOG_SIZE = 2000;
            string[] EbayLogLines = new string[MAX_LOG_SIZE];
            int numLogLines = 0;
            StreamReader sr;
            sr = File.OpenText(EbayTransactionLog);
            while (!sr.EndOfStream)
            {
                EbayLogLines[numLogLines] = sr.ReadLine();
                numLogLines++;
            }
            sr.Close();
            // keep track of begining & end of transaction relative to where
            // seat type is recorded (For most students this will be the variable
            // that references their radio button)
            int begTrans = -2;
            int endTrans = 6;

            for (int i = 0; i < numLogLines; i++)
            {
                if (EbayLogLines[i] == "Category is " + Category)
                {
                    // Some of you could use  AirlineLogLines[i].Contains(SeatType)

                    for (int j = i + begTrans; j <= i + endTrans; j++)
                    {
                        lstOut.Items.Add(EbayLogLines[j]);

                    }
                }
            }
        }
    }
}
