using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_an_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void orderToArray()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //1 <= nums.length <= 50000
            //-50000 <= nums[i] <= 50000

            //int[] intArrray = { 3, 1, 5, 4, 2, 3, 0, 0 };

            //int[] outputArray = intArrray.OrderBy(x => x).ToArray();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;

            int[] intArray = new int[listBox1.Items.Count];

            foreach (var item in listBox1.Items)
            {
                intArray.SetValue(int.Parse(item.ToString()), sayi);
                sayi++;
            }
            int[] outputArray = orderToArrayMethod(intArray);

            //int[] outputArray = intArray.OrderBy(x => x).ToArray();

            listBox2.Items.Clear();

            foreach (var item in outputArray)
            {
                listBox2.Items.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        public int[] orderToArrayMethod(int[] inputArray)
        {
            int[] outputArray = inputArray.OrderBy(x => x).ToArray();
            return outputArray;
        }
    }
}
