using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace voice_reco
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recengine = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void enablevoice_Click(object sender, EventArgs e)
        {
            recengine.RecognizeAsync(RecognizeMode.Multiple);
            disablevoice.Enabled = true;
            enablevoice.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices command = new Choices();
            command.Add(new string[] { "up", "down","hello","johny" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(command);
            Grammar grammer = new Grammar(gBuilder);

            recengine.LoadGrammarAsync(grammer);
            recengine.SetInputToDefaultAudioDevice();
            recengine.SpeechRecognized += recengine_SpeechRecognized;
        }

        void recengine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "up":
                    MessageBox.Show("up up");

                    break;
                case "down":
                    MessageBox.Show("down down");

                    break;

                default:
                        
                            MessageBox.Show("F**k u");
                    break;
                    
            }
        }

        private void disablevoice_Click(object sender, EventArgs e)
        {
            recengine.RecognizeAsyncStop();
            disablevoice.Enabled = false;
            enablevoice.Enabled = true;
        }
    }
}
