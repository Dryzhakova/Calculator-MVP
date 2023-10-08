namespace calc
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textdisplay2 = new Label();
            textdisplay1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonEqual = new Button();
            buttonComa = new Button();
            button0 = new Button();
            buttonAddSubsc = new Button();
            buttonAddition = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonSubsc = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonMult = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonDivision = new Button();
            buttonDelLast = new Button();
            buttonCE = new Button();
            buttoncClearAll = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textdisplay2, 0, 0);
            tableLayoutPanel1.Controls.Add(textdisplay1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(346, 537);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textdisplay2
            // 
            textdisplay2.AutoSize = true;
            textdisplay2.Dock = DockStyle.Top;
            textdisplay2.Location = new Point(3, 0);
            textdisplay2.Name = "textdisplay2";
            textdisplay2.Size = new Size(340, 20);
            textdisplay2.TabIndex = 0;
            textdisplay2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textdisplay1
            // 
            textdisplay1.Dock = DockStyle.Fill;
            textdisplay1.Font = new Font("Gadugi", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textdisplay1.Location = new Point(3, 51);
            textdisplay1.Name = "textdisplay1";
            textdisplay1.Size = new Size(340, 43);
            textdisplay1.TabIndex = 1;
            textdisplay1.Text = "0";
            textdisplay1.TextAlign = HorizontalAlignment.Right;
            textdisplay1.Click += ButtonMathOperation;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(buttonEqual, 3, 4);
            tableLayoutPanel2.Controls.Add(buttonComa, 2, 4);
            tableLayoutPanel2.Controls.Add(button0, 1, 4);
            tableLayoutPanel2.Controls.Add(buttonAddSubsc, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonAddition, 3, 3);
            tableLayoutPanel2.Controls.Add(button3, 2, 3);
            tableLayoutPanel2.Controls.Add(button2, 1, 3);
            tableLayoutPanel2.Controls.Add(button1, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonSubsc, 3, 2);
            tableLayoutPanel2.Controls.Add(button6, 2, 2);
            tableLayoutPanel2.Controls.Add(button5, 1, 2);
            tableLayoutPanel2.Controls.Add(button4, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonMult, 3, 1);
            tableLayoutPanel2.Controls.Add(button9, 2, 1);
            tableLayoutPanel2.Controls.Add(button8, 1, 1);
            tableLayoutPanel2.Controls.Add(button7, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonDivision, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonDelLast, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonCE, 1, 0);
            tableLayoutPanel2.Controls.Add(buttoncClearAll, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 110);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(340, 424);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.ControlDarkDark;
            buttonEqual.Dock = DockStyle.Fill;
            buttonEqual.FlatAppearance.BorderSize = 0;
            buttonEqual.FlatStyle = FlatStyle.Flat;
            buttonEqual.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEqual.Location = new Point(258, 339);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(79, 82);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonComa
            // 
            buttonComa.BackColor = SystemColors.ControlDarkDark;
            buttonComa.Dock = DockStyle.Fill;
            buttonComa.FlatAppearance.BorderSize = 0;
            buttonComa.FlatStyle = FlatStyle.Flat;
            buttonComa.Font = new Font("Gadugi", 5F, FontStyle.Bold, GraphicsUnit.Point);
            buttonComa.ForeColor = SystemColors.ControlText;
            buttonComa.Image = (Image)resources.GetObject("buttonComa.Image");
            buttonComa.Location = new Point(173, 339);
            buttonComa.Name = "buttonComa";
            buttonComa.Size = new Size(79, 82);
            buttonComa.TabIndex = 18;
            buttonComa.Text = ",";
            buttonComa.UseVisualStyleBackColor = false;
            buttonComa.Click += ButNumbers_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlDark;
            button0.Dock = DockStyle.Fill;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(88, 339);
            button0.Name = "button0";
            button0.Size = new Size(79, 82);
            button0.TabIndex = 17;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += ButNumbers_Click;
            // 
            // buttonAddSubsc
            // 
            buttonAddSubsc.BackColor = SystemColors.ControlDarkDark;
            buttonAddSubsc.Dock = DockStyle.Fill;
            buttonAddSubsc.FlatAppearance.BorderSize = 0;
            buttonAddSubsc.FlatStyle = FlatStyle.Flat;
            buttonAddSubsc.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddSubsc.Location = new Point(3, 339);
            buttonAddSubsc.Name = "buttonAddSubsc";
            buttonAddSubsc.Size = new Size(79, 82);
            buttonAddSubsc.TabIndex = 16;
            buttonAddSubsc.Text = "+/-";
            buttonAddSubsc.UseVisualStyleBackColor = false;
            buttonAddSubsc.Click += buttonAddSubsc_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.BackColor = SystemColors.ControlDarkDark;
            buttonAddition.Dock = DockStyle.Fill;
            buttonAddition.FlatAppearance.BorderSize = 0;
            buttonAddition.FlatStyle = FlatStyle.Flat;
            buttonAddition.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddition.Location = new Point(258, 255);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(79, 78);
            buttonAddition.TabIndex = 15;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = false;
            buttonAddition.Click += ButtonMathOperation;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(173, 255);
            button3.Name = "button3";
            button3.Size = new Size(79, 78);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ButNumbers_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(88, 255);
            button2.Name = "button2";
            button2.Size = new Size(79, 78);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ButNumbers_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 255);
            button1.Name = "button1";
            button1.Size = new Size(79, 78);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButNumbers_Click;
            // 
            // buttonSubsc
            // 
            buttonSubsc.BackColor = SystemColors.ControlDarkDark;
            buttonSubsc.Dock = DockStyle.Fill;
            buttonSubsc.FlatAppearance.BorderSize = 0;
            buttonSubsc.FlatStyle = FlatStyle.Flat;
            buttonSubsc.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubsc.Location = new Point(258, 171);
            buttonSubsc.Name = "buttonSubsc";
            buttonSubsc.Size = new Size(79, 78);
            buttonSubsc.TabIndex = 11;
            buttonSubsc.Text = "-";
            buttonSubsc.UseVisualStyleBackColor = false;
            buttonSubsc.Click += ButtonMathOperation;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(173, 171);
            button6.Name = "button6";
            button6.Size = new Size(79, 78);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += ButNumbers_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(88, 171);
            button5.Name = "button5";
            button5.Size = new Size(79, 78);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += ButNumbers_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(3, 171);
            button4.Name = "button4";
            button4.Size = new Size(79, 78);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += ButNumbers_Click;
            // 
            // buttonMult
            // 
            buttonMult.BackColor = SystemColors.ControlDarkDark;
            buttonMult.Dock = DockStyle.Fill;
            buttonMult.FlatAppearance.BorderSize = 0;
            buttonMult.FlatStyle = FlatStyle.Flat;
            buttonMult.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMult.Location = new Point(258, 87);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(79, 78);
            buttonMult.TabIndex = 7;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = false;
            buttonMult.Click += ButtonMathOperation;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDark;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(173, 87);
            button9.Name = "button9";
            button9.Size = new Size(79, 78);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += ButNumbers_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDark;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(88, 87);
            button8.Name = "button8";
            button8.Size = new Size(79, 78);
            button8.TabIndex = 5;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += ButNumbers_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDark;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(3, 87);
            button7.Name = "button7";
            button7.Size = new Size(79, 78);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += ButNumbers_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = SystemColors.ControlDarkDark;
            buttonDivision.Dock = DockStyle.Fill;
            buttonDivision.FlatAppearance.BorderSize = 0;
            buttonDivision.FlatStyle = FlatStyle.Flat;
            buttonDivision.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDivision.Location = new Point(258, 3);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(79, 78);
            buttonDivision.TabIndex = 3;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += ButtonMathOperation;
            // 
            // buttonDelLast
            // 
            buttonDelLast.BackColor = SystemColors.ControlDarkDark;
            buttonDelLast.Dock = DockStyle.Fill;
            buttonDelLast.FlatAppearance.BorderSize = 0;
            buttonDelLast.FlatStyle = FlatStyle.Flat;
            buttonDelLast.Font = new Font("Gadugi", 5F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelLast.Image = (Image)resources.GetObject("buttonDelLast.Image");
            buttonDelLast.Location = new Point(173, 3);
            buttonDelLast.Name = "buttonDelLast";
            buttonDelLast.Size = new Size(79, 78);
            buttonDelLast.TabIndex = 2;
            buttonDelLast.UseVisualStyleBackColor = false;
            buttonDelLast.Click += buttonDelLast_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = SystemColors.ControlDarkDark;
            buttonCE.Dock = DockStyle.Fill;
            buttonCE.FlatAppearance.BorderSize = 0;
            buttonCE.FlatStyle = FlatStyle.Flat;
            buttonCE.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCE.Location = new Point(88, 3);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(79, 78);
            buttonCE.TabIndex = 1;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttoncClearAll
            // 
            buttoncClearAll.BackColor = SystemColors.ControlDarkDark;
            buttoncClearAll.Dock = DockStyle.Fill;
            buttoncClearAll.FlatAppearance.BorderSize = 0;
            buttoncClearAll.FlatStyle = FlatStyle.Flat;
            buttoncClearAll.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncClearAll.Location = new Point(3, 3);
            buttoncClearAll.Name = "buttoncClearAll";
            buttoncClearAll.Size = new Size(79, 78);
            buttoncClearAll.TabIndex = 0;
            buttoncClearAll.Text = "C";
            buttoncClearAll.UseVisualStyleBackColor = false;
            buttoncClearAll.Click += buttoncClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 537);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label textdisplay2;
        private TextBox textdisplay1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonEqual;
        private Button buttonComa;
        private Button button0;
        private Button buttonAddSubsc;
        private Button buttonAddition;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonSubsc;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonMult;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonDivision;
        private Button buttonDelLast;
        private Button buttonCE;
        private Button buttoncClearAll;
    }
}