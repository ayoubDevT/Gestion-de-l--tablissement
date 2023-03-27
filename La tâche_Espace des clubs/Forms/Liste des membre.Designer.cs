namespace La_tâche_Espace_des_clubs
{
    partial class Liste_des_membress
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Numero_rech = new System.Windows.Forms.Label();
            this.textBox_Numero_rech = new System.Windows.Forms.TextBox();
            this.dataGridView_liste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Numero_rech
            // 
            this.label_Numero_rech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Numero_rech.AutoSize = true;
            this.label_Numero_rech.Location = new System.Drawing.Point(187, 68);
            this.label_Numero_rech.Name = "label_Numero_rech";
            this.label_Numero_rech.Size = new System.Drawing.Size(35, 13);
            this.label_Numero_rech.TabIndex = 113;
            this.label_Numero_rech.Text = "Nom :";
            // 
            // textBox_Numero_rech
            // 
            this.textBox_Numero_rech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Numero_rech.Location = new System.Drawing.Point(242, 65);
            this.textBox_Numero_rech.Name = "textBox_Numero_rech";
            this.textBox_Numero_rech.Size = new System.Drawing.Size(110, 20);
            this.textBox_Numero_rech.TabIndex = 112;
            this.textBox_Numero_rech.TextChanged += new System.EventHandler(this.textBox_Numero_rech_TextChanged);
            // 
            // dataGridView_liste
            // 
            this.dataGridView_liste.AllowUserToAddRows = false;
            this.dataGridView_liste.AllowUserToDeleteRows = false;
            this.dataGridView_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_liste.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_liste.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_liste.Location = new System.Drawing.Point(57, 199);
            this.dataGridView_liste.MultiSelect = false;
            this.dataGridView_liste.Name = "dataGridView_liste";
            this.dataGridView_liste.ReadOnly = true;
            this.dataGridView_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_liste.Size = new System.Drawing.Size(530, 131);
            this.dataGridView_liste.TabIndex = 131;
            // 
            // Liste_des_membress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_liste);
            this.Controls.Add(this.label_Numero_rech);
            this.Controls.Add(this.textBox_Numero_rech);
            this.Name = "Liste_des_membress";
            this.Size = new System.Drawing.Size(667, 412);
            this.Load += new System.EventHandler(this.Liste_des_membress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Numero_rech;
        private System.Windows.Forms.TextBox textBox_Numero_rech;
        public System.Windows.Forms.DataGridView dataGridView_liste;
    }
}
