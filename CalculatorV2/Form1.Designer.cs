namespace CalculatorV2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnOpClear = new System.Windows.Forms.Button();
            this.btnOpBrakets = new System.Windows.Forms.Button();
            this.btnOpPercent = new System.Windows.Forms.Button();
            this.btnOpDivision = new System.Windows.Forms.Button();
            this.btnOpPlus = new System.Windows.Forms.Button();
            this.btnDight6 = new System.Windows.Forms.Button();
            this.btnDight5 = new System.Windows.Forms.Button();
            this.btnDight4 = new System.Windows.Forms.Button();
            this.btnOpMinus = new System.Windows.Forms.Button();
            this.btnDight3 = new System.Windows.Forms.Button();
            this.btnDight2 = new System.Windows.Forms.Button();
            this.btnDight1 = new System.Windows.Forms.Button();
            this.btnOpResult = new System.Windows.Forms.Button();
            this.btnDightDot = new System.Windows.Forms.Button();
            this.btnDight0 = new System.Windows.Forms.Button();
            this.btnDigitSigns = new System.Windows.Forms.Button();
            this.btnOpMultiple = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAnswer.Location = new System.Drawing.Point(26, 31);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(574, 50);
            this.tbAnswer.TabIndex = 0;
            this.tbAnswer.Text = "0";
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpClear
            // 
            this.btnOpClear.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpClear.Location = new System.Drawing.Point(26, 88);
            this.btnOpClear.Name = "btnOpClear";
            this.btnOpClear.Size = new System.Drawing.Size(139, 99);
            this.btnOpClear.TabIndex = 1;
            this.btnOpClear.Text = "C";
            this.btnOpClear.UseVisualStyleBackColor = true;
            this.btnOpClear.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnOpBrakets
            // 
            this.btnOpBrakets.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpBrakets.Location = new System.Drawing.Point(171, 88);
            this.btnOpBrakets.Name = "btnOpBrakets";
            this.btnOpBrakets.Size = new System.Drawing.Size(139, 99);
            this.btnOpBrakets.TabIndex = 2;
            this.btnOpBrakets.Text = "( )";
            this.btnOpBrakets.UseVisualStyleBackColor = true;
            this.btnOpBrakets.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnOpPercent
            // 
            this.btnOpPercent.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpPercent.Location = new System.Drawing.Point(316, 88);
            this.btnOpPercent.Name = "btnOpPercent";
            this.btnOpPercent.Size = new System.Drawing.Size(139, 99);
            this.btnOpPercent.TabIndex = 3;
            this.btnOpPercent.Text = "%";
            this.btnOpPercent.UseVisualStyleBackColor = true;
            this.btnOpPercent.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnOpDivision
            // 
            this.btnOpDivision.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpDivision.Location = new System.Drawing.Point(461, 88);
            this.btnOpDivision.Name = "btnOpDivision";
            this.btnOpDivision.Size = new System.Drawing.Size(139, 99);
            this.btnOpDivision.TabIndex = 4;
            this.btnOpDivision.Text = "/";
            this.btnOpDivision.UseVisualStyleBackColor = true;
            this.btnOpDivision.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnOpPlus
            // 
            this.btnOpPlus.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpPlus.Location = new System.Drawing.Point(461, 298);
            this.btnOpPlus.Name = "btnOpPlus";
            this.btnOpPlus.Size = new System.Drawing.Size(139, 99);
            this.btnOpPlus.TabIndex = 8;
            this.btnOpPlus.Text = "+";
            this.btnOpPlus.UseVisualStyleBackColor = true;
            this.btnOpPlus.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnDight6
            // 
            this.btnDight6.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight6.Location = new System.Drawing.Point(316, 298);
            this.btnDight6.Name = "btnDight6";
            this.btnDight6.Size = new System.Drawing.Size(139, 99);
            this.btnDight6.TabIndex = 7;
            this.btnDight6.Text = "6";
            this.btnDight6.UseVisualStyleBackColor = true;
            this.btnDight6.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDight5
            // 
            this.btnDight5.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight5.Location = new System.Drawing.Point(171, 298);
            this.btnDight5.Name = "btnDight5";
            this.btnDight5.Size = new System.Drawing.Size(139, 99);
            this.btnDight5.TabIndex = 6;
            this.btnDight5.Text = "5";
            this.btnDight5.UseVisualStyleBackColor = true;
            this.btnDight5.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDight4
            // 
            this.btnDight4.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight4.Location = new System.Drawing.Point(26, 298);
            this.btnDight4.Name = "btnDight4";
            this.btnDight4.Size = new System.Drawing.Size(139, 99);
            this.btnDight4.TabIndex = 5;
            this.btnDight4.Text = "4";
            this.btnDight4.UseVisualStyleBackColor = true;
            this.btnDight4.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnOpMinus
            // 
            this.btnOpMinus.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpMinus.Location = new System.Drawing.Point(461, 403);
            this.btnOpMinus.Name = "btnOpMinus";
            this.btnOpMinus.Size = new System.Drawing.Size(139, 99);
            this.btnOpMinus.TabIndex = 12;
            this.btnOpMinus.Text = "-";
            this.btnOpMinus.UseVisualStyleBackColor = true;
            this.btnOpMinus.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnDight3
            // 
            this.btnDight3.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight3.Location = new System.Drawing.Point(316, 403);
            this.btnDight3.Name = "btnDight3";
            this.btnDight3.Size = new System.Drawing.Size(139, 99);
            this.btnDight3.TabIndex = 11;
            this.btnDight3.Text = "3";
            this.btnDight3.UseVisualStyleBackColor = true;
            this.btnDight3.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDight2
            // 
            this.btnDight2.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight2.Location = new System.Drawing.Point(171, 403);
            this.btnDight2.Name = "btnDight2";
            this.btnDight2.Size = new System.Drawing.Size(139, 99);
            this.btnDight2.TabIndex = 10;
            this.btnDight2.Text = "2";
            this.btnDight2.UseVisualStyleBackColor = true;
            this.btnDight2.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDight1
            // 
            this.btnDight1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight1.Location = new System.Drawing.Point(26, 403);
            this.btnDight1.Name = "btnDight1";
            this.btnDight1.Size = new System.Drawing.Size(139, 99);
            this.btnDight1.TabIndex = 9;
            this.btnDight1.Text = "1";
            this.btnDight1.UseVisualStyleBackColor = true;
            this.btnDight1.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnOpResult
            // 
            this.btnOpResult.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpResult.Location = new System.Drawing.Point(461, 508);
            this.btnOpResult.Name = "btnOpResult";
            this.btnOpResult.Size = new System.Drawing.Size(139, 99);
            this.btnOpResult.TabIndex = 16;
            this.btnOpResult.Text = "=";
            this.btnOpResult.UseVisualStyleBackColor = true;
            this.btnOpResult.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnDightDot
            // 
            this.btnDightDot.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDightDot.Location = new System.Drawing.Point(316, 508);
            this.btnDightDot.Name = "btnDightDot";
            this.btnDightDot.Size = new System.Drawing.Size(139, 99);
            this.btnDightDot.TabIndex = 15;
            this.btnDightDot.Text = ".";
            this.btnDightDot.UseVisualStyleBackColor = true;
            this.btnDightDot.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDight0
            // 
            this.btnDight0.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDight0.Location = new System.Drawing.Point(171, 508);
            this.btnDight0.Name = "btnDight0";
            this.btnDight0.Size = new System.Drawing.Size(139, 99);
            this.btnDight0.TabIndex = 14;
            this.btnDight0.Text = "0";
            this.btnDight0.UseVisualStyleBackColor = true;
            this.btnDight0.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigitSigns
            // 
            this.btnDigitSigns.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDigitSigns.Location = new System.Drawing.Point(26, 508);
            this.btnDigitSigns.Name = "btnDigitSigns";
            this.btnDigitSigns.Size = new System.Drawing.Size(139, 99);
            this.btnDigitSigns.TabIndex = 13;
            this.btnDigitSigns.Text = "+/-";
            this.btnDigitSigns.UseVisualStyleBackColor = true;
            this.btnDigitSigns.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnOpMultiple
            // 
            this.btnOpMultiple.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpMultiple.Location = new System.Drawing.Point(461, 193);
            this.btnOpMultiple.Name = "btnOpMultiple";
            this.btnOpMultiple.Size = new System.Drawing.Size(139, 99);
            this.btnOpMultiple.TabIndex = 20;
            this.btnOpMultiple.Text = "*";
            this.btnOpMultiple.UseVisualStyleBackColor = true;
            this.btnOpMultiple.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnDigit9
            // 
            this.btnDigit9.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDigit9.Location = new System.Drawing.Point(316, 193);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(139, 99);
            this.btnDigit9.TabIndex = 19;
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = true;
            this.btnDigit9.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit8
            // 
            this.btnDigit8.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDigit8.Location = new System.Drawing.Point(171, 193);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(139, 99);
            this.btnDigit8.TabIndex = 18;
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = true;
            this.btnDigit8.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // btnDigit7
            // 
            this.btnDigit7.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDigit7.Location = new System.Drawing.Point(26, 193);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(139, 99);
            this.btnDigit7.TabIndex = 17;
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = true;
            this.btnDigit7.Click += new System.EventHandler(this.btnDigit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 641);
            this.Controls.Add(this.btnOpMultiple);
            this.Controls.Add(this.btnDigit9);
            this.Controls.Add(this.btnDigit8);
            this.Controls.Add(this.btnDigit7);
            this.Controls.Add(this.btnOpResult);
            this.Controls.Add(this.btnDightDot);
            this.Controls.Add(this.btnDight0);
            this.Controls.Add(this.btnDigitSigns);
            this.Controls.Add(this.btnOpMinus);
            this.Controls.Add(this.btnDight3);
            this.Controls.Add(this.btnDight2);
            this.Controls.Add(this.btnDight1);
            this.Controls.Add(this.btnOpPlus);
            this.Controls.Add(this.btnDight6);
            this.Controls.Add(this.btnDight5);
            this.Controls.Add(this.btnDight4);
            this.Controls.Add(this.btnOpDivision);
            this.Controls.Add(this.btnOpPercent);
            this.Controls.Add(this.btnOpBrakets);
            this.Controls.Add(this.btnOpClear);
            this.Controls.Add(this.tbAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btnOp_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnOpClear;
        private System.Windows.Forms.Button btnOpBrakets;
        private System.Windows.Forms.Button btnOpPercent;
        private System.Windows.Forms.Button btnOpDivision;
        private System.Windows.Forms.Button btnOpPlus;
        private System.Windows.Forms.Button btnDight6;
        private System.Windows.Forms.Button btnDight5;
        private System.Windows.Forms.Button btnDight4;
        private System.Windows.Forms.Button btnOpMinus;
        private System.Windows.Forms.Button btnDight3;
        private System.Windows.Forms.Button btnDight2;
        private System.Windows.Forms.Button btnDight1;
        private System.Windows.Forms.Button btnOpResult;
        private System.Windows.Forms.Button btnDightDot;
        private System.Windows.Forms.Button btnDight0;
        private System.Windows.Forms.Button btnDigitSigns;
        private System.Windows.Forms.Button btnOpMultiple;
        private System.Windows.Forms.Button btnDigit9;
        private System.Windows.Forms.Button btnDigit8;
        private System.Windows.Forms.Button btnDigit7;
    }
}

