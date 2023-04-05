/*
Файл: IView.cs
Лабораторная робота № 4
Автор: Положий А. С.
Тема: Дослідження особливостей використання прикладної об'єктно-орієнтованої програми
Дата створення: 23.03.2023
*/

using ManrixHandlingProgram;

namespace MatrixHandlingProgram
{
    internal interface IView
    {
        // Numeric Up Down.
        int N { get; set; }
        int A { get; set; }
        int B { get; set; }

        // Text Boxes.
        string I { get; set; }
        string J { get; set; }
        string K { get; set; }

        // Radio buttons.
        bool Op1 { get; set; }
        bool Op2 { get; set; }
        bool Op3 { get; set; }

        // Buttons.
        event EventHandler GenerateAttempted;
        event EventHandler WriteOriginalArrayAttempted;
        event EventHandler WriteModifiedArrayAttempted;
        event EventHandler ReadFromFileAttempted;
        event EventHandler OpenAboutFormAttempted;
        event EventHandler DoOperationAttempted;

        // Program data.
        Arr ArrayClass { get; set; }
        Arr ModArrayClass { get; set; }

        // File dialogs.
        SaveFileDialog Save { get; set; }
        OpenFileDialog Open { get; set; }

        // Forms.
        AboutForm AboutForm { get; set; }
        ResultForm? ResultForm { get; set; }
    }
}
