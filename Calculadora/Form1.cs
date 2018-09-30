using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calc;

namespace Calculadora
{
    
    public partial class frm_calculadora : Form
    {
        calc.Calculadora c = new calc.Calculadora();

        public frm_calculadora()
        {            
            InitializeComponent();       
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            float n = 1;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n; 
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            float n = 2;
            insertar_num(n);
            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            float n = 3;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            float n = 4;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            float n = 5;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            float n = 6;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            float n = 7;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            float n = 8;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            float n = 9;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            float n = 0;
            insertar_num(n);

            txt_operacion.Text = txt_operacion.Text + n;
        }

        private void insertar_num(float n) {
            c.insert_num(n);
            Console.WriteLine(c.oper_actual());
        }




        private void operar(object sender, EventArgs e)
        {
            
            if (rd_sumar.Checked == true) { c.insert_op('+'); }
            if (rd_restar.Checked == true) { c.insert_op('-'); }
            if (rd_multiplicar.Checked == true) { c.insert_op('*'); }
            if (rd_dividir.Checked == true) { c.insert_op('/'); }
        }
    }
}
