namespace ManrixHandlingProgram
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            OrigArrDataGrid = new DataGridView();
            ModArrDataGrid = new DataGridView();
            ResultTextBox = new RichTextBox();
            GeneratedArrayLabel = new Label();
            ModifiedArrayLabel = new Label();
            ResultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OrigArrDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ModArrDataGrid).BeginInit();
            SuspendLayout();
            // 
            // OrigArrDataGrid
            // 
            OrigArrDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrigArrDataGrid.Location = new Point(12, 43);
            OrigArrDataGrid.Name = "OrigArrDataGrid";
            OrigArrDataGrid.RowHeadersWidth = 51;
            OrigArrDataGrid.RowTemplate.Height = 29;
            OrigArrDataGrid.Size = new Size(372, 285);
            OrigArrDataGrid.TabIndex = 0;
            // 
            // ModArrDataGrid
            // 
            ModArrDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModArrDataGrid.Location = new Point(416, 43);
            ModArrDataGrid.Name = "ModArrDataGrid";
            ModArrDataGrid.RowHeadersWidth = 51;
            ModArrDataGrid.RowTemplate.Height = 29;
            ModArrDataGrid.Size = new Size(372, 285);
            ModArrDataGrid.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(12, 372);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(776, 66);
            ResultTextBox.TabIndex = 2;
            ResultTextBox.Text = "";
            ResultTextBox.GotFocus += TextBox_GotFocus;
            // 
            // GeneratedArrayLabel
            // 
            GeneratedArrayLabel.AutoSize = true;
            GeneratedArrayLabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            GeneratedArrayLabel.Location = new Point(12, 7);
            GeneratedArrayLabel.Name = "GeneratedArrayLabel";
            GeneratedArrayLabel.Size = new Size(150, 24);
            GeneratedArrayLabel.TabIndex = 3;
            GeneratedArrayLabel.Text = "Generated Array";
            // 
            // ModifiedArrayLabel
            // 
            ModifiedArrayLabel.AutoSize = true;
            ModifiedArrayLabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ModifiedArrayLabel.Location = new Point(416, 7);
            ModifiedArrayLabel.Name = "ModifiedArrayLabel";
            ModifiedArrayLabel.Size = new Size(137, 24);
            ModifiedArrayLabel.TabIndex = 4;
            ModifiedArrayLabel.Text = "Modified Array";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ResultLabel.Location = new Point(12, 338);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(63, 24);
            ResultLabel.TabIndex = 5;
            ResultLabel.Text = "Result";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(ModifiedArrayLabel);
            Controls.Add(GeneratedArrayLabel);
            Controls.Add(ResultTextBox);
            Controls.Add(ModArrDataGrid);
            Controls.Add(OrigArrDataGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResultForm";
            Text = "Result";
            ((System.ComponentModel.ISupportInitialize)OrigArrDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ModArrDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView OrigArrDataGrid;
        internal DataGridView ModArrDataGrid;
        internal RichTextBox ResultTextBox;
        private Label GeneratedArrayLabel;
        private Label ModifiedArrayLabel;
        private Label ResultLabel;
    }
}