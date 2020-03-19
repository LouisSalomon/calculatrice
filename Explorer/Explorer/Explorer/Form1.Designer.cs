namespace Explorer
{
    partial class Form1
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnSortie = new System.Windows.Forms.Button();
            this.lblSortie = new System.Windows.Forms.Label();
            this.txtSortie = new System.Windows.Forms.TextBox();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(230, 23);
            this.txtSource.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(1112, 31);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "C:\\temp\\IUT\\Explorer";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(24, 29);
            this.lblSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(195, 25);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Répertoire source :";
            // 
            // btnSource
            // 
            this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSource.Location = new System.Drawing.Point(1358, 19);
            this.btnSource.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(220, 44);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "Parcourir";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnSortie
            // 
            this.btnSortie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortie.Location = new System.Drawing.Point(1358, 69);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(220, 44);
            this.btnSortie.TabIndex = 5;
            this.btnSortie.Text = "Parcourir";
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // lblSortie
            // 
            this.lblSortie.AutoSize = true;
            this.lblSortie.Location = new System.Drawing.Point(24, 79);
            this.lblSortie.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSortie.Name = "lblSortie";
            this.lblSortie.Size = new System.Drawing.Size(178, 25);
            this.lblSortie.TabIndex = 4;
            this.lblSortie.Text = "Fichier de sortie :";
            // 
            // txtSortie
            // 
            this.txtSortie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortie.Location = new System.Drawing.Point(230, 73);
            this.txtSortie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSortie.Name = "txtSortie";
            this.txtSortie.Size = new System.Drawing.Size(1112, 31);
            this.txtSortie.TabIndex = 3;
            this.txtSortie.Text = "C:\\temp\\test.txt";
            // 
            // btnGenerer
            // 
            this.btnGenerer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerer.Location = new System.Drawing.Point(30, 125);
            this.btnGenerer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(1548, 81);
            this.btnGenerer.TabIndex = 6;
            this.btnGenerer.Text = "Lister les fichiers";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnExplorer
            // 
            this.btnExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExplorer.Location = new System.Drawing.Point(30, 377);
            this.btnExplorer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(1548, 75);
            this.btnExplorer.TabIndex = 8;
            this.btnExplorer.Text = "Ouvrir l\'explorer complet";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 475);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.lblSortie);
            this.Controls.Add(this.txtSortie);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtSource);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnSortie;
        private System.Windows.Forms.Label lblSortie;
        private System.Windows.Forms.TextBox txtSortie;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.Button btnExplorer;
    }
}

