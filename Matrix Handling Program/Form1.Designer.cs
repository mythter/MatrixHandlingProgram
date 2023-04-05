namespace MatrixHandlingProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BUpDown = new NumericUpDown();
            AUpDown = new NumericUpDown();
            BLabel = new Label();
            ALabel = new Label();
            NUpDown = new NumericUpDown();
            NLabel = new Label();
            OperationsGroup = new GroupBox();
            KTextBox = new TextBox();
            KLabel = new Label();
            JTextBox = new TextBox();
            ITextBox = new TextBox();
            JLabel = new Label();
            ILabel = new Label();
            RadioOp3 = new RadioButton();
            RadioOp2 = new RadioButton();
            RadioOp1 = new RadioButton();
            AboutBtn = new Button();
            ReadBtn = new Button();
            SaveArrBtn = new Button();
            SaveOpBtn = new Button();
            GenBtn = new Button();
            DoOpBtn = new Button();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)BUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUpDown).BeginInit();
            OperationsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // BUpDown
            // 
            BUpDown.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BUpDown.Location = new Point(466, 20);
            BUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            BUpDown.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            BUpDown.Name = "BUpDown";
            BUpDown.Size = new Size(120, 26);
            BUpDown.TabIndex = 7;
            BUpDown.TextAlign = HorizontalAlignment.Center;
            BUpDown.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // AUpDown
            // 
            AUpDown.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AUpDown.Location = new Point(302, 20);
            AUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            AUpDown.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            AUpDown.Name = "AUpDown";
            AUpDown.Size = new Size(120, 26);
            AUpDown.TabIndex = 6;
            AUpDown.TextAlign = HorizontalAlignment.Center;
            AUpDown.Value = new decimal(new int[] { 200, 0, 0, int.MinValue });
            // 
            // BLabel
            // 
            BLabel.AutoSize = true;
            BLabel.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BLabel.Location = new Point(429, 22);
            BLabel.Name = "BLabel";
            BLabel.Size = new Size(34, 21);
            BLabel.TabIndex = 9;
            BLabel.Text = "B =";
            // 
            // ALabel
            // 
            ALabel.AutoSize = true;
            ALabel.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ALabel.Location = new Point(265, 22);
            ALabel.Name = "ALabel";
            ALabel.Size = new Size(34, 21);
            ALabel.TabIndex = 8;
            ALabel.Text = "A =";
            // 
            // NUpDown
            // 
            NUpDown.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NUpDown.Location = new Point(134, 20);
            NUpDown.Name = "NUpDown";
            NUpDown.Size = new Size(120, 26);
            NUpDown.TabIndex = 4;
            NUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // NLabel
            // 
            NLabel.AutoSize = true;
            NLabel.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NLabel.Location = new Point(19, 22);
            NLabel.Name = "NLabel";
            NLabel.Size = new Size(109, 21);
            NLabel.TabIndex = 5;
            NLabel.Text = "Array size n =";
            // 
            // OperationsGroup
            // 
            OperationsGroup.Controls.Add(KTextBox);
            OperationsGroup.Controls.Add(KLabel);
            OperationsGroup.Controls.Add(JTextBox);
            OperationsGroup.Controls.Add(ITextBox);
            OperationsGroup.Controls.Add(JLabel);
            OperationsGroup.Controls.Add(ILabel);
            OperationsGroup.Controls.Add(RadioOp3);
            OperationsGroup.Controls.Add(RadioOp2);
            OperationsGroup.Controls.Add(RadioOp1);
            OperationsGroup.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OperationsGroup.Location = new Point(370, 68);
            OperationsGroup.Margin = new Padding(10);
            OperationsGroup.Name = "OperationsGroup";
            OperationsGroup.Size = new Size(216, 333);
            OperationsGroup.TabIndex = 10;
            OperationsGroup.TabStop = false;
            OperationsGroup.Text = "Operations";
            // 
            // KTextBox
            // 
            KTextBox.Location = new Point(99, 296);
            KTextBox.Name = "KTextBox";
            KTextBox.Size = new Size(54, 26);
            KTextBox.TabIndex = 8;
            KTextBox.KeyPress += IJK_KeyPress;
            // 
            // KLabel
            // 
            KLabel.AutoSize = true;
            KLabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            KLabel.Location = new Point(64, 296);
            KLabel.Name = "KLabel";
            KLabel.Size = new Size(34, 24);
            KLabel.TabIndex = 7;
            KLabel.Text = "k =";
            // 
            // JTextBox
            // 
            JTextBox.Location = new Point(149, 106);
            JTextBox.Name = "JTextBox";
            JTextBox.Size = new Size(54, 26);
            JTextBox.TabIndex = 6;
            JTextBox.KeyPress += IJK_KeyPress;
            // 
            // ITextBox
            // 
            ITextBox.Location = new Point(48, 106);
            ITextBox.Name = "ITextBox";
            ITextBox.Size = new Size(54, 26);
            ITextBox.TabIndex = 5;
            ITextBox.KeyPress += IJK_KeyPress;
            // 
            // JLabel
            // 
            JLabel.AutoSize = true;
            JLabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            JLabel.Location = new Point(114, 106);
            JLabel.Name = "JLabel";
            JLabel.Size = new Size(29, 24);
            JLabel.TabIndex = 4;
            JLabel.Text = "j =";
            // 
            // ILabel
            // 
            ILabel.AutoSize = true;
            ILabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ILabel.Location = new Point(13, 106);
            ILabel.Name = "ILabel";
            ILabel.Size = new Size(29, 24);
            ILabel.TabIndex = 3;
            ILabel.Text = "i =";
            // 
            // RadioOp3
            // 
            RadioOp3.Location = new Point(7, 209);
            RadioOp3.Name = "RadioOp3";
            RadioOp3.Size = new Size(202, 79);
            RadioOp3.TabIndex = 2;
            RadioOp3.TabStop = true;
            RadioOp3.Text = "Array elements with an even sum of indices multiply by (-k)";
            RadioOp3.UseVisualStyleBackColor = true;
            // 
            // RadioOp2
            // 
            RadioOp2.Location = new Point(7, 144);
            RadioOp2.Name = "RadioOp2";
            RadioOp2.Size = new Size(200, 67);
            RadioOp2.TabIndex = 1;
            RadioOp2.TabStop = true;
            RadioOp2.Text = "Sort array elements ascending in rows";
            RadioOp2.UseVisualStyleBackColor = true;
            // 
            // RadioOp1
            // 
            RadioOp1.Checked = true;
            RadioOp1.Location = new Point(7, 27);
            RadioOp1.Name = "RadioOp1";
            RadioOp1.Size = new Size(187, 70);
            RadioOp1.TabIndex = 0;
            RadioOp1.TabStop = true;
            RadioOp1.Text = "Determine array element at (i, j)-th place";
            RadioOp1.UseVisualStyleBackColor = true;
            // 
            // AboutBtn
            // 
            AboutBtn.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AboutBtn.Location = new Point(199, 311);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(151, 90);
            AboutBtn.TabIndex = 11;
            AboutBtn.Text = "About";
            AboutBtn.UseVisualStyleBackColor = true;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ReadBtn.Location = new Point(20, 77);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(151, 90);
            ReadBtn.TabIndex = 12;
            ReadBtn.Text = "Read array from file";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // SaveArrBtn
            // 
            SaveArrBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveArrBtn.Location = new Point(20, 194);
            SaveArrBtn.Name = "SaveArrBtn";
            SaveArrBtn.Size = new Size(151, 90);
            SaveArrBtn.TabIndex = 13;
            SaveArrBtn.Text = "Save generated array";
            SaveArrBtn.UseVisualStyleBackColor = true;
            SaveArrBtn.Click += SaveArrBtn_Click;
            // 
            // SaveOpBtn
            // 
            SaveOpBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveOpBtn.Location = new Point(20, 311);
            SaveOpBtn.Name = "SaveOpBtn";
            SaveOpBtn.Size = new Size(151, 90);
            SaveOpBtn.TabIndex = 14;
            SaveOpBtn.Text = "Save modified array";
            SaveOpBtn.UseVisualStyleBackColor = true;
            SaveOpBtn.Click += SaveOpBtn_Click;
            // 
            // GenBtn
            // 
            GenBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            GenBtn.Location = new Point(199, 77);
            GenBtn.Name = "GenBtn";
            GenBtn.Size = new Size(151, 90);
            GenBtn.TabIndex = 15;
            GenBtn.Text = "Generate";
            GenBtn.UseVisualStyleBackColor = true;
            GenBtn.Click += GenBtn_Click;
            // 
            // DoOpBtn
            // 
            DoOpBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DoOpBtn.Location = new Point(199, 194);
            DoOpBtn.Name = "DoOpBtn";
            DoOpBtn.Size = new Size(151, 90);
            DoOpBtn.TabIndex = 16;
            DoOpBtn.Text = "Do operation";
            DoOpBtn.UseVisualStyleBackColor = true;
            DoOpBtn.Click += DoOpBtn_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 414);
            Controls.Add(DoOpBtn);
            Controls.Add(GenBtn);
            Controls.Add(SaveOpBtn);
            Controls.Add(SaveArrBtn);
            Controls.Add(ReadBtn);
            Controls.Add(AboutBtn);
            Controls.Add(OperationsGroup);
            Controls.Add(BUpDown);
            Controls.Add(AUpDown);
            Controls.Add(BLabel);
            Controls.Add(ALabel);
            Controls.Add(NUpDown);
            Controls.Add(NLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Matrix Handling Program";
            ((System.ComponentModel.ISupportInitialize)BUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUpDown).EndInit();
            OperationsGroup.ResumeLayout(false);
            OperationsGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown BUpDown;
        private NumericUpDown AUpDown;
        private Label BLabel;
        private Label ALabel;
        private NumericUpDown NUpDown;
        private Label NLabel;
        private GroupBox OperationsGroup;
        private RadioButton RadioOp3;
        private RadioButton RadioOp2;
        private RadioButton RadioOp1;
        private Button AboutBtn;
        private Button ReadBtn;
        private Button SaveArrBtn;
        private Button SaveOpBtn;
        private Button GenBtn;
        private Button DoOpBtn;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private TextBox KTextBox;
        private Label KLabel;
        private TextBox JTextBox;
        private TextBox ITextBox;
        private Label JLabel;
        private Label ILabel;
    }
}