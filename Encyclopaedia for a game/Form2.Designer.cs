namespace Encyclopaedia_for_a_game
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            groupBox4 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            Submit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(Submit);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Entry";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 82);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Time To Beat (Hours)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 34);
            textBox2.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox1);
            groupBox4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox4.Location = new Point(6, 114);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(266, 82);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Genre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 34);
            textBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox3.Location = new Point(6, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 82);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Game Title";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 34);
            textBox3.TabIndex = 3;
            // 
            // Submit
            // 
            Submit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.Location = new Point(6, 290);
            Submit.Name = "Submit";
            Submit.Size = new Size(263, 77);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(297, 406);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Game Entry";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Submit;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
    }
}