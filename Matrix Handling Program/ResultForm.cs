/*
Файл: ResultForm.cs
Лабораторная робота № 4
Автор: Положий А. С.
Тема: Дослідження особливостей використання прикладної об'єктно-орієнтованої програми
Дата створення: 23.03.2023
*/

using System.Runtime.InteropServices;


namespace ManrixHandlingProgram
{
    public partial class ResultForm : Form
    {
        #region Caret disabled
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(ResultTextBox.Handle);
        }
        #endregion

        public ResultForm()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            HideCaret();
        }
    }
}
