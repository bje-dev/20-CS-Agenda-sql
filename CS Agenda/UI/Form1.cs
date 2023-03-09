using BLL;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        DOMContacto objcontacto = new DOMContacto();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objcontacto.nombre = textBox1.Text;
            objcontacto.apellido = textBox2.Text;
            objcontacto.email = textBox3.Text;
            objcontacto.edad = Convert.ToInt32(textBox4.Text);

            BLLContacto bllcontacto = new BLLContacto();
            bllcontacto.Create(objcontacto);


        }
    }
}
