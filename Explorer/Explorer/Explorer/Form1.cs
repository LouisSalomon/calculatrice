using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Veuillez sélectionner le répertoire à parcourir :";
                if (dialog.ShowDialog(this) == DialogResult.OK
                 && !string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    txtSource.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "*.txt|.txt";
                dialog.OverwritePrompt = true;
                if (dialog.ShowDialog(this) == DialogResult.OK
                 && !string.IsNullOrEmpty(dialog.FileName))
                {
                    txtSortie.Text = dialog.FileName;
                }
            }
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            if (!Valider()) return;

            this.Enabled = false;

            // Création du fichier de sortie
            if (!Directory.Exists(Path.GetDirectoryName(txtSortie.Text)))
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(txtSortie.Text));
                }
                catch (Exception ex)
                {
                    this.Enabled = true;
                    MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (var sortie = File.CreateText(txtSortie.Text))
            {
                Parcourir(txtSource.Text, sortie);
                sortie.Flush();
            }

            this.Enabled = true;
            MessageBox.Show(this, "Traitement terminé", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Valider()
        {
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                MessageBox.Show(this, "Vous devez définir un répertoire source !", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSource.Focus();
                return false;
            }
            else if (!Directory.Exists(txtSource.Text))
            {
                MessageBox.Show(this, "Le répertoire source sélectionné n'existe pas !", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSource.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSortie.Text))
            {
                MessageBox.Show(this, "Vous devez définir un fichier de sortie !", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSortie.Focus();
                return false;
            }

            return true;
        }

        private void Parcourir(string repertoireCourant, StreamWriter sortie)
        {
            sortie.WriteLine(repertoireCourant);
            try
            {
                foreach (var fichier in Directory.EnumerateFiles(repertoireCourant))
                {
                    sortie.WriteLine(fichier);
                }
            }
            catch(Exception ex)
            {
                sortie.WriteLine(ex.Message);
            }
            
            try
            { 
                foreach (var repertoire in Directory.EnumerateDirectories(repertoireCourant))
                {
                    Parcourir(repertoire, sortie);
                }
            }
            catch (Exception ex)
            {
                sortie.WriteLine(ex.Message);
            }
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            using (var form = new frmExplorer())
            {
                form.ShowDialog(this);
            }
        }
    }
}
