
namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SSC_Update_Btn = new System.Windows.Forms.Button();
            this.SSC_Label = new System.Windows.Forms.Label();
            this.HSCLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SSC_Validation_Label = new System.Windows.Forms.Label();
            this.HSC_Validation_Label = new System.Windows.Forms.Label();
            this.Label_Insert_Payment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(49, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seat No ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SSC_Update_Btn
            // 
            this.SSC_Update_Btn.Location = new System.Drawing.Point(166, 160);
            this.SSC_Update_Btn.Name = "SSC_Update_Btn";
            this.SSC_Update_Btn.Size = new System.Drawing.Size(75, 23);
            this.SSC_Update_Btn.TabIndex = 2;
            this.SSC_Update_Btn.Text = "Update";
            this.SSC_Update_Btn.UseVisualStyleBackColor = true;
            this.SSC_Update_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SSC_Label
            // 
            this.SSC_Label.AutoSize = true;
            this.SSC_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSC_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SSC_Label.Location = new System.Drawing.Point(189, 46);
            this.SSC_Label.Name = "SSC_Label";
            this.SSC_Label.Size = new System.Drawing.Size(38, 17);
            this.SSC_Label.TabIndex = 3;
            this.SSC_Label.Text = "SSC";
            // 
            // HSCLabel
            // 
            this.HSCLabel.AutoSize = true;
            this.HSCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSCLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HSCLabel.Location = new System.Drawing.Point(649, 46);
            this.HSCLabel.Name = "HSCLabel";
            this.HSCLabel.Size = new System.Drawing.Size(39, 17);
            this.HSCLabel.TabIndex = 4;
            this.HSCLabel.Text = "HSC";
            this.HSCLabel.Click += new System.EventHandler(this.HSCLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(512, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seat No";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(592, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 28);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SSC_Validation_Label
            // 
            this.SSC_Validation_Label.AutoSize = true;
            this.SSC_Validation_Label.Location = new System.Drawing.Point(129, 145);
            this.SSC_Validation_Label.Name = "SSC_Validation_Label";
            this.SSC_Validation_Label.Size = new System.Drawing.Size(0, 13);
            this.SSC_Validation_Label.TabIndex = 8;
            // 
            // HSC_Validation_Label
            // 
            this.HSC_Validation_Label.AutoSize = true;
            this.HSC_Validation_Label.Location = new System.Drawing.Point(608, 144);
            this.HSC_Validation_Label.Name = "HSC_Validation_Label";
            this.HSC_Validation_Label.Size = new System.Drawing.Size(0, 13);
            this.HSC_Validation_Label.TabIndex = 9;
            // 
            // Label_Insert_Payment
            // 
            this.Label_Insert_Payment.AutoSize = true;
            this.Label_Insert_Payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_Insert_Payment.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Insert_Payment.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label_Insert_Payment.Location = new System.Drawing.Point(340, 236);
            this.Label_Insert_Payment.Name = "Label_Insert_Payment";
            this.Label_Insert_Payment.Size = new System.Drawing.Size(165, 21);
            this.Label_Insert_Payment.TabIndex = 10;
            this.Label_Insert_Payment.Text = "Insert Record in Payment";
            this.Label_Insert_Payment.Click += new System.EventHandler(this.Label_Insert_Payment_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(868, 386);
            this.Controls.Add(this.Label_Insert_Payment);
            this.Controls.Add(this.HSC_Validation_Label);
            this.Controls.Add(this.SSC_Validation_Label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HSCLabel);
            this.Controls.Add(this.SSC_Label);
            this.Controls.Add(this.SSC_Update_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SSC_Update_Btn;
        private System.Windows.Forms.Label SSC_Label;
        private System.Windows.Forms.Label HSCLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SSC_Validation_Label;
        private System.Windows.Forms.Label HSC_Validation_Label;
        private System.Windows.Forms.Label Label_Insert_Payment;
    }
}