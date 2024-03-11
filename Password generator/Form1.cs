using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows;
using Microsoft.Win32;

namespace Password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Generate(object sender, EventArgs e)
        {
            ResultBox.Items.Clear();    
            try
            {
                string from = "";
                string res = "";
                int count = int.Parse(LengthBox.Text);
                from += SymbolTextBox.Text;
                if (Numberbox.Checked == true)
                {
                    from += "1234567890";
                }
                if (SmallLetterbox.Checked == true)
                {
                    from += "abcdefghijklmnopqrstuvwxyz";
                }
                if (BigLetterBox.Checked == true)
                {
                    from += "abcdefghijklmnopqrstuvwxyz".ToUpper();
                }
                if (SymbolLetterBox.Checked == true)
                {
                    from += "!@#$%^&*()_+=-[]{};:\'\"\\|/?.>,<`~";
                }
                from = string.Join("", from.Distinct());
                var temp = new Random();
                for (int a = 0; a < 15; a++)
                {
                    for (int i = 0; i < count; i++)
                    {
                        res += from[temp.Next(0, from.Length)];
                    }
                    ResultBox.Items.Add(res);
                    res = "";
                }
            }
            catch (Exception) { }
        }

        private void Copybutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultBox.SelectedItem.ToString());
        }
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); 
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
            saveFileDialog.InitialDirectory = @"D:\Mein progectos\Password generator";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, string.Join("\n",ResultBox.Items.Cast<string>()));
        }
    }
}
