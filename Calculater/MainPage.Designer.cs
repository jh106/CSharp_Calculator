namespace Calculater
{
    partial class MainPage
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
            this.goCalc = new System.Windows.Forms.Button();
            this.ResultValue = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Button();
            this.Exel = new System.Windows.Forms.Button();
            this.DataBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goCalc
            // 
            this.goCalc.Location = new System.Drawing.Point(12, 578);
            this.goCalc.Name = "goCalc";
            this.goCalc.Size = new System.Drawing.Size(588, 196);
            this.goCalc.TabIndex = 0;
            this.goCalc.Text = "계산기";
            this.goCalc.UseVisualStyleBackColor = true;
            this.goCalc.Click += new System.EventHandler(this.NavCalc);
            // 
            // ResultValue
            // 
            this.ResultValue.AutoSize = true;
            this.ResultValue.Font = new System.Drawing.Font("굴림", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultValue.Location = new System.Drawing.Point(611, 309);
            this.ResultValue.MaximumSize = new System.Drawing.Size(300, 300);
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.Size = new System.Drawing.Size(182, 53);
            this.ResultValue.TabIndex = 1;
            this.ResultValue.Text = "결과값";
            this.ResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultValue.UseWaitCursor = true;
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(606, 578);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(266, 196);
            this.Text.TabIndex = 2;
            this.Text.Text = "Text저장";
            this.Text.UseVisualStyleBackColor = true;
            //this.Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // Exel
            // 
            this.Exel.Location = new System.Drawing.Point(878, 578);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(266, 196);
            this.Exel.TabIndex = 3;
            this.Exel.Text = "Exel저장";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // DataBase
            // 
            this.DataBase.Location = new System.Drawing.Point(1150, 578);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(266, 196);
            this.DataBase.TabIndex = 4;
            this.DataBase.Text = "DB저장";
            this.DataBase.UseVisualStyleBackColor = true;
            this.DataBase.Click += new System.EventHandler(this.DataBase_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 786);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.Exel);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.goCalc);
            this.Name = "MainPage";
            //this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goCalc;
        private System.Windows.Forms.Label ResultValue;
        private System.Windows.Forms.Button Text;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.Button DataBase;
    }
}