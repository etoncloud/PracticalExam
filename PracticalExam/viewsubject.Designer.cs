namespace PracticalExam
{
    partial class viewsubject
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
            this.dgViewSubject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewSubject
            // 
            this.dgViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSubject.Location = new System.Drawing.Point(12, 21);
            this.dgViewSubject.Name = "dgViewSubject";
            this.dgViewSubject.Size = new System.Drawing.Size(639, 207);
            this.dgViewSubject.TabIndex = 0;
            // 
            // viewsubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 251);
            this.Controls.Add(this.dgViewSubject);
            this.Name = "viewsubject";
            this.Text = "viewsubject";
            this.Load += new System.EventHandler(this.viewsubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewSubject;
    }
}