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
    public partial class Form1 : Form
    {
        class ListBoxFilmItem
        {
            public Film Film { get; private set; }
            
            public ListBoxFilmItem(Film film)
            {
                this.Film = film;
            }

            public override string ToString()
            {
                return $"Name: {this.Film.Name}, Director: {this.Film.Director}, Genre: {this.Film.Genre}, Year: {this.Film.YearOfRelease}, Lenght: {this.Film.LenghtInMin}";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshFilmList();
        }

        private void RefreshFilmList(bool preserveSelection = false)
        {
            int selectedIndex = lstFilms.SelectedIndex;

            lstFilms.Items.Clear();
            foreach (Film film in Model.Films)
            {
                lstFilms.Items.Add(new ListBoxFilmItem(film));
            }

            if (preserveSelection)
            {
                selectedIndex = Math.Min(
                    lstFilms.Items.Count - 1,
                    Math.Max(-1, selectedIndex));
                lstFilms.SelectedIndex = selectedIndex;
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            FormFilmEdit formFilmEdit = new FormFilmEdit();
            DialogResult result = formFilmEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                Film film = formFilmEdit.Film;
                Model.Films.Add(film);
                RefreshFilmList();
            }
        }

        private void lstFilms_DoubleClick(object sender, EventArgs e)
        {
            ListBoxFilmItem listBoxFilmItem =
                lstFilms.SelectedItem as ListBoxFilmItem;
            if (listBoxFilmItem == null) return;

            FormFilmEdit formFilmEdit = new FormFilmEdit();
            formFilmEdit.Film = listBoxFilmItem.Film;
            DialogResult result = formFilmEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                Film film = formFilmEdit.Film;
                RefreshFilmList(true);
            }
        }

        private void btnEditFilm_Click(object sender, EventArgs e)
        {
            ListBoxFilmItem listBoxFilmItem =
                lstFilms.SelectedItem as ListBoxFilmItem;
            if (listBoxFilmItem == null) return;

            FormFilmEdit formFilmEdit = new FormFilmEdit();
            formFilmEdit.Film = listBoxFilmItem.Film;
            DialogResult result = formFilmEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                Film film = formFilmEdit.Film;
                RefreshFilmList(true);
            }
        }

        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to remove this film?","Remove film.", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListBoxFilmItem listBoxFilmItem =
                lstFilms.SelectedItem as ListBoxFilmItem;
                if (listBoxFilmItem == null) return;

                Film film = listBoxFilmItem.Film;
                Model.Films.Remove(film);
                RefreshFilmList(true);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Film database (*.dbd)|*.dbd|All files (*.*)|*.*",
                Title = "Select file for database...",
            };
            var res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                string filename = sfd.FileName;
                string tempName = System.IO.Path.GetTempFileName();
                string fileContent = GenerateFileContent();

                try
                {
                    System.IO.File.WriteAllText(tempName, fileContent);
                    System.IO.File.Copy(tempName, filename, true);
                    System.IO.File.Delete(tempName);

                    MessageBox.Show("Saved", "Saved...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Saving films to file" +
                        $"'{filename}' failed " +
                        $"Reason: {ex.Message}",
                        "Saving failed...",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private string GenerateFileContent()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var film in Model.Films)
            {
                sb.Append(film.Name);
                sb.Append(",");
                sb.Append(film.Director);
                sb.Append(",");
                sb.Append(film.Genre);
                sb.Append(",");
                sb.Append(film.YearOfRelease);
                sb.Append(",");
                sb.Append(film.LenghtInMin);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Film database (*.dbd)|*.dbd|All files (*.*)|*.*",
                Title = "Choose database file...",
            };
            var res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                string filename = ofd.FileName;

                try
                {
                    string[] fileContent = System.IO.File.ReadAllLines(filename);

                    LoadContentIntoTheModel(fileContent);

                    MessageBox.Show("Loaded", "Loaded...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Loading films from " +
                        $"'{filename}' failed " +
                        $"Reason: {ex.Message}",
                        "Loading failed...",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            RefreshFilmList(true);
        }

        private void LoadContentIntoTheModel(string[] lines)
        {

            List<Film> films = new List<Film>();
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');

                films.Add(new Film()
                {
                    Name = parts[0],
                    Director = parts[1],
                    Genre = parts[2],
                    YearOfRelease = int.Parse(parts[3]),
                    LenghtInMin = int.Parse(parts[4])
                });

                Model.Films.Clear();

                foreach (var film in films)
                {
                    Model.Films.Add(film);
                }
            }

        }
    }

        
}

