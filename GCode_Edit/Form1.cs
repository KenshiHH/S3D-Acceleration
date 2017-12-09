using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GCode_Edit
{
    public partial class Form1 : Form
    {
        string GCodeFilePath =null;
        string GCodePatchedFilePath;
        string tempPath;
        string patchString = "_patched";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "GCode (*.gcode)|*.gcode";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            tempPath = openFileDialog1.FileName;
                            if (tempPath.Contains(patchString)){
                                GCodeFilePath = null;
                                MessageBox.Show("Error: File already patched!?!");
                            }
                            else {
                                GCodeFilePath = openFileDialog1.FileName;
                                label_FileSource.Text = Path.GetFileNameWithoutExtension(GCodeFilePath);
                                GCodePatchedFilePath = Path.GetDirectoryName(GCodeFilePath) + "\\" + Path.GetFileNameWithoutExtension(GCodeFilePath) + "_patched" + Path.GetExtension(GCodeFilePath);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GCodeFilePath == null)
            {
                MessageBox.Show("Error: no valid file selected.");
            }
            else
            {
                StreamReader gcode = new StreamReader(GCodeFilePath);
                StreamWriter gcode2 = new StreamWriter(GCodePatchedFilePath);
                string line;
                string newSkirtACC = "M204 S" + acceleration_Skirt.Value.ToString();
                string newOuterACC = "M204 S" + acceleration_OuterPerimeter.Value.ToString();
                string newInnerACC = "M204 S" + acceleration_InnerPerimeter.Value.ToString();
                string newSolidACC = "M204 S" + acceleration_SolidLayer.Value.ToString();
                string newInfillACC = "M204 S" + acceleration_Infill.Value.ToString();
                string newGapACC = "M204 S" + acceleration_GapFill.Value.ToString();
                string newSupportACC = "M204 S" + acceleration_Support.Value.ToString();
                string newDenseSupportACC = "M204 S" + acceleration_DenseSupport.Value.ToString();
                int linesfound = 0;

                while ((line = gcode.ReadLine()) != null)
                {
                    gcode2.WriteLine(line);
                    switch (line)
                    {
                        case "; outer perimeter":
                            linesfound++;
                            gcode2.WriteLine(newOuterACC);
                            break;
                        case "; inner perimeter":
                            linesfound++;
                            gcode2.WriteLine(newInnerACC);
                            break;
                        case "; skirt":
                            linesfound++;
                            gcode2.WriteLine(newSkirtACC);
                            break;
                        case "; solid layer":
                            linesfound++;
                            gcode2.WriteLine(newSolidACC);
                            break;
                        case "; infill":
                            linesfound++;
                            gcode2.WriteLine(newInfillACC);
                            break;
                        case "; gap fill":
                            linesfound++;
                            gcode2.WriteLine(newGapACC);
                            break;
                        case "; support":
                            linesfound++;
                            gcode2.WriteLine(newSupportACC);
                            break;
                        case "; dense support":
                            linesfound++;
                            gcode2.WriteLine(newDenseSupportACC);
                            break;
                    }
                }
                gcode2.Close();
                //MessageBox.Show("Lines found: " + linesfound.ToString());
                MessageBox.Show("lines added: " + linesfound.ToString());
            }
        }

        private void textBox_OuterAcceleration_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
