namespace Ciclo_FOR_JP
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
            button1 = new Button();
            txtC1V1 = new TextBox();
            txtC1V2 = new TextBox();
            txtC2V1 = new TextBox();
            txtC2V2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(230, 305);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(302, 85);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtC1V1
            // 
            txtC1V1.Location = new Point(149, 115);
            txtC1V1.Margin = new Padding(5, 5, 5, 5);
            txtC1V1.Name = "txtC1V1";
            txtC1V1.Size = new Size(201, 38);
            txtC1V1.TabIndex = 1;
            // 
            // txtC1V2
            // 
            txtC1V2.Location = new Point(149, 206);
            txtC1V2.Margin = new Padding(5, 5, 5, 5);
            txtC1V2.Name = "txtC1V2";
            txtC1V2.Size = new Size(201, 38);
            txtC1V2.TabIndex = 2;
            // 
            // txtC2V1
            // 
            txtC2V1.Location = new Point(530, 112);
            txtC2V1.Margin = new Padding(5, 5, 5, 5);
            txtC2V1.Name = "txtC2V1";
            txtC2V1.Size = new Size(201, 38);
            txtC2V1.TabIndex = 3;
            // 
            // txtC2V2
            // 
            txtC2V2.Location = new Point(530, 206);
            txtC2V2.Margin = new Padding(5, 5, 5, 5);
            txtC2V2.Name = "txtC2V2";
            txtC2V2.Size = new Size(201, 38);
            txtC2V2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 115);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 5;
            label1.Text = "Vuelta 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 206);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 31);
            label2.TabIndex = 6;
            label2.Text = "Vuelta 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 115);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 31);
            label3.TabIndex = 7;
            label3.Text = "Vuelta 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 206);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 8;
            label4.Text = "Vuelta 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 35);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 31);
            label5.TabIndex = 9;
            label5.Text = "Corredor 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(530, 35);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 31);
            label6.TabIndex = 10;
            label6.Text = "Corredor 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 420);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtC2V2);
            Controls.Add(txtC2V1);
            Controls.Add(txtC1V2);
            Controls.Add(txtC1V1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtC1V1;
        private TextBox txtC1V2;
        private TextBox txtC2V1;
        private TextBox txtC2V2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
