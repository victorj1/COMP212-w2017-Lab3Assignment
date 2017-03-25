using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victor_Jdanovitch_Lab03_Ex3
{
    public partial class Form1 : Form
    {
        int[] intArray = new int[15];
        double[] doubleArray = new double[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Clear();
            for (int i = 0; i < 15; i++)
            {
                intArray[i] = rand.Next(0, 1000);
                textBox1.Text += intArray[i].ToString() + "\r\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox2.Clear();
            for (int i = 0; i < 15; i++)
            {
                doubleArray[i] = Math.Truncate((rand.NextDouble() * 1000) * 100) / 100;
                textBox2.Text += doubleArray[i].ToString() + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = String.Format("The search key is placed at position " + Search(intArray, Convert.ToInt32(textBox3.Text)) + " in the array");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = String.Format("The search key is placed at position " + Search(doubleArray, Convert.ToDouble(textBox4.Text)) + " in the array");
        }
        private static int Search<T>(T[] inputArray, int searchKey) where T : IComparable
        {
            //try
            //{
            int returnValue = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if ((inputArray[i].CompareTo(searchKey) == 0))
                {
                    returnValue = i + 1;
                }
            }
            return returnValue;
            //}
            //  catch (Exception e)
            //  {

            //      MessageBox.Show(e.Message);
            //  }
        }

        private static int Search<T>(T[] inputArray, double searchKey) where T : IComparable
        {
            // try
            {
                int returnValue = -1;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if ((inputArray[i].CompareTo(searchKey) == 0))
                    {
                        returnValue = i + 1;
                    }
                }
                return returnValue;
            }
            // catch (Exception e)
            // {

            //     MessageBox.Show(e.Message);
            // }
        }

    }
}
