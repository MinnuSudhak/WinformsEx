namespace ExampleProject
{
    partial class SquareCalcForm
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnFindSum = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(0, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1269, 87);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Square Calc";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFindSum
            // 
            this.btnFindSum.Location = new System.Drawing.Point(369, 276);
            this.btnFindSum.Name = "btnFindSum";
            this.btnFindSum.Size = new System.Drawing.Size(261, 43);
            this.btnFindSum.TabIndex = 14;
            this.btnFindSum.Text = "Find Sum";
            this.btnFindSum.UseVisualStyleBackColor = true;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(378, 185);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(261, 32);
            this.txtSum.TabIndex = 13;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(203, 188);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(51, 16);
            this.lblSum.TabIndex = 12;
            this.lblSum.Text = "Square";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(378, 112);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(261, 22);
            this.txtNumber1.TabIndex = 9;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(173, 107);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(112, 25);
            this.lblNumber1.TabIndex = 8;
            this.lblNumber1.Text = "Number 1";
            // 
            // SquareCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 713);
            this.Controls.Add(this.btnFindSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lbltitle);
            this.Name = "SquareCalcForm";
            this.Text = "Square Calc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SquareCalcForm_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SquareCalcForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnFindSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblNumber1;
    }
}