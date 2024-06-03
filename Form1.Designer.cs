namespace Csharp_phuongtrinhbat1
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
            this.btnphuongtrinhbac1 = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.lplkq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnphuongtrinhbac1
            // 
            this.btnphuongtrinhbac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphuongtrinhbac1.Location = new System.Drawing.Point(244, 348);
            this.btnphuongtrinhbac1.Name = "btnphuongtrinhbac1";
            this.btnphuongtrinhbac1.Size = new System.Drawing.Size(331, 65);
            this.btnphuongtrinhbac1.TabIndex = 0;
            this.btnphuongtrinhbac1.Text = "tính phương trình bậc 1";
            this.btnphuongtrinhbac1.UseVisualStyleBackColor = true;
            this.btnphuongtrinhbac1.Click += new System.EventHandler(this.btnphuongtrinhbac1_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(115, 155);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(134, 37);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "NHẬP a";
            this.lbla.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(285, 152);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(270, 40);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(285, 211);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(270, 40);
            this.txt2.TabIndex = 4;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(116, 218);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(119, 33);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "NHẬP b";
            this.lblb.Click += new System.EventHandler(this.label2_Click);
            // 
            // lplkq
            // 
            this.lplkq.AutoSize = true;
            this.lplkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplkq.Location = new System.Drawing.Point(358, 283);
            this.lplkq.Name = "lplkq";
            this.lplkq.Size = new System.Drawing.Size(114, 33);
            this.lplkq.TabIndex = 5;
            this.lplkq.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "ỨNG DỤNG TÍNH PHƯƠNG TRÌNH BẬC 1: ax + b = 0\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lplkq);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnphuongtrinhbac1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnphuongtrinhbac1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lplkq;
        private System.Windows.Forms.Label label1;
    }
}

