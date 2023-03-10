
namespace WindowsFormsApp2
{
    partial class PaymentEntry
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
            this.Pay_Button = new System.Windows.Forms.Button();
            this.Payment_Mode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seat No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(406, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pay_Button
            // 
            this.Pay_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Pay_Button.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pay_Button.Location = new System.Drawing.Point(279, 199);
            this.Pay_Button.Name = "Pay_Button";
            this.Pay_Button.Size = new System.Drawing.Size(104, 33);
            this.Pay_Button.TabIndex = 2;
            this.Pay_Button.Text = "Do Entry";
            this.Pay_Button.UseVisualStyleBackColor = false;
            this.Pay_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payment_Mode
            // 
            this.Payment_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_Mode.FormattingEnabled = true;
            this.Payment_Mode.Items.AddRange(new object[] {
            "HSC",
            "SSC"});
            this.Payment_Mode.Location = new System.Drawing.Point(80, 112);
            this.Payment_Mode.Name = "Payment_Mode";
            this.Payment_Mode.Size = new System.Drawing.Size(163, 24);
            this.Payment_Mode.TabIndex = 3;
            this.Payment_Mode.SelectedIndexChanged += new System.EventHandler(this.Payment_Mode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Mode";
            // 
            // PaymentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Payment_Mode);
            this.Controls.Add(this.Pay_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaymentEntry";
            this.Text = "PaymentEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Pay_Button;
        private System.Windows.Forms.ComboBox Payment_Mode;
        private System.Windows.Forms.Label label2;
    }
}