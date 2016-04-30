using System;
using System.Windows.Forms;
using System.Windows.Media;


namespace RecordPlayer
{
    public partial class Form1 : Form
    {
        private MediaPlayer _player = new MediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Константин\Downloads";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog1.InitialDirectory + @"\" + openFileDialog1.SafeFileName;
                    PlaySound(filename);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        
        private void PlaySound(string path)
        {
            
            _player.Open(new Uri(path));
            _player.Play();
        }

        private void StopSound()
        {
            _player.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopSound();
        }
    }
}
