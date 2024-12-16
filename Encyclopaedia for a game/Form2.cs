using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Encyclopaedia_for_a_game.GameEntries;

namespace Encyclopaedia_for_a_game
{
    public partial class Form2 : Form
    {
        //Allows file locations to be accessed anywhere in here
        public static readonly string Filepath = GameEnriesFile.Filepath;


        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Varible collector
            string title = textBox3.Text;
            string length = textBox2.Text;
            string genre = textBox1.Text;


            //checker for empty entries 
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(genre) || string.IsNullOrWhiteSpace(length))
            {
                //warning messagebox
                string message = "Please fill everything";
                string warning = "Warning";
                MessageBox.Show(message, warning);
            }

            else
            {
                GameEntry Newgame = new GameEntry
                {
                    Title = title,
                    Genre = genre,
                    Length = length,
                };

                //File writer / updater
                //Serializes the object into a string for a json file
                string existingJson = File.Exists(Filepath) ? File.ReadAllText(Filepath) : "[]";
                //Deserializes the json files contents and puts into a list 
                var gameList = JsonSerializer.Deserialize<List<GameEntry>>(existingJson) ?? new List<GameEntry>();

                //adds the new entry to the list 
                gameList.Add(Newgame);

                //writes new list to the json file
                var options = new JsonSerializerOptions { WriteIndented = true };
                string updatedJsonString = JsonSerializer.Serialize(gameList, options);

                File.WriteAllText(Filepath, updatedJsonString);

                this.Close();
            }
        }
    }
}
