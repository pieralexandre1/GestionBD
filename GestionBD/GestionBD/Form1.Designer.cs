namespace GestionBD
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
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEntreprise = new System.Windows.Forms.TextBox();
            this.Prénom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonPrec = new System.Windows.Forms.Button();
            this.buttonSuiv = new System.Windows.Forms.Button();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(150, 29);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(256, 26);
            this.textBoxPrenom.TabIndex = 0;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(150, 58);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(256, 26);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxEntreprise
            // 
            this.textBoxEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntreprise.Location = new System.Drawing.Point(150, 87);
            this.textBoxEntreprise.Name = "textBoxEntreprise";
            this.textBoxEntreprise.Size = new System.Drawing.Size(256, 26);
            this.textBoxEntreprise.TabIndex = 2;
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prénom.Location = new System.Drawing.Point(36, 32);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(64, 20);
            this.Prénom.TabIndex = 3;
            this.Prénom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entreprise";
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(40, 127);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(75, 23);
            this.buttonDebut.TabIndex = 6;
            this.buttonDebut.Text = "Début";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(331, 127);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(75, 23);
            this.buttonFin.TabIndex = 7;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonPrec
            // 
            this.buttonPrec.Location = new System.Drawing.Point(137, 127);
            this.buttonPrec.Name = "buttonPrec";
            this.buttonPrec.Size = new System.Drawing.Size(75, 23);
            this.buttonPrec.TabIndex = 8;
            this.buttonPrec.Text = "<";
            this.buttonPrec.UseVisualStyleBackColor = true;
            this.buttonPrec.Click += new System.EventHandler(this.buttonPrec_Click);
            // 
            // buttonSuiv
            // 
            this.buttonSuiv.Location = new System.Drawing.Point(233, 127);
            this.buttonSuiv.Name = "buttonSuiv";
            this.buttonSuiv.Size = new System.Drawing.Size(75, 23);
            this.buttonSuiv.TabIndex = 9;
            this.buttonSuiv.Text = ">";
            this.buttonSuiv.UseVisualStyleBackColor = true;
            this.buttonSuiv.Click += new System.EventHandler(this.buttonSuiv_Click);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(441, 29);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(152, 23);
            this.buttonNouveau.TabIndex = 10;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(441, 58);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(152, 23);
            this.buttonAjouter.TabIndex = 11;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(441, 87);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(152, 23);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Location = new System.Drawing.Point(441, 137);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(152, 23);
            this.buttonMAJ.TabIndex = 13;
            this.buttonMAJ.Text = "Mise à jour";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(441, 166);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(152, 23);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 224);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.buttonSuiv);
            this.Controls.Add(this.buttonPrec);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prénom);
            this.Controls.Add(this.textBoxEntreprise);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Name = "Form1";
            this.Text = "Gestion d\'une base de données";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxEntreprise;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonPrec;
        private System.Windows.Forms.Button buttonSuiv;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}

