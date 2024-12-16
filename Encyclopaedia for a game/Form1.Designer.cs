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
            listBox1 = new ListBox();
            label1 = new Label();
            DeleteButton = new Button();
            Form2Link = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            HoursTotal = new TextBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Menu;
            listBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(12, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(449, 604);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(105, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(93, 73);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form2Link
            // 
            Form2Link.FlatStyle = FlatStyle.System;
            Form2Link.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Form2Link.Location = new Point(408, 52);
            Form2Link.Name = "Form2Link";
            Form2Link.Size = new Size(129, 91);
            Form2Link.TabIndex = 7;
            Form2Link.Text = "Add New Entry";
            Form2Link.UseVisualStyleBackColor = true;
            Form2Link.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(6, 12);
            button1.Name = "button1";
            button1.Size = new Size(93, 73);
            button1.TabIndex = 8;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(DeleteButton);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(469, 522);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 91);
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
            groupBox2.Location = new Point(6, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(537, 344);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label4.Location = new Point(6, 233);
            label4.Name = "label4";
            label4.Size = new Size(253, 51);
            label4.TabIndex = 5;
            label4.Text = "Time To Beat";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(129, 51);
            label3.TabIndex = 4;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(241, 51);
            label2.TabIndex = 3;
            label2.Text = "Game Name";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 18F);
            textBox3.Location = new Point(6, 295);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(525, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(6, 180);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(525, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 73);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(525, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(Form2Link);
            groupBox3.Location = new Point(467, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 504);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label5.Location = new Point(19, 9);
            label5.Name = "label5";
            label5.Size = new Size(227, 51);
            label5.TabIndex = 9;
            label5.Text = "Total Hours";
            // 
            // HoursTotal
            // 
            HoursTotal.Font = new Font("Segoe UI", 18F);
            HoursTotal.Location = new Point(64, 63);
            HoursTotal.Name = "HoursTotal";
            HoursTotal.ReadOnly = true;
            HoursTotal.Size = new Size(138, 39);
            HoursTotal.TabIndex = 12;
            HoursTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(HoursTotal);
            groupBox4.Location = new Point(6, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(259, 136);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 634);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
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

        private ListBox listBox1;
        private Label label1;
        private Button DeleteButton;
        private Button Form2Link;
        private Button button1;
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
