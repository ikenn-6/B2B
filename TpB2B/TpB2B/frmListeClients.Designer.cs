﻿namespace TpB2B
{
    partial class frmListeClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeClients));
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.lblRaisonSoc = new System.Windows.Forms.Label();
            this.txtRaisonSoc = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Raison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNvxClient = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.btnTous);
            this.grpRecherche.Controls.Add(this.btnRechercher);
            this.grpRecherche.Controls.Add(this.txtRaisonSoc);
            this.grpRecherche.Controls.Add(this.lblRaisonSoc);
            this.grpRecherche.Location = new System.Drawing.Point(23, 13);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Size = new System.Drawing.Size(473, 87);
            this.grpRecherche.TabIndex = 0;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "Recherche";
            // 
            // lblRaisonSoc
            // 
            this.lblRaisonSoc.AutoSize = true;
            this.lblRaisonSoc.Location = new System.Drawing.Point(6, 36);
            this.lblRaisonSoc.Name = "lblRaisonSoc";
            this.lblRaisonSoc.Size = new System.Drawing.Size(84, 13);
            this.lblRaisonSoc.TabIndex = 1;
            this.lblRaisonSoc.Text = "Raison Sociale :";
            // 
            // txtRaisonSoc
            // 
            this.txtRaisonSoc.Location = new System.Drawing.Point(96, 33);
            this.txtRaisonSoc.Name = "txtRaisonSoc";
            this.txtRaisonSoc.Size = new System.Drawing.Size(192, 20);
            this.txtRaisonSoc.TabIndex = 2;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(311, 31);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(392, 30);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(75, 23);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "&Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Raison,
            this.Ville,
            this.CodePostal,
            this.Prive,
            this.Activite,
            this.Nature});
            this.dataGridView1.Location = new System.Drawing.Point(23, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 275);
            this.dataGridView1.TabIndex = 5;
            // 
            // Raison
            // 
            this.Raison.HeaderText = "Raison Sociale";
            this.Raison.Name = "Raison";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code Postal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Prive
            // 
            this.Prive.HeaderText = "Privé ?";
            this.Prive.Name = "Prive";
            // 
            // Activite
            // 
            this.Activite.HeaderText = "Activité";
            this.Activite.Name = "Activite";
            // 
            // Nature
            // 
            this.Nature.HeaderText = "Nature";
            this.Nature.Name = "Nature";
            // 
            // btnNvxClient
            // 
            this.btnNvxClient.Location = new System.Drawing.Point(396, 415);
            this.btnNvxClient.Name = "btnNvxClient";
            this.btnNvxClient.Size = new System.Drawing.Size(110, 23);
            this.btnNvxClient.TabIndex = 6;
            this.btnNvxClient.Text = "&Nouveau Client";
            this.btnNvxClient.UseVisualStyleBackColor = true;
            this.btnNvxClient.Click += new System.EventHandler(this.btnNvxClient_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(512, 415);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(593, 415);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnNvxClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpRecherche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListeClients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmListeClients";
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRaisonSoc;
        private System.Windows.Forms.Label lblRaisonSoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raison;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.Button btnNvxClient;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
    }
}