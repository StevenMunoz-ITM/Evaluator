namespace Evaluator.UI.Windows
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
            btn7 = new Button();
            txtDisplay = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnComma = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnPow = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 24F);
            btn7.Location = new Point(24, 88);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 85);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.InactiveCaption;
            txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(24, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(680, 61);
            txtDisplay.TabIndex = 1;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveCaption;
            btnPlus.Font = new Font("Segoe UI", 24F);
            btnPlus.Location = new Point(318, 179);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(92, 85);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ActiveCaption;
            btnMinus.Font = new Font("Segoe UI", 24F);
            btnMinus.Location = new Point(416, 179);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(92, 85);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ActiveCaption;
            btnMultiply.Font = new Font("Segoe UI", 24F);
            btnMultiply.Location = new Point(416, 88);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(92, 85);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Font = new Font("Segoe UI", 24F);
            btnDivide.Location = new Point(318, 88);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(92, 85);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnComma
            // 
            btnComma.Font = new Font("Segoe UI", 24F);
            btnComma.Location = new Point(220, 361);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(92, 85);
            btnComma.TabIndex = 6;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnDot_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 24F);
            btn3.Location = new Point(220, 270);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 85);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 24F);
            btn6.Location = new Point(220, 179);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 85);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 24F);
            btn9.Location = new Point(220, 88);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 85);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 24F);
            btn5.Location = new Point(122, 179);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 85);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 24F);
            btn8.Location = new Point(122, 88);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 85);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 24F);
            btn2.Location = new Point(122, 270);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 85);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 24F);
            btn0.Location = new Point(24, 361);
            btn0.Name = "btn0";
            btn0.Size = new Size(190, 85);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 24F);
            btn1.Location = new Point(24, 270);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 85);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 24F);
            btn4.Location = new Point(24, 179);
            btn4.Name = "btn4";
            btn4.Size = new Size(92, 85);
            btn4.TabIndex = 15;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Font = new Font("Segoe UI", 24F);
            btnDelete.Location = new Point(514, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 85);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI", 24F);
            btnClear.Location = new Point(514, 179);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 85);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = SystemColors.ActiveCaption;
            btnPow.Font = new Font("Segoe UI", 24F);
            btnPow.Location = new Point(514, 270);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(190, 85);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = SystemColors.ActiveCaption;
            btnOpenParenthesis.Font = new Font("Segoe UI", 24F);
            btnOpenParenthesis.Location = new Point(318, 270);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(92, 85);
            btnOpenParenthesis.TabIndex = 19;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = SystemColors.ActiveCaption;
            btnCloseParenthesis.Font = new Font("Segoe UI", 24F);
            btnCloseParenthesis.Location = new Point(416, 270);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(92, 85);
            btnCloseParenthesis.TabIndex = 20;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = SystemColors.ActiveCaption;
            btnResult.Font = new Font("Segoe UI", 24F);
            btnResult.Location = new Point(318, 361);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(386, 85);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(718, 458);
            Controls.Add(btnResult);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btnComma);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtDisplay);
            Controls.Add(btn7);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Expression Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private TextBox txtDisplay;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnComma;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btn5;
        private Button btn8;
        private Button btn2;
        private Button btn0;
        private Button btn1;
        private Button btn4;
        private Button btnDelete;
        private Button btnClear;
        private Button btnPow;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnResult;
    }
}
