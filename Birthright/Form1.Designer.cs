namespace Birthright
{
    partial class Form1
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
            this.dgvDataViewer = new System.Windows.Forms.DataGridView();
            this.txtFindProvince = new System.Windows.Forms.TextBox();
            this.lbxTest = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataViewer
            // 
            this.dgvDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataViewer.Location = new System.Drawing.Point(12, 12);
            this.dgvDataViewer.Name = "dgvDataViewer";
            this.dgvDataViewer.Size = new System.Drawing.Size(872, 366);
            this.dgvDataViewer.TabIndex = 0;
            // 
            // txtFindProvince
            // 
            this.txtFindProvince.Location = new System.Drawing.Point(124, 401);
            this.txtFindProvince.Name = "txtFindProvince";
            this.txtFindProvince.Size = new System.Drawing.Size(100, 20);
            this.txtFindProvince.TabIndex = 1;
            this.txtFindProvince.TextChanged += new System.EventHandler(this.SearchBoxTyping);
            // 
            // lbxTest
            // 
            this.lbxTest.FormattingEnabled = true;
            this.lbxTest.Location = new System.Drawing.Point(913, 13);
            this.lbxTest.Name = "lbxTest";
            this.lbxTest.Size = new System.Drawing.Size(120, 95);
            this.lbxTest.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(913, 136);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 544);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbxTest);
            this.Controls.Add(this.txtFindProvince);
            this.Controls.Add(this.dgvDataViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataViewer;
        private System.Windows.Forms.TextBox txtFindProvince;
        private System.Windows.Forms.ListBox lbxTest;
        private System.Windows.Forms.Button btnTest;
    }
}

