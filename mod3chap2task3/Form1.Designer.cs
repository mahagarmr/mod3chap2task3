﻿namespace mod3chap2task3
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
            dgvResults = new DataGridView();
            btnCalculate = new Button();
            txtLimit = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 12);
            dgvResults.Name = "dgvResults";
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new Size(271, 426);
            dgvResults.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(305, 70);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(147, 72);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtLimit
            // 
            txtLimit.Location = new Point(305, 12);
            txtLimit.Name = "txtLimit";
            txtLimit.Size = new Size(147, 23);
            txtLimit.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(txtLimit);
            Controls.Add(btnCalculate);
            Controls.Add(dgvResults);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResults;
        private Button btnCalculate;
        private TextBox txtLimit;
    }
}