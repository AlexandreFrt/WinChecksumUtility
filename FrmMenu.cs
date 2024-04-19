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
                string sha256 = ComputeSha256(files);
                textBoxFileHash.Text = sha256;
                textBoxFilePath.Text = files[0];
            }
            else
            {
                // Si plusieurs fichiers ont été drop alors on affiche une erreur
                MessageBox.Show("Veuillez selectionner un seul fichier à la fois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComputeSha256(string[] files)
        {
            string sha256Hash = "";

            // Initialise l'object SHA256
            using (SHA256 sha256 = SHA256.Create())
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

                            byte[] hashValue = sha256.ComputeHash(fileStream);

                            sha256Hash = NormalizeSha256Hash(hashValue);
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
                else
                {
                    MessageBox.Show("Le fichier : " + files[0] + " n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return sha256Hash;
        }

        // Procédure qui renormalise le hash, supprime les -, et le convertit en minuscule
        private string NormalizeSha256Hash(byte[] bytes)
        {
            string sha256 = BitConverter.ToString(bytes);
            sha256 = sha256.ToLower();
            sha256 = sha256.Replace("-", "");

            return sha256;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = openFileDialog.FileNames;
            string sha256 = ComputeSha256(files);
            textBoxFileHash.Text = sha256;
            textBoxFilePath.Text = files[0];
        }

        private void buttonCheckChecksum_Click(object sender, EventArgs e)
        {
            if (!textBoxFileHash.Text.Equals(textBoxOriginalChecksumValue.Text))
            {
                MessageBox.Show("Le checksum du fichier est : " + textBoxFileHash.Text + "\nLe checksum original du fichier est : " + textBoxOriginalChecksumValue.Text + "\n\nLES CHECKSUM NE SE CORRESPONDENT PAS !!!", "Vérification du checksum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Le checksum du fichier est : " + textBoxFileHash.Text + "\nLe checksum original du fichier est : " + textBoxOriginalChecksumValue.Text + "\n\nLes checksum se correspondent.", "Vérification du checksum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonComputeChecksum_Click(object sender, EventArgs e)
        {
            string[] files = new string[1];
            files[0] = textBoxFilePath.Text;
            files[0] = RemoveInvisibleCharacters(files[0]);
            string sha256Hash = ComputeSha256(files);
            textBoxFileHash.Text = sha256Hash;
        }

        // Fonction qui utilise une expression régulière pour remplacer les caractères invisibles et retourne la valeur une fois modifié
        public static string RemoveInvisibleCharacters(string input)
        {
            return Regex.Replace(input, @"\p{C}", "");
        }
    }
}
