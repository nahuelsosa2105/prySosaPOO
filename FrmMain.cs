﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaPOO
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnNombre_Click(object sender, EventArgs e)
        {
            ClassPersonaje objeto = new ClassPersonaje();

            objeto.nombre = txtNombre.Text;
            objeto.fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.destreza = int.Parse(txtDestreza.Text);

            lblInfo.Text += objeto.nombre + "\n"+
                objeto.fuerza + "\n"+
                objeto.destreza;
        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }
    }
}
