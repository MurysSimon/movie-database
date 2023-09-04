
namespace MurysProjektDatabazeFilmu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFilms = new System.Windows.Forms.ListBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.btnDeleteFilm = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFilms
            // 
            this.lstFilms.FormattingEnabled = true;
            this.lstFilms.Location = new System.Drawing.Point(12, 12);
            this.lstFilms.Name = "lstFilms";
            this.lstFilms.Size = new System.Drawing.Size(761, 355);
            this.lstFilms.TabIndex = 0;
            this.lstFilms.DoubleClick += new System.EventHandler(this.lstFilms_DoubleClick);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(12, 386);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(102, 52);
            this.btnAddFilm.TabIndex = 1;
            this.btnAddFilm.Text = "Add";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.Location = new System.Drawing.Point(120, 386);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(102, 52);
            this.btnEditFilm.TabIndex = 2;
            this.btnEditFilm.Text = "Edit";
            this.btnEditFilm.UseVisualStyleBackColor = true;
            this.btnEditFilm.Click += new System.EventHandler(this.btnEditFilm_Click);
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.Location = new System.Drawing.Point(228, 386);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(102, 52);
            this.btnDeleteFilm.TabIndex = 3;
            this.btnDeleteFilm.Text = "Delete";
            this.btnDeleteFilm.UseVisualStyleBackColor = true;
            this.btnDeleteFilm.Click += new System.EventHandler(this.btnDeleteFilm_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(671, 386);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 52);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDeleteFilm);
            this.Controls.Add(this.btnEditFilm);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.lstFilms);
            this.Name = "Form1";
            this.Text = "Film Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFilms;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.Button btnDeleteFilm;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

