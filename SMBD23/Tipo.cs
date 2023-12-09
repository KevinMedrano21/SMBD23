using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMBD23
{
    public partial class Tipo : Form
    {
        public Tipo()
        {
            InitializeComponent();
        }

        public int valor;

        //public int val 
        //{
        //    get { return this.val; }
        //    set { this.val = valor; }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                valor = 0;
            else if (radioButton2.Checked == true)
                valor = 1;
            else if (radioButton3.Checked == true)
                valor = 2;
            else if(radioButton4.Checked == true)
                valor = 3;
            else  if (radioButton4.Checked == true)
                valor = 4;
            this.Close();

        }
    }
}
