﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprobadorDePassword
{
    public partial class Examen2EvAPG2324 : Form
    {
        public Examen2EvAPG2324()
        {
            InitializeComponent();
        }

        private void btnComprobar_click(object sender, EventArgs e)
        {
            ComprobadorDePasswordAPG2324 miComprobador = new ComprobadorDePasswordAPG2324();
            int resultado = miComprobador.Test(txtPassword.Text);
            if (resultado < 0)
                MessageBox.Show("La contraseña no puede estar vacía");
            if (resultado == 0)
                MessageBox.Show("Contraseña demasiado corta");
            if (resultado == 1)
                MessageBox.Show("Contraseña débil");
            if (resultado == 2)
                MessageBox.Show("Contraseña normal");
            if (resultado == 3)
                MessageBox.Show("Contraseña fuerte");
            if (resultado == 4)
                MessageBox.Show("Contraseña muy fuerte");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
