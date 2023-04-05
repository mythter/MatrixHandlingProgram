/*
Файл: Presenter.cs
Лабораторная робота № 4
Автор: Положий А. С.
Тема: Дослідження особливостей використання прикладної об'єктно-орієнтованої програми
Дата створення: 23.03.2023
*/

using System.Xml.Serialization;
using ManrixHandlingProgram;

namespace MatrixHandlingProgram
{
    internal class Presenter
    {
        private readonly IView form;
        public Presenter(IView form)
        {
            this.form = form;
            this.form.OpenAboutFormAttempted += OpenAboutForm;
            this.form.GenerateAttempted += GenerateArray;
            this.form.DoOperationAttempted += Output;
            this.form.WriteOriginalArrayAttempted += WriteOriginalArray;
            this.form.WriteModifiedArrayAttempted += WriteModifiedArray;
            this.form.ReadFromFileAttempted += ReadOriginalArray;
        }

        private void WriteOriginalArray(object? sender, EventArgs e)
        {
            if (this.form.ArrayClass == null)
                throw new NullReferenceException("Array was not generated");

            try
            {
                string userFileName;
                this.form.Save.InitialDirectory = @"C:\";
                this.form.Save.FileName = "array.xml";
                this.form.Save.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                this.form.Save.Title = "Save file as...";

                if (this.form.Save.ShowDialog() == DialogResult.OK)
                {
                    userFileName = this.form.Save.FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(Arr));
                    using (FileStream fs = new FileStream(userFileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, this.form.ArrayClass);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void WriteModifiedArray(object? sender, EventArgs e)
        {
            if (this.form.ModArrayClass == null)
                throw new NullReferenceException("Array is not exist");

            try
            {
                string userFileName;
                this.form.Save.InitialDirectory = @"C:\";
                this.form.Save.FileName = "modified_array.xml";
                this.form.Save.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                this.form.Save.Title = "Save file as...";

                if (this.form.Save.ShowDialog() == DialogResult.OK)
                {
                    userFileName = this.form.Save.FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(Arr));
                    using (FileStream fs = new FileStream(userFileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, this.form.ModArrayClass);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ReadOriginalArray(object? sender, EventArgs e)
        {
            try
            {
                this.form.Open.InitialDirectory = @"С:\";
                this.form.Open.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                this.form.Open.Title = "Open file";

                if (this.form.Open.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Arr));
                    using (FileStream fs = new FileStream(this.form.Open.FileName, FileMode.Open))
                    {
                        this.form.ArrayClass = (Arr)serializer.Deserialize(fs);
                    }
                }

                if (this.form.ArrayClass?.Array != null)
                {
                    this.form.N = this.form.ArrayClass.Array.GetLength(0);
                    this.form.A = this.form.ArrayClass.Min;
                    this.form.B = this.form.ArrayClass.Max;
                    DoOperation(Radio.None);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GenerateArray(object? sender, EventArgs e)
        {
            this.form.ArrayClass = new(this.form.N, this.form.A, this.form.B);
            this.form.ModArrayClass = null;
            Random rand = new Random();
            for (int i = 0; i < this.form.N; i++)
            {
                for (int j = 0; j < this.form.N; j++)
                    this.form.ArrayClass.Array![i, j] = rand.Next(this.form.A, this.form.B);
            }

            DoOperation(Radio.None);
        }

        public void OnResultFormClosed(object? sender, EventArgs e)
        {
            this.form.ResultForm = null;
        }

        public void OpenAboutForm(object? sender, EventArgs e)
        {
            this.form.AboutForm = new AboutForm();
            this.form.AboutForm.Show();
        }

        private void DoOperation(Radio Op)
        {
            if (this.form.N == 0 || this.form.ArrayClass?.Array?.GetLength(0) == 0) return;

            if (this.form.ResultForm == null)
            {
                this.form.ResultForm = new ResultForm();
                this.form.ResultForm.FormClosed += OnResultFormClosed;
            }

            this.form.ResultForm.ResultTextBox.Text = "";
            this.form.ResultForm.ResultTextBox.Text += $"N = {this.form.N},";
            this.form.ResultForm.ResultTextBox.Text += $" Min = {this.form.ArrayClass.Min}, Max = {this.form.ArrayClass.Max}\n";

            this.form.ResultForm.OrigArrDataGrid.ColumnCount = this.form.N;
            this.form.ResultForm.OrigArrDataGrid.RowCount = this.form.N;

            this.form.ResultForm.ModArrDataGrid?.Columns?.Clear();


            for (int i = 0; i < this.form.N; i++)
            {
                this.form.ResultForm.OrigArrDataGrid.Columns[i].HeaderText = i.ToString();
                this.form.ResultForm.OrigArrDataGrid.Rows[i].HeaderCell.Value = i.ToString();
                this.form.ResultForm.OrigArrDataGrid.Columns[i].Width = 50;
            }

            for (int i = 0; i < this.form.N; i++)
            {
                for (int j = 0; j < this.form.N; j++)
                    this.form.ResultForm.OrigArrDataGrid[j, i].Value = this.form.ArrayClass.Array![i, j];
            }

            switch (Op)
            {
                case Radio.Op1:
                    this.form.ModArrayClass = null;
                    int.TryParse(this.form.I, out int i);
                    int.TryParse(this.form.J, out int j);

                    if (this.form.ResultForm.ResultTextBox.Text.Contains($"[{i}, {j}] ="))
                        break;

                    this.form.ResultForm.ResultTextBox.Text += $"[{i}, {j}] = {this.form.ArrayClass.Array![i, j]}";
                    break;
                case Radio.Op2:
                    this.form.ResultForm.ModArrDataGrid!.ColumnCount = this.form.N;
                    this.form.ResultForm.ModArrDataGrid.RowCount = this.form.N;

                    for (int g = 0; g < this.form.N; g++)
                    {
                        this.form.ResultForm.ModArrDataGrid.Columns[g].HeaderText = g.ToString();
                        this.form.ResultForm.ModArrDataGrid.Rows[g].HeaderCell.Value = g.ToString();
                        this.form.ResultForm.ModArrDataGrid.Columns[g].Width = 50;
                    }

                    this.form.ModArrayClass = new (this.form.N, this.form.A, this.form.B);
                    this.form.ModArrayClass.Array =  this.form.ArrayClass.Array?.Clone() as int[,];

                    for (int l = 0; l < this.form.N; l++)
                    {
                        for (int x = 0; x < this.form.N - 1; x++)
                        {
                            for (int b = x + 1; b < this.form.N; b++)
                            {
                                if (this.form.ModArrayClass.Array?[l, x] > this.form.ModArrayClass.Array?[l, b])
                                    (this.form.ModArrayClass.Array[l, x], this.form.ModArrayClass.Array[l, b]) = (this.form.ModArrayClass.Array[l, b], this.form.ModArrayClass.Array[l, x]);
                            }
                        }
                    }

                    for (int h = 0; h < this.form.N; h++)
                    {
                        for (int f = 0; f < this.form.N; f++)
                            this.form.ResultForm.ModArrDataGrid[f, h].Value = this.form.ModArrayClass.Array![h, f];
                    }

                    break;
                case Radio.Op3:
                    this.form.ResultForm.ModArrDataGrid!.ColumnCount = this.form.N;
                    this.form.ResultForm.ModArrDataGrid.RowCount = this.form.N;

                    int.TryParse(this.form.K, out int k);

                    this.form.ModArrayClass = new(this.form.N, this.form.A, this.form.B);
                    this.form.ModArrayClass.Array = this.form.ArrayClass.Array?.Clone() as int[,];

                    for (int g = 0; g < this.form.N; g++)
                    {
                        this.form.ResultForm.ModArrDataGrid.Columns[g].HeaderText = g.ToString();
                        this.form.ResultForm.ModArrDataGrid.Rows[g].HeaderCell.Value = g.ToString();
                        this.form.ResultForm.ModArrDataGrid.Columns[g].Width = 50;
                    }

                    for (int h = 0; h < this.form.N; h++)
                    {
                        for (int f = 0; f < this.form.N; f++)
                        {
                            this.form.ModArrayClass.Array![h, f] *= -k;
                            this.form.ResultForm.ModArrDataGrid[f, h].Value = this.form.ModArrayClass.Array![h, f];
                        }
                    }

                    break;
            }

            this.form.ResultForm.Show();
            return;
        }

        private void Output(object? sender, EventArgs e)
        {
            int i = -1, j = -1;
            if (this.form.Op1 &&
                (!int.TryParse(this.form.I, out i) ||
                !int.TryParse(this.form.J, out j) ||
                i < 0 || i >= this.form.N ||
                j < 0 || j >= this.form.N))
            {
                throw new ArgumentException("i and j fields must not be less than 0 or greater than N-1 or blank");
            }

            if (this.form.Op3 &&
                !int.TryParse(this.form.K, out int k))
            {
                throw new ArgumentException("k field must not be blank");
            }

            if (this.form.ArrayClass != null && this.form.ArrayClass.Array?.GetUpperBound(0) + 1 == this.form.N)
                if (this.form.Op1) DoOperation(Radio.Op1);
                else if (this.form.Op2) DoOperation(Radio.Op2);
                else if (this.form.Op3) DoOperation(Radio.Op3);
                else DoOperation(Radio.None);
            else
                throw new NullReferenceException("Array was not generated or you entered a new N");
        }

        enum Radio
        {
            None = 0,
            Op1 = 1,
            Op2 = 2,
            Op3 = 3,
        };
    }
}
