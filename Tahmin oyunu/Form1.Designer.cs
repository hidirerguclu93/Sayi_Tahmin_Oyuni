namespace Tahmin_oyunu
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
            label1 = new Label();
            txtTahmin = new TextBox();
            btnTahminet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(122, 31);
            label1.Name = "label1";
            label1.Size = new Size(368, 41);
            label1.TabIndex = 0;
            label1.Text = "Tahmininizi Giriniz(1-100)";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(221, 89);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(177, 27);
            txtTahmin.TabIndex = 1;
            txtTahmin.KeyUp += txtTahmin_KeyUp;
            // 
            // btnTahminet
            // 
            btnTahminet.Location = new Point(247, 137);
            btnTahminet.Name = "btnTahminet";
            btnTahminet.Size = new Size(117, 31);
            btnTahminet.TabIndex = 2;
            btnTahminet.Text = "Tahmin Et";
            btnTahminet.UseVisualStyleBackColor = true;
            btnTahminet.Click += btnTahminet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 598);
            Controls.Add(btnTahminet);
            Controls.Add(txtTahmin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTahmin;
        private Button btnTahminet;
    }
}
