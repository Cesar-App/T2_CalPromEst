using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_CalPromEst
{
    public partial class Form1 : Form
    {
        double n1, n2, n3, n4, prom, notaComp, notaExtr;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(Nota1.Text);
            n2 = Convert.ToDouble(Nota2.Text);
            n3 = Convert.ToDouble(Nota3.Text);
            n4 = Convert.ToDouble(Nota4.Text);

            prom = (n1 + n2 + n3 + n4) / 4;

            if (prom >= 70)
            {
                groupBox2.Visible = false;
                label8.Visible = true;
                label9.Visible = true;
                label9.ForeColor = Color.Green;
                label9.Text = "- Aprobado -";
            }
            else
            {
                groupBox2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nota1.Clear();
            Nota2.Clear();
            Nota3.Clear();
            Nota4.Clear();
            textBox1.Clear();
            textBox2.Clear();

            groupBox2.Visible = false;

            label8.Visible = false;
            label9.Visible = false;

            textBox2.Enabled = false;
            BtnCalExtraordinario.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalComplectivo_Click(object sender, EventArgs e)
        {
            notaComp = (prom / 2) + (Convert.ToDouble(textBox1.Text) / 2);

            if (notaComp >= 70)
            {
                label9.Visible = true;
                label8.Visible = true;
                label9.ForeColor = Color.Green;
                label9.Text = "- Aprobado por Complectivo -";
            }
            else
            {
                label9.Visible = true;
                label8.Visible = true;
                label7.Enabled = true;
                label9.ForeColor = Color.Red;
                label9.Text = "- Reprobado por Complectivo-";

                textBox2.Enabled = true;
                BtnCalExtraordinario.Enabled = true;
            }
        }

        private void BtnCalExtraordinario_Click(object sender, EventArgs e)
        {
            notaExtr = (prom * 0.30) + (Convert.ToDouble(textBox2.Text) * 0.70);

            if (notaExtr >= 70)
            {
                label9.Visible = true;
                label8.Visible = true;
                label9.ForeColor = Color.Green;
                label9.Text = "- Aprobado por Extraordinario -";
            }
            else
            {
                label9.Visible = true;
                label8.Visible = true;
                label9.ForeColor = Color.Red;
                label9.Text = "- Reprobado -";
            }
        }
    }
}
