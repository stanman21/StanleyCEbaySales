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
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 form1)
        {
            ff = form1;
            InitializeComponent();
        }

        private void btnSetReturn_Click(object sender, EventArgs e)
        {
            bool ElectronicsValid, ClothingValid, BooksValid;
            double eTempValue, cTempValue, bTempValue;

            StreamWriter sw;

            ElectronicsValid = double.TryParse(txtElectronicsFee.Text, out eTempValue);
            ClothingValid = double.TryParse(txtClothingFee.Text, out cTempValue);
            BooksValid = double.TryParse(txtBooksFee.Text, out bTempValue);
           
            if (ElectronicsValid && ClothingValid && BooksValid)
            {
                ff.ElectronicsFee = eTempValue;
                ff.ClothingFee = cTempValue;
                ff.BooksFee = bTempValue;
                sw = File.CreateText(ff.EbayConfig);
                sw.WriteLine(ff.ElectronicsFee);
                sw.WriteLine(ff.ClothingFee);
                sw.WriteLine(ff.BooksFee);

                sw.Close();

                this.Hide();
            }
            else
            {
                ff.setValuesOnSecondForm();
            }
        }
    }
}
