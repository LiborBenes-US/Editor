using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public class EditorForm : Form
    {
        private TextBox textBox;
        private MainMenu mainMenu;

        public EditorForm(string filePath = null)
        {
            this.Text = "Plain Text Editor";
            this.Width = 800;
            this.Height = 600;

            textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            textBox.ScrollBars = ScrollBars.Vertical;
            
            // Sets a clean, highly readable font at size 16
            textBox.Font = new System.Drawing.Font("Consolas", 16, System.Drawing.FontStyle.Regular);
            
            this.Controls.Add(textBox);

            mainMenu = new MainMenu();
            MenuItem fileMenu = mainMenu.MenuItems.Add("&File");
            fileMenu.MenuItems.Add("&Open", new EventHandler(OpenFile));
            fileMenu.MenuItems.Add("&Save", new EventHandler(SaveFile));
            this.Menu = mainMenu;

            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                textBox.Text = File.ReadAllText(filePath);
                this.Text = "Plain Text Editor - " + Path.GetFileName(filePath);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = File.ReadAllText(openDialog.FileName);
                this.Text = "Plain Text Editor - " + Path.GetFileName(openDialog.FileName);
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName, textBox.Text);
                this.Text = "Plain Text Editor - " + Path.GetFileName(saveDialog.FileName);
            }
        }

        [STAThread]
        public static void Main(string[] args) 
        {
            Application.EnableVisualStyles();
            
            if (args.Length > 0)
            {
                Application.Run(new EditorForm(args[0]));
            }
            else
            {
                Application.Run(new EditorForm());
            }
        }
    }
}