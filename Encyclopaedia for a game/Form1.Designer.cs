namespace Encyclopaedia_for_a_game
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
            GameListBox = new ListBox();
            label1 = new Label();
            DeleteButton = new Button();
            Form2Link = new Button();
            Refreashbutton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label5 = new Label();
            HoursTotal = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // GameListBox
            // 
            GameListBox.BackColor = SystemColors.Menu;
            GameListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameListBox.FormattingEnabled = true;
            GameListBox.ItemHeight = 36;
            GameListBox.Location = new Point(14, 12);
            GameListBox.Margin = new Padding(3, 4, 3, 4);
            GameListBox.Name = "GameListBox";
            GameListBox.Size = new Size(513, 796);
            GameListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(120, 16);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(106, 97);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form2Link
            // 
            Form2Link.FlatStyle = FlatStyle.System;
            Form2Link.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Form2Link.Location = new Point(466, 69);
            Form2Link.Margin = new Padding(3, 4, 3, 4);
            Form2Link.Name = "Form2Link";
            Form2Link.Size = new Size(147, 121);
            Form2Link.TabIndex = 7;
            Form2Link.Text = "Add New Entry";
            Form2Link.UseVisualStyleBackColor = true;
            Form2Link.Click += button2_Click;
            // 
            // Refreashbutton
            // 
            Refreashbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refreashbutton.Location = new Point(7, 16);
            Refreashbutton.Margin = new Padding(3, 4, 3, 4);
            Refreashbutton.Name = "Refreashbutton";
            Refreashbutton.Size = new Size(106, 97);
            Refreashbutton.TabIndex = 8;
            Refreashbutton.Text = "Refresh";
            Refreashbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(DeleteButton);
            groupBox1.Controls.Add(Refreashbutton);
            groupBox1.Location = new Point(536, 696);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(235, 121);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(7, 205);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(614, 459);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label4.Location = new Point(7, 311);
            label4.Name = "label4";
            label4.Size = new Size(313, 62);
            label4.TabIndex = 5;
            label4.Text = "Time To Beat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label3.Location = new Point(7, 168);
            label3.Name = "label3";
            label3.Size = new Size(157, 62);
            label3.TabIndex = 4;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label2.Location = new Point(7, 25);
            label2.Name = "label2";
            label2.Size = new Size(296, 62);
            label2.TabIndex = 3;
            label2.Text = "Game Name";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.Location = new Point(7, 393);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(600, 47);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(7, 240);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(600, 47);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(7, 97);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(600, 47);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(Form2Link);
            groupBox3.Location = new Point(534, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(627, 672);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(HoursTotal);
            groupBox4.Location = new Point(7, 16);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(296, 181);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label5.Location = new Point(22, 12);
            label5.Name = "label5";
            label5.Size = new Size(282, 62);
            label5.TabIndex = 9;
            label5.Text = "Total Hours";
            // 
            // HoursTotal
            // 
            HoursTotal.Font = new Font("Segoe UI", 18F);
            HoursTotal.Location = new Point(73, 84);
            HoursTotal.Margin = new Padding(3, 4, 3, 4);
            HoursTotal.Name = "HoursTotal";
            HoursTotal.ReadOnly = true;
            HoursTotal.Size = new Size(157, 47);
            HoursTotal.TabIndex = 12;
            HoursTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1199, 845);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(GameListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Game Tracker";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox GameListBox;
        private Label label1;
        private Button DeleteButton;
        private Button Form2Link;
        private Button Refreashbutton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox HoursTotal;
        private GroupBox groupBox4;
    }
}
