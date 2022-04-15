using System;
using System.IO;
using System.Text;

namespace Mass_file_renamer_
{
    public partial class Form1 : Form
    {

        String filesPath = "";
        String[] files;

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
#       pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            LoadingLabel.Text = "";
        }

        private void GetPath_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);
                    filesPath = fbd.SelectedPath;
                    PathPreview.Text = filesPath;

                    foreach (string file in files)
                    {
                        OutputWindow.Text+= file + Environment.NewLine;
                    }

                    ChangeFiles.Enabled = true;
                }
            }



        }

        private void ChangeFiles_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = "";
            LoadingLabel.Text = "Loading...";   
            String[] newEpisodesNames = EpisodeInput.Text.Split('\n');
            Array.Sort(newEpisodesNames, (x, y) => String.Compare(x, y));

            if (newEpisodesNames.Length != files.Length)
            {
                DialogResult dialogResult = MessageBox.Show("The amount of episodes does not match, continue?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChangeNames(newEpisodesNames);
                }
            }else
            {
                ChangeNames(newEpisodesNames);
            }



           
        }

        private void ChangeNames(String[] newEpisodes)
        {
            int i = 0;
            foreach (string file in files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);
                string newFilename;
                try
                {
                    newFilename = file.Replace(filename, string.Join("", newEpisodes[i].Split(Path.GetInvalidFileNameChars())));
                }
                catch (Exception ex)
                {
                    newFilename = file;
                }
                
                if (int.Parse(SeasonNumer.Text) != 1)
                {
                    if(int.Parse(SeasonNumer.Text) > 10) newFilename = newFilename.Replace("S01", "S" + SeasonNumer.Text);
                    else newFilename = newFilename.Replace("S01", "S0" + SeasonNumer.Text);
                }




                OutputWindow.Text += "Replaced: \"" + file + "\" With: \"" + newFilename + "\"" + Environment.NewLine; 
                File.Move(file, newFilename);
                i ++;
            }
            LoadingLabel.Text = "";
            OutputWindow.Enabled = true;

        }
    }
}