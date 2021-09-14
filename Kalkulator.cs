using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    
    public partial class Kalkulator : Form
    {
        double nilai = 0;
        string ops = "";
        bool op_pressed = false;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }

        private void angka1_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")  { 
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void angka2_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void angka3_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void angka4_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0") 
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void angka6_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (numBox.Text == "0")
            {
                numBox.Clear();
            }
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            numBox.Text = numBox.Text + b.Text;
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            numBox.Clear();
            op_pressed = false;
        }

        private void kali_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            nilai = Double.Parse(numBox.Text);
            numBox.Clear();
            op_pressed = true;
        }

        private void hasil_Click(object sender, EventArgs e)
        {
            switch (ops){
                case "*" : numBox.Text = (nilai * Double.Parse(numBox.Text)).ToString();
                    break;
                case "/" : numBox.Text = (nilai / Double.Parse(numBox.Text)).ToString();
                    break;
                case "-" : numBox.Text = (nilai - Double.Parse(numBox.Text)).ToString();
                    break;
                case "+" : numBox.Text = (nilai + Double.Parse(numBox.Text)).ToString();
                    break;
            }
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            nilai = Double.Parse(numBox.Text);
            numBox.Clear();

            op_pressed = true;
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            nilai = Double.Parse(numBox.Text);
            numBox.Clear();

            op_pressed = true;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            nilai = Double.Parse(numBox.Text);
            numBox.Clear();
            op_pressed = true;
        }

        private void persen_Click(object sender, EventArgs e)
        {
            numBox.Text = (Double.Parse(numBox.Text) * 0.01).ToString();
        }

        private void akar_Click(object sender, EventArgs e)
        {
            numBox.Text = (Math.Sqrt(Double.Parse(numBox.Text))).ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            numBox.Text = numBox.Text.Remove(numBox.Text.Length - 1,1);
        }
    }

}
