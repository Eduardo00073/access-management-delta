using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD.Actors
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        #region WEBSITE
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://systemdelta.webnode.com/");
        }
        #endregion
    }
}
