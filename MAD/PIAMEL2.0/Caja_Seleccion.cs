﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD._0
{
    public partial class Caja_Seleccion : Form
    {
        public Caja_Seleccion()
        {
            InitializeComponent();
        }

        private void btn_aceptar_SC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
