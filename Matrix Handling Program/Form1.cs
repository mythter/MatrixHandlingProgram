/*
Файл: Form1.cs
Лабораторная робота № 4
Автор: Положий А. С.
Тема: Дослідження особливостей використання прикладної об'єктно-орієнтованої програми
Дата створення: 23.03.2023
*/

using ManrixHandlingProgram;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MatrixHandlingProgram
{
    public partial class Form1 : Form, IView
    {
        Presenter presenter;
        Arr arrClass;
        Arr modArrClass;
        AboutForm aboutForm;
        ResultForm? resultForm;

        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        public int N { get => (int)NUpDown.Value; set => NUpDown.Value = value; }
        public int A { get => (int)AUpDown.Value; set => AUpDown.Value = value; }
        public int B { get => (int)BUpDown.Value; set => BUpDown.Value = value; }
        public bool Op1 { get => RadioOp1.Checked; set => RadioOp1.Checked = value; }
        public bool Op2 { get => RadioOp2.Checked; set => RadioOp2.Checked = value; }
        public bool Op3 { get => RadioOp3.Checked; set => RadioOp3.Checked = value; }
        public Arr ArrayClass { get => arrClass; set => arrClass = value; }
        public Arr ModArrayClass { get => modArrClass; set => modArrClass = value; }
        public SaveFileDialog Save { get => SaveFileDialog; set => Save = value; }
        public OpenFileDialog Open { get => OpenFileDialog; set => Open = value; }
        public AboutForm AboutForm { get => aboutForm; set => aboutForm = value; }
        public ResultForm? ResultForm { get => resultForm; set => resultForm = value; }
        public string I { get => ITextBox.Text; set => ITextBox.Text = value; }
        public string J { get => JTextBox.Text; set => JTextBox.Text = value; }
        public string K { get => KTextBox.Text; set => KTextBox.Text = value; }

        public event EventHandler GenerateAttempted;
        public event EventHandler WriteOriginalArrayAttempted;
        public event EventHandler WriteModifiedArrayAttempted;
        public event EventHandler ReadFromFileAttempted;
        public event EventHandler OpenAboutFormAttempted;
        public event EventHandler DoOperationAttempted;

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            OpenAboutFormAttempted?.Invoke(this, EventArgs.Empty);
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            GenerateAttempted?.Invoke(this, EventArgs.Empty);
        }

        private void DoOpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DoOperationAttempted?.Invoke(this, EventArgs.Empty);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IJK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back)
            {
                TextBox textBox = (TextBox)sender;
                string s = textBox.Text;

                if (s == "0" && e.KeyChar != (char)Keys.Back)
                    e.KeyChar = (char)Keys.None;

                if (e.KeyChar == '0' && s == "-")
                    e.KeyChar = (char)Keys.None;

                if (e.KeyChar == '-' && s.Length > 0)
                    e.KeyChar = (char)Keys.None;
            }
            else
                e.KeyChar = (char)Keys.None;
        }

        private void SaveArrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WriteOriginalArrayAttempted?.Invoke(this, EventArgs.Empty);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReadFromFileAttempted?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveOpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WriteModifiedArrayAttempted?.Invoke(this, EventArgs.Empty);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}