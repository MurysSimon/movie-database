using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurysProjektDatabazeFilmu
{
    public partial class FormFilmEdit : Form
    {
        public FormFilmEdit()
        {
            InitializeComponent();
        }

        private Film film = new Film();

        public Film Film
        {
            get
            {
                film.Name = txtName.Text;
                film.Director = txtDirector.Text;
                film.Genre = txtGenre.Text;
                film.YearOfRelease = (int)numYear.Value;
                film.LenghtInMin = (int)numLenght.Value;
                return film;
            }

            set
            {
                this.film = value;
                txtName.Text = value.Name;
                txtDirector.Text = value.Director;
                txtGenre.Text = value.Genre;
                numYear.Value = value.YearOfRelease;
                numLenght.Value = value.LenghtInMin;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.btnOk.Enabled = 
                string.IsNullOrWhiteSpace(txtName.Text) == false
                && string.IsNullOrWhiteSpace(txtDirector.Text) == false
                && string.IsNullOrWhiteSpace(txtGenre.Text) == false;
        }
    }
}
