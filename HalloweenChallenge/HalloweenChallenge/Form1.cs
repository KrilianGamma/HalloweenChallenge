using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenChallenge
{
    public partial class Form1 : Form
    {
        private string connectionString =
            "Server=localhost;Port=3306;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Film> films = new List<Film>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            if (checkBox1.Checked == true)
            {
                string sql = $"SELECT title FROM film" +
                $" WHERE title LIKE '{FilmSearchText.Text}'";
                films = connection.Query<Film>(sql).ToList();
                FilmsList.DataSource = films;
                FilmsList.DisplayMember = "FullInfo";
            }
            else
            {
                string sql = $"SELECT title FROM film" +
                $" WHERE title LIKE '%{FilmSearchText.Text}%'";
                films = connection.Query<Film>(sql).ToList();
                FilmsList.DataSource = films;
                FilmsList.DisplayMember = "FullInfo";
            }


            connection.Close();
        }

        private void FilmsList_button2_Click(object sender, EventArgs e)
        {
            Film selectedFilm = FilmsList.SelectedItem as Film;
            Form2 filmDetailsForm = new Form2(selectedFilm);
            filmDetailsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Guest")
            {
                label6.Text = "";
                button1.Text = "Login";
            }
            else if (label6.Text == "Staff")
            {
                label6.Text = "";
                button1.Text = "Login";
            }
            else
            {
                if (textBox2.Text == "Guest" && textBox1.Text == "123")
                {
                    label6.Text = "Guest";
                    button1.Text = "Log out";
                }
                else if (textBox2.Text == "Staff" && textBox1.Text == "456")
                {
                    label6.Text = "Guest";
                }

            }

        }
    }
}
