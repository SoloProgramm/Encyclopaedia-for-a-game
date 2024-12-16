using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Encyclopaedia_for_a_game.GameEntries;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encyclopaedia_for_a_game
{
    public partial class Form1 : Form
    {
        //Allows file location to be accessed anywhere in here
        public static readonly string Filepath = GameEnriesFile.Filepath;

        public List<GameEntry> JsonDeserializer()
        {
            //Reads the json file and then stores as a string 
            //Deserializes the json and puts the GameEntry objects into a list 
            string jsonString = System.IO.File.ReadAllText(Filepath);
            var gamelist = JsonSerializer.Deserialize<List<GameEntry>>(jsonString);
            return gamelist;
        }

        private void refresh()
        {
            //clears the list box
            listBox1.Items.Clear();

            var gamelist = JsonDeserializer();

            //Gets the games titles to be displayed in the list box
            var titles = gamelist?.Select(game => game.Title).ToList();

            //Loop to add the list of titles to the Listbox
            List<string> lines = new List<string>(titles);
            for (int i = 0; i < lines.Count; i++)
            {
                listBox1.Items.Add(lines[i]);
            }

            //gets all the lengths and adds them together to displays them
            //removes all non intergers to prevent errors
            int totalLength = gamelist?.Select(game =>
            {
                string numberstring = Regex.Replace(game.Length, @"\D", "");
                return int.TryParse(numberstring, out int length) ? length : 0;
            }).Sum() ?? 0;

            HoursTotal.Text = totalLength.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Filepath))
            {
                refresh();
            }
            else
            {
                //checks if file path exists displays error it not
                string message = "File location not found";
                string title = "Error";
                MessageBox.Show(message, title);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;

            var gamelist = JsonDeserializer();

            //Changes the text in the text boxes with their asigned values 
            var Title = gamelist?.Select(game => game.Title).ToList();
            List<string> title = new List<string>(Title);

            textBox1.Text = title[index];

            var Genre = gamelist?.Select(game => game.Genre).ToList();
            List<string> genre = new List<string>(Genre);

            textBox2.Text = genre[index];

            var Length = gamelist?.Select(game => game.Length).ToList();
            List<string> length = new List<string>(Length);

            textBox3.Text = length[index];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var gameList = JsonDeserializer();

            int index = listBox1.SelectedIndex;

            if (index != -1)
            {
                //removes the selected game from the listbox
                //removes the selected game from the json file
                listBox1.Items.RemoveAt(index);
                gameList.RemoveAt(index);

                //updates and reserializes the json file
                var options = new JsonSerializerOptions { WriteIndented = true };
                string updatedJsonString = JsonSerializer.Serialize(gameList, options);
                System.IO.File.WriteAllText(Filepath, updatedJsonString);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //opens the new entry form
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //not working
            refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
