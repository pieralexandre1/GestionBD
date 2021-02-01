using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GestionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OleDbConnection conn = null;
        private OleDbDataAdapter da;
        private DataSet ds;
        private DataRow ligne;
        private OleDbCommandBuilder cb;

        private int ctr = 0;
        private int max_lignes = 0;

        private string reqSQLUniversal = "select * from Clients";
        private string chemin = Application.StartupPath + "\\";
        private string bd = "exempleLINQ.mdb";
        


        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + chemin + bd + ";Persist Security Info=False";

            try
            {
                conn = new OleDbConnection();
                ds = new DataSet();

                conn.ConnectionString = connString;
                da = new OleDbDataAdapter(reqSQLUniversal, conn);

                conn.Open();

                // remplir le dataset
                da.Fill(ds, "Clients");

                // nombre de lignes max dans le dataset
                max_lignes = ds.Tables["Clients"].Rows.Count;

                // affichage des données
                navigation();

                conn.Close();

                buttonAjouter.Enabled = false;
                buttonAnnuler.Enabled = false;
                buttonNouveau.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Erreur de connexion: " + ex.Message);
            }
        }

        private void refresh()
        {
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + chemin + bd + ";Persist Security Info=False";

            conn = new OleDbConnection();
            ds = new DataSet();

            conn.ConnectionString = connString;
            da = new OleDbDataAdapter(reqSQLUniversal, conn);

            conn.Open();

            // remplir le dataset
            da.Fill(ds, "Clients");

            // nombre de lignes max dans le dataset
            max_lignes = ds.Tables["Clients"].Rows.Count;

            // affichage des données
            navigation();

            conn.Close();
        }

        public void navigation()
        {
            if(max_lignes > 0)
            {
                ligne = ds.Tables["Clients"].Rows[ctr];

                // deux façons d'afficher: itemArray ou []
                textBoxPrenom.Text = ligne[1].ToString();
                textBoxNom.Text = ligne[2].ToString();
                textBoxEntreprise.Text = ligne.ItemArray.GetValue(3).ToString();
            }
            else
            {
                //MessageBox.Show("La liste est vide.");
            }

        }

        private void buttonSuiv_Click(object sender, EventArgs e)
        {
            //Liste pas vide
            if (max_lignes > 0)
            {
                if (ctr != max_lignes - 1)
                {
                    ctr++;
                    navigation();
                }
                else
                    MessageBoxEx.Show(this,"Fin des enregistrements");
            }
            else
            {
                MessageBoxEx.Show("La liste est vide.");
            }

        }

        private void buttonPrec_Click(object sender, EventArgs e)
        {
            //Liste pas vide
            if (max_lignes > 0)
            {
                if (ctr > 0)
                {
                    ctr--;
                    navigation();
                }
                else
                    MessageBoxEx.Show(this, "Début des enregistrements");
            }
            else
            {
                MessageBoxEx.Show(this, "La liste est vide.");
            }
        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            //Liste pas vide
            if (max_lignes > 0)
            {
                ctr = 0;
                navigation();
            }
            else
            {
                MessageBoxEx.Show(this, "La liste est vide.");
            }
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            //Liste pas vide
            if (max_lignes > 0)
            {
                ctr = max_lignes - 1;
                navigation();
            }
            else
            {
                MessageBoxEx.Show(this, "La liste est vide.");
            }
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            textBoxPrenom.Clear();
            textBoxNom.Clear();
            textBoxEntreprise.Clear();

            buttonAjouter.Enabled = true;
            buttonAnnuler.Enabled = true;
            buttonNouveau.Enabled = false;

            buttonDebut.Enabled = false;
            buttonPrec.Enabled = false;
            buttonSuiv.Enabled = false;
            buttonFin.Enabled = false;
            buttonMAJ.Enabled = false;
            buttonSupprimer.Enabled = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            navigation();
            buttonAjouter.Enabled = false;
            buttonAnnuler.Enabled = false;
            buttonNouveau.Enabled = true;


            buttonDebut.Enabled = true;
            buttonPrec.Enabled = true;
            buttonSuiv.Enabled = true;
            buttonFin.Enabled = true;
            buttonMAJ.Enabled = true;
            buttonSupprimer.Enabled = true;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

            // création d'une nouvelle ligne dans le dataset

            DataRow nouvelle = ds.Tables["Clients"].NewRow();

            // rechercher le ID Client précédant dans la BD, ajouter + 1 pour créer une clé primaire

            int idSuiv = 0;

            if (ds.Tables["Clients"].Rows.Count <= 0)
            {
                idSuiv = 1;
            }
            else { 
                idSuiv = Convert.ToInt32(ds.Tables["Clients"].Rows[max_lignes-1][0]) + 1;
            }

            // ajouter dans la nouvelle ligne du dataset

            nouvelle[0] = idSuiv;
            nouvelle[1] = textBoxPrenom.Text;
            nouvelle[2] = textBoxNom.Text;
            nouvelle[3] = textBoxEntreprise.Text;

            ds.Tables["Clients"].Rows.Add(nouvelle);

            // mettre dans la BD 

            try
            {
                cb = new OleDbCommandBuilder(da);
                da.Update(ds, "Clients");
                max_lignes++;
                ctr= max_lignes - 1;
                MessageBox.Show (this, "Enregistrement ajouté avec succès!");
                refresh();
                navigation();

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Erreur: " + ex.Message);

            }

            buttonAjouter.Enabled = false;
            buttonAnnuler.Enabled = false;
            buttonNouveau.Enabled = true;

            buttonDebut.Enabled = true;
            buttonPrec.Enabled = true;
            buttonSuiv.Enabled = true;
            buttonFin.Enabled = true;
            buttonMAJ.Enabled = true;
            buttonSupprimer.Enabled = true;
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            //Liste pas vide
            if (max_lignes > 0)
            {
                DataRow ligneMAJ = ds.Tables["Clients"].Rows[ctr];

                ligneMAJ[1] = textBoxPrenom.Text;
                ligneMAJ[2] = textBoxNom.Text;
                ligneMAJ[3] = textBoxEntreprise.Text;

                try
                {
                    cb = new OleDbCommandBuilder(da);
                    da.Update(ds, "Clients");
                    MessageBoxEx.Show(this, "Enregistrement mis à jour avec succès.");

                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, "Erreur: " + ex.Message);

                }
            }
            else
            {
                MessageBoxEx.Show(this, "Erreur: La liste est vide.");
            }


        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            //Liste pas vide
            if(max_lignes > 0) { 
                try
                {
                    ds.Tables["Clients"].Rows[ctr].Delete();
                    cb = new OleDbCommandBuilder(da);

                    da.Update(ds, "Clients");
                    max_lignes = ds.Tables["Clients"].Rows.Count;

                    if (max_lignes <= 0)
                    {
                        ctr = 0;
                    }else if(ctr == 0)
                    {
                    }
                    else
                    {
                        ctr--;
                    }
                    textBoxPrenom.Clear();
                    textBoxNom.Clear();
                    textBoxEntreprise.Clear();
                    navigation();
                    MessageBoxEx.Show(this, "Enregistrement supprimé.");
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, "Erreur: " + ex.Message);

                }
            }
            else
            {
                MessageBoxEx.Show(this, "Erreur: La liste est vide.");
            }
        }

    }
}
