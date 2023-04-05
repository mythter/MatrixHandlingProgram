/*
Файл: ArrayClass.cs
Лабораторная робота № 4
Автор: Положий А. С.
Тема: Дослідження особливостей використання прикладної об'єктно-орієнтованої програми
Дата створення: 23.03.2023
*/

using System.ComponentModel;
using System.Xml.Serialization;

namespace MatrixHandlingProgram
{
    [Serializable]
    public class Arr
    {
        [XmlIgnore]
        public int[,]? Array { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        [XmlArray("Array"), Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int[][] XmlArray
        {
            get
            {
                int[][] xml = new int[Array.GetLength(0)][];
                for (int i = 0; i < Array?.GetLength(0); i++)
                {
                    xml[i] = new int[Array.GetLength(0)];
                    for (int j = 0; j < Array?.GetLength(0); j++)
                    {
                        xml[i][j] = Array[i, j];
                    }
                }
                return xml;
            }
            set
            {
                Array = new int[value[0].Length, value[0].Length];
                for (int i = 0; i < Array?.GetLength(0); i++)
                {
                    for (int j = 0; j < Array?.GetLength(0); j++)
                    {
                        Array[i, j] = value[i][j];
                    }
                }
            }
        }

        public Arr(int n, int min, int max)
        {
            Array = new int[n, n];
            Min = min;
            Max = max;
        }
        public Arr() { }
    }
}
