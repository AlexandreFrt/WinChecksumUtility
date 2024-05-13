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
using System.Text.RegularExpressions;

namespace WinChecksum
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // Lorsqu'il y a une entrée de drag
        private void FrmMenu_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        // Lorsqu'il y a un fichier qui a été drop, on calcule et on affiche le checksum du fichier 
        private void FrmMenu_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // Si il n'y a qu'un seul fichier dans le drag
            if (files.Length == 1)
            {
                string hash = ComputeChecksum(files, comboBoxAlgorithm.SelectedItem.ToString());
                textBoxFileHash.Text = hash;
                textBoxFilePath.Text = files[0];
            }
            else
            {
                // Si plusieurs fichiers ont été drop alors on affiche une erreur
                MessageBox.Show("Veuillez selectionner un seul fichier à la fois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComputeChecksum(string[] files, string algorithm)
        {
            string hash = "";

            // Initialise l'object HashAlgorithm
            using (var hashAlgorithm = HashAlgorithm.Create(algorithm))
            {
                if (File.Exists(files[0]))
                {
                    FileInfo fileInfo = new FileInfo(files[0]);

                    using (FileStream fileStream = fileInfo.Open(FileMode.Open))
                    {
                        try
                        {
                            // Créer un fileStream pour le fichier
                            // Être sur qu'il soit positionné au début du stream
                            fileStream.Position = 0;

                            byte[] hashValue = hashAlgorithm.ComputeHash(fileStream);

                            hash = NormalizeHash(hashValue);

                            buttonCopy.Text = "Copier...";
                        }
                        catch (IOException error)
                        {
                            MessageBox.Show(error.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (UnauthorizedAccessException error)
                        {
                            MessageBox.Show(error.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (textBoxFilePath.Text.Length > 0)
                {
                    MessageBox.Show("Le fichier : " + files[0] + " n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return hash;
        }

        // Procédure qui renormalise le hash, supprime les -, et le convertit en minuscule
        private string NormalizeHash(byte[] bytes)
        {
            string hash = BitConverter.ToString(bytes);
            hash = hash.ToLower();
            hash = hash.Replace("-", "");

            return hash;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = openFileDialog.FileNames;
            string hash = ComputeChecksum(files, comboBoxAlgorithm.SelectedItem.ToString());
            textBoxFileHash.Text = hash;
            textBoxFilePath.Text = files[0];
        }

        private void buttonCheckChecksum_Click(object sender, EventArgs e)
        {
            if (!textBoxFileHash.Text.Equals(textBoxOriginalChecksumValue.Text))
            {
                MessageBox.Show("Le checksum du fichier est : " + textBoxFileHash.Text + "\nLe checksum original du fichier est : " + textBoxOriginalChecksumValue.Text + "\n\nLES CHECKSUMS NE SE CORRESPONDENT PAS !", "Vérification du checksum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Le checksum du fichier est : " + textBoxFileHash.Text + "\nLe checksum original du fichier est : " + textBoxOriginalChecksumValue.Text + "\n\nLes checksums se correspondent.", "Vérification du checksum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonComputeChecksum_Click(object sender, EventArgs e)
        {
            string[] files = new string[1];
            files[0] = textBoxFilePath.Text;
            files[0] = RemoveInvisibleCharacters(files[0]);
            string hash = ComputeChecksum(files, comboBoxAlgorithm.SelectedItem.ToString());
            textBoxFileHash.Text = hash;
        }

        // Fonction qui utilise une expression régulière pour remplacer les caractères invisibles et retourne la valeur une fois modifié
        public static string RemoveInvisibleCharacters(string input)
        {
            return Regex.Replace(input, @"\p{C}", "");
        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] files = new string[1];
            files[0] = textBoxFilePath.Text;
            files[0] = RemoveInvisibleCharacters(files[0]);
            string hash = ComputeChecksum(files, comboBoxAlgorithm.SelectedItem.ToString());
            textBoxFileHash.Text = hash;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!textBoxFileHash.Text.Equals(""))
            {
                Clipboard.SetText(textBoxFileHash.Text);
                buttonCopy.Text = "Copié...";
            }
        }
    }
}
