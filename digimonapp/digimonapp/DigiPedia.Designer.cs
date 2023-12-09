namespace digimonapp
{
    partial class digiPedia
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
            this.dgvDigimons = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.pbxDigimon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDigimons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDigimon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDigimons
            // 
            this.dgvDigimons.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDigimons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDigimons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDigimons.Location = new System.Drawing.Point(12, 71);
            this.dgvDigimons.MultiSelect = false;
            this.dgvDigimons.Name = "dgvDigimons";
            this.dgvDigimons.RowHeadersWidth = 51;
            this.dgvDigimons.RowTemplate.Height = 24;
            this.dgvDigimons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDigimons.Size = new System.Drawing.Size(468, 323);
            this.dgvDigimons.TabIndex = 0;
            this.dgvDigimons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDigimons_CellContentClick);
            this.dgvDigimons.SelectionChanged += new System.EventHandler(this.dgvDigimons_SelectionChanged);
            // 
            // Agregar
            // 
            this.Agregar.AccessibleName = "btnAgregar";
            this.Agregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(229, 429);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(151, 54);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxDigimon
            // 
            this.pbxDigimon.Location = new System.Drawing.Point(653, 125);
            this.pbxDigimon.Name = "pbxDigimon";
            this.pbxDigimon.Size = new System.Drawing.Size(305, 269);
            this.pbxDigimon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDigimon.TabIndex = 1;
            this.pbxDigimon.TabStop = false;
            this.pbxDigimon.Click += new System.EventHandler(this.pbxDigimon_Click);
            // 
            // digiPedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::digimonapp.Properties.Resources._20519259;
            this.ClientSize = new System.Drawing.Size(1138, 627);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.pbxDigimon);
            this.Controls.Add(this.dgvDigimons);
            this.DoubleBuffered = true;
            this.Name = "digiPedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiPedia";
            this.Load += new System.EventHandler(this.DigiPedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDigimons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDigimon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDigimons;
        private System.Windows.Forms.PictureBox pbxDigimon;
        private System.Windows.Forms.Button Agregar;
    }
}