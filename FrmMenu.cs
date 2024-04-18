using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WinSHA256
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void FrmMenu_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // Si il n'y a qu'un seul fichier dans le drag
            if (files.Length == 1)
            {
                // Initialise l'object SHA256
                using (SHA256 SHA256 = SHA256.Create())
                {
                    using (FileStream fileStream;)
                    {

                    }
                }
            }
            else
            {

            }
        }
    }
}
