namespace WinChecksum
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOriginalChecksumValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileHash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonCheckChecksum = new System.Windows.Forms.Button();
            this.buttonComputeChecksum = new System.Windows.Forms.Button();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.AllowDrop = true;
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tableLayoutMain.Size = new System.Drawing.Size(767, 331);
            this.tableLayoutMain.TabIndex = 0;
            this.tableLayoutMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMenu_DragDrop);
            this.tableLayoutMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMenu_DragEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.58069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.41931F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxOriginalChecksumValue, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFileHash, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilePath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonImport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCheckChecksum, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonComputeChecksum, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAlgorithm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.61724F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.94616F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.613456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.617241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51072F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.617241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.56486F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 325);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxOriginalChecksumValue
            // 
            this.textBoxOriginalChecksumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginalChecksumValue.Location = new System.Drawing.Point(3, 257);
            this.textBoxOriginalChecksumValue.Name = "textBoxOriginalChecksumValue";
            this.textBoxOriginalChecksumValue.Size = new System.Drawing.Size(675, 23);
            this.textBoxOriginalChecksumValue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Checksum du fichier original :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectionner un fichier pour calculer le checksum (ou vous pouvez glisser déposer" +
    " un fichier)";
            // 
            // textBoxFileHash
            // 
            this.textBoxFileHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileHash.Location = new System.Drawing.Point(3, 183);
            this.textBoxFileHash.Name = "textBoxFileHash";
            this.textBoxFileHash.Size = new System.Drawing.Size(675, 23);
            this.textBoxFileHash.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Checksum du fichier actuel :";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilePath.Location = new System.Drawing.Point(3, 24);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(675, 23);
            this.textBoxFilePath.TabIndex = 9;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(684, 24);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(74, 23);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Importer ...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonCheckChecksum
            // 
            this.buttonCheckChecksum.Location = new System.Drawing.Point(684, 257);
            this.buttonCheckChecksum.Name = "buttonCheckChecksum";
            this.buttonCheckChecksum.Size = new System.Drawing.Size(74, 23);
            this.buttonCheckChecksum.TabIndex = 7;
            this.buttonCheckChecksum.Text = "Vérifier ...";
            this.buttonCheckChecksum.UseVisualStyleBackColor = true;
            this.buttonCheckChecksum.Click += new System.EventHandler(this.buttonCheckChecksum_Click);
            // 
            // buttonComputeChecksum
            // 
            this.buttonComputeChecksum.Location = new System.Drawing.Point(684, 183);
            this.buttonComputeChecksum.Name = "buttonComputeChecksum";
            this.buttonComputeChecksum.Size = new System.Drawing.Size(74, 23);
            this.buttonComputeChecksum.TabIndex = 7;
            this.buttonComputeChecksum.Text = "Recalculer";
            this.buttonComputeChecksum.UseVisualStyleBackColor = true;
            this.buttonComputeChecksum.Click += new System.EventHandler(this.buttonComputeChecksum_Click);
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Items.AddRange(new object[] {
            "SHA-256",
            "SHA-512",
            "MD5"});
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(3, 109);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlgorithm.TabIndex = 10;
            this.comboBoxAlgorithm.Text = "SHA-256";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selectionner un algorithme de hashage :";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // FrmMenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 331);
            this.Controls.Add(this.tableLayoutMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(809, 406);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinChecksum Utility";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMenu_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMenu_DragEnter);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxFileHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOriginalChecksumValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonCheckChecksum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonComputeChecksum;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label label4;
    }
}

