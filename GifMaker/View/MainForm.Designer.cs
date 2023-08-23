namespace GifMaker.View
{

    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            progressDialog1 = new Ookii.Dialogs.WinForms.ProgressDialog(components);
            finishedTaskDialog = new Ookii.Dialogs.WinForms.TaskDialog(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Base Images Folder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Destination Folder";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(28, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(556, 159);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(218, 126);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(147, 19);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Multiple Image Folders";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(132, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(80, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Create GIF";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(36, 127);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 15);
            label7.TabIndex = 13;
            label7.Text = "Export Options";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(96, 99);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(26, 15);
            label6.TabIndex = 12;
            label6.Text = "FPS";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(132, 97);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(56, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new System.Drawing.Point(132, 65);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(320, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 15);
            label5.TabIndex = 7;
            label5.Text = "Suffix (Optional)";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new System.Drawing.Point(132, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(320, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 32);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 15);
            label4.TabIndex = 2;
            label4.Text = "Prefix (Optional)";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(133, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(319, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new System.Drawing.Point(133, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(319, 23);
            textBox2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new System.Drawing.Point(28, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(556, 98);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(458, 59);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(458, 22);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(264, 316);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Generate!";
            button3.UseVisualStyleBackColor = true;
            // 
            // progressDialog1
            // 
            progressDialog1.Text = "progressDialog1";
            // 
            // finishedTaskDialog
            // 
            finishedTaskDialog.MainInstruction = "taskDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(614, 351);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new System.Drawing.Size(1000, 390);
            MinimumSize = new System.Drawing.Size(630, 390);
            Name = "MainForm";
            Text = "Video/Gif Generator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button3;
        private CheckBox checkBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Ookii.Dialogs.WinForms.ProgressDialog progressDialog1;
        private Ookii.Dialogs.WinForms.TaskDialog finishedTaskDialog;
    }
}
