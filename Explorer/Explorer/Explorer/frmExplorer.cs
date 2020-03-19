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
    public partial class frmExplorer : Form
    {
        public frmExplorer()
        {
            InitializeComponent();
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            tvRepertoires.PathSeparator = "\\";
            tvRepertoires.Nodes.Clear();

            // Chargement du premier niveau (Lecteurs)
            foreach (var lecteur in DriveInfo.GetDrives())
            {
                try
                {
                    tvRepertoires.Nodes.Add(lecteur.Name, lecteur.Name + (string.IsNullOrEmpty(lecteur.VolumeLabel) ? "" : " (" + lecteur.VolumeLabel + ")"));
                }
                catch (Exception) { }
            }

            // Chargement du niveau 2
            foreach (TreeNode node in tvRepertoires.Nodes)
                ChargerRepertoires(node);

        }

        private void tvRepertoires_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtSource.Text = e.Node.FullPath;
            ChargerFichiers(e.Node);
        }
        private void tvRepertoires_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
                ChargerRepertoires(node);
        }



        private void ChargerRepertoires(TreeNode racine)
        {
            try
            {
                foreach (var repertoire in Directory.EnumerateDirectories(GetKeyPath(racine)))
                {
                    racine.Nodes.Add(Path.GetFileName(repertoire), Path.GetFileName(repertoire));
                }
            }
            catch (Exception ex)
            {
                racine.Nodes.Add("exception", ex.Message);
            }
        }

        private void ChargerFichiers(TreeNode racine)
        {
            try
            {
                lvFiles.Items.Clear();

                foreach (var fichier in Directory.EnumerateFiles(GetKeyPath(racine)))
                {
                    lvFiles.Items.Add(new ListViewItem( Path.GetFileName(fichier)));
                }
            }
            catch (Exception ex)
            {
                lvFiles.Items.Add(ex.Message);
            }
        }

        public string GetKeyPath(TreeNode node)
        {
            if (node.Parent == null)
            {
                return node.Name;
            }

            return GetKeyPath(node.Parent) + node.TreeView.PathSeparator + node.Name;
        }

    }
}
