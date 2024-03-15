namespace Calculater
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
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonSubtrack = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonDat = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonAllClear = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Location = new System.Drawing.Point(22, 120);
            this.ButtonSeven.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(225, 104);
            this.ButtonSeven.TabIndex = 0;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Location = new System.Drawing.Point(258, 120);
            this.ButtonEight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(225, 104);
            this.ButtonEight.TabIndex = 1;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Location = new System.Drawing.Point(494, 120);
            this.ButtonNine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(225, 104);
            this.ButtonNine.TabIndex = 2;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(730, 120);
            this.ButtonDivide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(225, 104);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Location = new System.Drawing.Point(22, 236);
            this.ButtonFour.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(225, 104);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Location = new System.Drawing.Point(258, 236);
            this.ButtonFive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(225, 104);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Location = new System.Drawing.Point(494, 236);
            this.ButtonSix.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(225, 104);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(730, 236);
            this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(225, 104);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Location = new System.Drawing.Point(22, 352);
            this.ButtonOne.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(225, 104);
            this.ButtonOne.TabIndex = 8;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Location = new System.Drawing.Point(258, 352);
            this.ButtonTwo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(225, 104);
            this.ButtonTwo.TabIndex = 9;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Location = new System.Drawing.Point(494, 352);
            this.ButtonThree.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(225, 104);
            this.ButtonThree.TabIndex = 10;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonSubtrack
            // 
            this.ButtonSubtrack.Location = new System.Drawing.Point(730, 352);
            this.ButtonSubtrack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonSubtrack.Name = "ButtonSubtrack";
            this.ButtonSubtrack.Size = new System.Drawing.Size(225, 104);
            this.ButtonSubtrack.TabIndex = 11;
            this.ButtonSubtrack.Text = "-";
            this.ButtonSubtrack.UseVisualStyleBackColor = true;
            this.ButtonSubtrack.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Location = new System.Drawing.Point(22, 468);
            this.ButtonZero.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(225, 104);
            this.ButtonZero.TabIndex = 12;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // ButtonDat
            // 
            this.ButtonDat.Location = new System.Drawing.Point(258, 468);
            this.ButtonDat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonDat.Name = "ButtonDat";
            this.ButtonDat.Size = new System.Drawing.Size(225, 104);
            this.ButtonDat.TabIndex = 13;
            this.ButtonDat.Text = ".";
            this.ButtonDat.UseVisualStyleBackColor = true;
            this.ButtonDat.Click += new System.EventHandler(this.ButtonDat_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Location = new System.Drawing.Point(494, 468);
            this.ButtonResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(225, 104);
            this.ButtonResult.TabIndex = 14;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(730, 468);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(225, 104);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(494, 584);
            this.button18.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(461, 108);
            this.button18.TabIndex = 17;
            this.button18.Text = "저장";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(22, 588);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(225, 104);
            this.ButtonBack.TabIndex = 18;
            this.ButtonBack.Text = "뒤로가기";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonAllClear
            // 
            this.ButtonAllClear.Location = new System.Drawing.Point(258, 588);
            this.ButtonAllClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonAllClear.Name = "ButtonAllClear";
            this.ButtonAllClear.Size = new System.Drawing.Size(225, 104);
            this.ButtonAllClear.TabIndex = 19;
            this.ButtonAllClear.Text = "AC";
            this.ButtonAllClear.UseVisualStyleBackColor = true;
            this.ButtonAllClear.Click += new System.EventHandler(this.ButtonAllCleaar_Click);
            // 
            // Display
            // 
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(977, 114);
            this.Display.TabIndex = 20;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 716);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ButtonAllClear);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ButtonDat);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonSubtrack);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonSeven);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calculator";
            this.Text = "Calculater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonSubtrack;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonDat;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonAllClear;
        private System.Windows.Forms.Label Display;
    }
}

