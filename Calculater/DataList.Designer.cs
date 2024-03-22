namespace Calculater
{
    partial class DataList
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Result");
            this.ListData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListData
            // 
            this.ListData.HideSelection = false;
            this.ListData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListData.Location = new System.Drawing.Point(134, 108);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(528, 159);
            this.ListData.TabIndex = 1;
            this.ListData.UseCompatibleStateImageBehavior = false;
            this.ListData.View = System.Windows.Forms.View.List;
            this.ListData.SelectedIndexChanged += new System.EventHandler(this.ListData_SelectedIndexChanged);
            // 
            // DataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 948);
            this.Controls.Add(this.ListData);
            this.Name = "DataList";
            this.Text = "DataList";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ListData;
    }
}