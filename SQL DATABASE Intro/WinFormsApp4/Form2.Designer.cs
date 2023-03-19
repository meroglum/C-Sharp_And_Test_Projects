namespace WinFormsApp4
{
    partial class Form2
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCategaoryName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.btnExecuteReader = new System.Windows.Forms.Button();
            this.btnExecuteProcedure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(134, 33);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(194, 27);
            this.txtCategoryName.TabIndex = 0;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(380, 33);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(194, 27);
            this.txtYear.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 88);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(776, 311);
            this.txtResult.TabIndex = 2;
            // 
            // lblCategaoryName
            // 
            this.lblCategaoryName.AutoSize = true;
            this.lblCategaoryName.Location = new System.Drawing.Point(12, 36);
            this.lblCategaoryName.Name = "lblCategaoryName";
            this.lblCategaoryName.Size = new System.Drawing.Size(116, 20);
            this.lblCategaoryName.TabIndex = 3;
            this.lblCategaoryName.Text = "Category Name:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(334, 36);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 20);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(591, 32);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(94, 29);
            this.btnGetReport.TabIndex = 5;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(694, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(12, 409);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(190, 29);
            this.btnExecuteScalar.TabIndex = 7;
            this.btnExecuteScalar.Text = "Execute Scalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            this.btnExecuteScalar.Click += new System.EventHandler(this.btnExecuteScalar_Click);
            // 
            // btnExecuteReader
            // 
            this.btnExecuteReader.Location = new System.Drawing.Point(208, 409);
            this.btnExecuteReader.Name = "btnExecuteReader";
            this.btnExecuteReader.Size = new System.Drawing.Size(190, 29);
            this.btnExecuteReader.TabIndex = 8;
            this.btnExecuteReader.Text = "Execute Reader";
            this.btnExecuteReader.UseVisualStyleBackColor = true;
            this.btnExecuteReader.Click += new System.EventHandler(this.btnExecuteReader_Click);
            // 
            // btnExecuteProcedure
            // 
            this.btnExecuteProcedure.Location = new System.Drawing.Point(404, 409);
            this.btnExecuteProcedure.Name = "btnExecuteProcedure";
            this.btnExecuteProcedure.Size = new System.Drawing.Size(190, 29);
            this.btnExecuteProcedure.TabIndex = 9;
            this.btnExecuteProcedure.Text = "Execute Procedure";
            this.btnExecuteProcedure.UseVisualStyleBackColor = true;
            this.btnExecuteProcedure.Click += new System.EventHandler(this.btnExecuteProcedure_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExecuteProcedure);
            this.Controls.Add(this.btnExecuteReader);
            this.Controls.Add(this.btnExecuteScalar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCategaoryName);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCategoryName;
        private TextBox txtYear;
        private TextBox txtResult;
        private Label lblCategaoryName;
        private Label lblYear;
        private Button btnGetReport;
        private Button btnClear;
        private Button btnExecuteScalar;
        private Button btnExecuteReader;
        private Button btnExecuteProcedure;
    }
}