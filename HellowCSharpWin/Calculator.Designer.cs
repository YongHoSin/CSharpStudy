namespace HellowCSharpWin
{
    partial class Calculator
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
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumPlus = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumButton1 = new System.Windows.Forms.Button();
            this.Numbutton4 = new System.Windows.Forms.Button();
            this.Numbutton5 = new System.Windows.Forms.Button();
            this.Numbutton6 = new System.Windows.Forms.Button();
            this.Numbutton7 = new System.Windows.Forms.Button();
            this.Numbutton8 = new System.Windows.Forms.Button();
            this.Numbutton9 = new System.Windows.Forms.Button();
            this.Numbutton0 = new System.Windows.Forms.Button();
            this.NumMinus = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(45, 9);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(454, 59);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(431, 75);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(67, 54);
            this.NumPlus.TabIndex = 3;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(240, 71);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(67, 61);
            this.NumButton3.TabIndex = 4;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(143, 74);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(64, 58);
            this.NumButton2.TabIndex = 5;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(48, 75);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(64, 56);
            this.NumButton1.TabIndex = 6;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton4
            // 
            this.Numbutton4.Location = new System.Drawing.Point(48, 143);
            this.Numbutton4.Name = "Numbutton4";
            this.Numbutton4.Size = new System.Drawing.Size(63, 58);
            this.Numbutton4.TabIndex = 7;
            this.Numbutton4.Text = "4";
            this.Numbutton4.UseVisualStyleBackColor = true;
            this.Numbutton4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton5
            // 
            this.Numbutton5.Location = new System.Drawing.Point(143, 143);
            this.Numbutton5.Name = "Numbutton5";
            this.Numbutton5.Size = new System.Drawing.Size(63, 59);
            this.Numbutton5.TabIndex = 8;
            this.Numbutton5.Text = "5";
            this.Numbutton5.UseVisualStyleBackColor = true;
            this.Numbutton5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton6
            // 
            this.Numbutton6.Location = new System.Drawing.Point(240, 143);
            this.Numbutton6.Name = "Numbutton6";
            this.Numbutton6.Size = new System.Drawing.Size(67, 58);
            this.Numbutton6.TabIndex = 9;
            this.Numbutton6.Text = "6";
            this.Numbutton6.UseVisualStyleBackColor = true;
            this.Numbutton6.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton7
            // 
            this.Numbutton7.Location = new System.Drawing.Point(48, 213);
            this.Numbutton7.Name = "Numbutton7";
            this.Numbutton7.Size = new System.Drawing.Size(63, 55);
            this.Numbutton7.TabIndex = 10;
            this.Numbutton7.Text = "7";
            this.Numbutton7.UseVisualStyleBackColor = true;
            this.Numbutton7.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton8
            // 
            this.Numbutton8.Location = new System.Drawing.Point(144, 213);
            this.Numbutton8.Name = "Numbutton8";
            this.Numbutton8.Size = new System.Drawing.Size(63, 55);
            this.Numbutton8.TabIndex = 11;
            this.Numbutton8.Text = "8";
            this.Numbutton8.UseVisualStyleBackColor = true;
            this.Numbutton8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton9
            // 
            this.Numbutton9.Location = new System.Drawing.Point(240, 213);
            this.Numbutton9.Name = "Numbutton9";
            this.Numbutton9.Size = new System.Drawing.Size(67, 55);
            this.Numbutton9.TabIndex = 12;
            this.Numbutton9.Text = "9";
            this.Numbutton9.UseVisualStyleBackColor = true;
            this.Numbutton9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // Numbutton0
            // 
            this.Numbutton0.Location = new System.Drawing.Point(134, 274);
            this.Numbutton0.Name = "Numbutton0";
            this.Numbutton0.Size = new System.Drawing.Size(84, 39);
            this.Numbutton0.TabIndex = 13;
            this.Numbutton0.Text = "0";
            this.Numbutton0.UseVisualStyleBackColor = true;
            this.Numbutton0.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumMinus
            // 
            this.NumMinus.Location = new System.Drawing.Point(432, 147);
            this.NumMinus.Name = "NumMinus";
            this.NumMinus.Size = new System.Drawing.Size(65, 54);
            this.NumMinus.TabIndex = 14;
            this.NumMinus.Text = "-";
            this.NumMinus.UseVisualStyleBackColor = true;
            this.NumMinus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(347, 75);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(65, 54);
            this.NumClear.TabIndex = 15;
            this.NumClear.Text = "C";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.NumMinus);
            this.Controls.Add(this.Numbutton0);
            this.Controls.Add(this.Numbutton9);
            this.Controls.Add(this.Numbutton8);
            this.Controls.Add(this.Numbutton7);
            this.Controls.Add(this.Numbutton6);
            this.Controls.Add(this.Numbutton5);
            this.Controls.Add(this.Numbutton4);
            this.Controls.Add(this.NumButton1);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumScreen);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumPlus;
        private System.Windows.Forms.Button NumButton3;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button Numbutton4;
        private System.Windows.Forms.Button Numbutton5;
        private System.Windows.Forms.Button Numbutton6;
        private System.Windows.Forms.Button Numbutton7;
        private System.Windows.Forms.Button Numbutton8;
        private System.Windows.Forms.Button Numbutton9;
        private System.Windows.Forms.Button Numbutton0;
        private System.Windows.Forms.Button NumMinus;
        private System.Windows.Forms.Button NumClear;
        private System.Windows.Forms.Button button1;
    }
}

