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
    public partial class Form2 : Form
    {
        Film _selectedFilm;
        public Form2(Film selectedFilm)
        {
            InitializeComponent();
            _selectedFilm = selectedFilm;
            label1.Text = selectedFilm.title;
            label5.Text = selectedFilm.description;
            label7.Text = selectedFilm.lenght;
            label6.Text = selectedFilm.rating;
            if (selectedFilm.rating == "NC-17" || selectedFilm.rating == "R")
            {
                label6.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
