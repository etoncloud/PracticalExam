namespace PracticalExam
{
    partial class viewcourse
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
            this.dgViewCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewCourse
            // 
            this.dgViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCourse.Location = new System.Drawing.Point(12, 31);
            this.dgViewCourse.Name = "dgViewCourse";
            this.dgViewCourse.Size = new System.Drawing.Size(765, 261);
            this.dgViewCourse.TabIndex = 0;
            // 
            // viewcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.dgViewCourse);
            this.Name = "viewcourse";
            this.Text = "viewcourse";
            this.Load += new System.EventHandler(this.viewcourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewCourse;
    }
}