namespace La_tâche_Espace_des_clubs
{
    partial class Modifier_membres
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier_membres));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Prénom = new System.Windows.Forms.Label();
            this.button_Ajouter = new System.Windows.Forms.Button();
            this.button_Supprimer = new System.Windows.Forms.Button();
            this.dataGridView_listem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Stagiaire = new System.Windows.Forms.RadioButton();
            this.radioButton_Formateur = new System.Windows.Forms.RadioButton();
            this.comboBox_Formateur = new System.Windows.Forms.ComboBox();
            this.comboBox_Stagiaire = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_nomF = new System.Windows.Forms.ComboBox();
            this.comboBox_prenomF = new System.Windows.Forms.ComboBox();
            this.comboBox_nomS = new System.Windows.Forms.ComboBox();
            this.comboBox_prenomS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listem)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(471, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 121;
            // 
            // label_Prénom
            // 
            this.label_Prénom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Prénom.AutoSize = true;
            this.label_Prénom.Location = new System.Drawing.Point(68, 101);
            this.label_Prénom.Name = "label_Prénom";
            this.label_Prénom.Size = new System.Drawing.Size(35, 13);
            this.label_Prénom.TabIndex = 119;
            this.label_Prénom.Text = "Nom :";
            // 
            // button_Ajouter
            // 
            this.button_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Ajouter.BackgroundImage")));
            this.button_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Ajouter.FlatAppearance.BorderSize = 0;
            this.button_Ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.button_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.button_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajouter.Location = new System.Drawing.Point(360, 83);
            this.button_Ajouter.Name = "button_Ajouter";
            this.button_Ajouter.Size = new System.Drawing.Size(37, 31);
            this.button_Ajouter.TabIndex = 112;
            this.button_Ajouter.UseVisualStyleBackColor = true;
            this.button_Ajouter.Click += new System.EventHandler(this.button_Ajouter_Click);
            // 
            // button_Supprimer
            // 
            this.button_Supprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Supprimer.BackgroundImage")));
            this.button_Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Supprimer.FlatAppearance.BorderSize = 0;
            this.button_Supprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.button_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.button_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Supprimer.Location = new System.Drawing.Point(437, 83);
            this.button_Supprimer.Name = "button_Supprimer";
            this.button_Supprimer.Size = new System.Drawing.Size(37, 31);
            this.button_Supprimer.TabIndex = 122;
            this.button_Supprimer.UseVisualStyleBackColor = true;
            this.button_Supprimer.Click += new System.EventHandler(this.button_Supprimer_Click);
            // 
            // dataGridView_listem
            // 
            this.dataGridView_listem.AllowUserToAddRows = false;
            this.dataGridView_listem.AllowUserToDeleteRows = false;
            this.dataGridView_listem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_listem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_listem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_listem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_listem.Location = new System.Drawing.Point(59, 203);
            this.dataGridView_listem.MultiSelect = false;
            this.dataGridView_listem.Name = "dataGridView_listem";
            this.dataGridView_listem.ReadOnly = true;
            this.dataGridView_listem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listem.Size = new System.Drawing.Size(530, 131);
            this.dataGridView_listem.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "Prénom :";
            // 
            // radioButton_Stagiaire
            // 
            this.radioButton_Stagiaire.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_Stagiaire.AutoSize = true;
            this.radioButton_Stagiaire.Location = new System.Drawing.Point(71, 68);
            this.radioButton_Stagiaire.Name = "radioButton_Stagiaire";
            this.radioButton_Stagiaire.Size = new System.Drawing.Size(66, 17);
            this.radioButton_Stagiaire.TabIndex = 157;
            this.radioButton_Stagiaire.TabStop = true;
            this.radioButton_Stagiaire.Text = "Stagiaire";
            this.radioButton_Stagiaire.UseVisualStyleBackColor = true;
            this.radioButton_Stagiaire.Click += new System.EventHandler(this.radioButton_Stagiaire_Click);
            // 
            // radioButton_Formateur
            // 
            this.radioButton_Formateur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_Formateur.AutoSize = true;
            this.radioButton_Formateur.Location = new System.Drawing.Point(71, 36);
            this.radioButton_Formateur.Name = "radioButton_Formateur";
            this.radioButton_Formateur.Size = new System.Drawing.Size(72, 17);
            this.radioButton_Formateur.TabIndex = 156;
            this.radioButton_Formateur.TabStop = true;
            this.radioButton_Formateur.Text = "Formateur";
            this.radioButton_Formateur.UseVisualStyleBackColor = true;
            this.radioButton_Formateur.Click += new System.EventHandler(this.radioButton_Formateur_Click);
            // 
            // comboBox_Formateur
            // 
            this.comboBox_Formateur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Formateur.FormattingEnabled = true;
            this.comboBox_Formateur.Location = new System.Drawing.Point(159, 45);
            this.comboBox_Formateur.Name = "comboBox_Formateur";
            this.comboBox_Formateur.Size = new System.Drawing.Size(75, 21);
            this.comboBox_Formateur.TabIndex = 155;
            // 
            // comboBox_Stagiaire
            // 
            this.comboBox_Stagiaire.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Stagiaire.FormattingEnabled = true;
            this.comboBox_Stagiaire.Location = new System.Drawing.Point(159, 45);
            this.comboBox_Stagiaire.Name = "comboBox_Stagiaire";
            this.comboBox_Stagiaire.Size = new System.Drawing.Size(75, 21);
            this.comboBox_Stagiaire.TabIndex = 154;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 158;
            this.comboBox1.Visible = false;
            // 
            // comboBox_nomF
            // 
            this.comboBox_nomF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_nomF.FormattingEnabled = true;
            this.comboBox_nomF.Location = new System.Drawing.Point(159, 93);
            this.comboBox_nomF.Name = "comboBox_nomF";
            this.comboBox_nomF.Size = new System.Drawing.Size(75, 21);
            this.comboBox_nomF.TabIndex = 162;
            // 
            // comboBox_prenomF
            // 
            this.comboBox_prenomF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_prenomF.FormattingEnabled = true;
            this.comboBox_prenomF.Location = new System.Drawing.Point(159, 120);
            this.comboBox_prenomF.Name = "comboBox_prenomF";
            this.comboBox_prenomF.Size = new System.Drawing.Size(75, 21);
            this.comboBox_prenomF.TabIndex = 161;
            // 
            // comboBox_nomS
            // 
            this.comboBox_nomS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_nomS.FormattingEnabled = true;
            this.comboBox_nomS.Location = new System.Drawing.Point(159, 93);
            this.comboBox_nomS.Name = "comboBox_nomS";
            this.comboBox_nomS.Size = new System.Drawing.Size(75, 21);
            this.comboBox_nomS.TabIndex = 160;
            // 
            // comboBox_prenomS
            // 
            this.comboBox_prenomS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_prenomS.FormattingEnabled = true;
            this.comboBox_prenomS.Location = new System.Drawing.Point(159, 120);
            this.comboBox_prenomS.Name = "comboBox_prenomS";
            this.comboBox_prenomS.Size = new System.Drawing.Size(75, 21);
            this.comboBox_prenomS.TabIndex = 159;
            // 
            // Modifier_membres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_nomF);
            this.Controls.Add(this.comboBox_prenomF);
            this.Controls.Add(this.comboBox_nomS);
            this.Controls.Add(this.comboBox_prenomS);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton_Stagiaire);
            this.Controls.Add(this.radioButton_Formateur);
            this.Controls.Add(this.comboBox_Formateur);
            this.Controls.Add(this.comboBox_Stagiaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_listem);
            this.Controls.Add(this.button_Supprimer);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Prénom);
            this.Controls.Add(this.button_Ajouter);
            this.Name = "Modifier_membres";
            this.Size = new System.Drawing.Size(674, 406);
            this.Load += new System.EventHandler(this.Modifier_membres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Prénom;
        private System.Windows.Forms.Button button_Ajouter;
        private System.Windows.Forms.Button button_Supprimer;
        private System.Windows.Forms.DataGridView dataGridView_listem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Stagiaire;
        private System.Windows.Forms.RadioButton radioButton_Formateur;
        private System.Windows.Forms.ComboBox comboBox_Formateur;
        private System.Windows.Forms.ComboBox comboBox_Stagiaire;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox_nomF;
        private System.Windows.Forms.ComboBox comboBox_prenomF;
        private System.Windows.Forms.ComboBox comboBox_nomS;
        private System.Windows.Forms.ComboBox comboBox_prenomS;

    }
}
