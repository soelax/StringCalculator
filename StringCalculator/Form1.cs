using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var first = "99";
            var second = "123";

            var adder = new StringAdder();
            var multiplier = new StringMultiplier();
            var summe = adder.add(first, second);
            var produkt = multiplier.multiply(first, second);

            System.Diagnostics.Debugger.Log(0, "", $"Resultate: Addition: {summe}, Multiplikation: {produkt}");
        }
    }
}
