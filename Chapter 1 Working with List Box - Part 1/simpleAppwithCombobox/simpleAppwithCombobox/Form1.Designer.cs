namespace simpleAppwithCombobox
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            fchcklstbox = new CheckedListBox();
            flstbox = new ListBox();
            selectbtn = new Button();
            addbtn = new Button();
            Removebtn = new Button();
            clrbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Food Picker App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Cuisine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 102);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Foodlist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 102);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 3;
            label4.Text = "My Favorite Foodlist";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // fchcklstbox
            // 
            fchcklstbox.FormattingEnabled = true;
            fchcklstbox.Location = new Point(251, 140);
            fchcklstbox.Name = "fchcklstbox";
            fchcklstbox.Size = new Size(150, 114);
            fchcklstbox.TabIndex = 5;
            // 
            // flstbox
            // 
            flstbox.FormattingEnabled = true;
            flstbox.Location = new Point(521, 150);
            flstbox.Name = "flstbox";
            flstbox.Size = new Size(150, 104);
            flstbox.TabIndex = 6;
            // 
            // selectbtn
            // 
            selectbtn.Location = new Point(49, 189);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(94, 29);
            selectbtn.TabIndex = 7;
            selectbtn.Text = "Select";
            selectbtn.UseVisualStyleBackColor = true;
            selectbtn.Click += selectbtn_Click;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(275, 284);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 29);
            addbtn.TabIndex = 8;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // Removebtn
            // 
            Removebtn.Location = new Point(545, 284);
            Removebtn.Name = "Removebtn";
            Removebtn.Size = new Size(94, 29);
            Removebtn.TabIndex = 9;
            Removebtn.Text = "Remove";
            Removebtn.UseVisualStyleBackColor = true;
            Removebtn.Click += Removebtn_Click;
            // 
            // clrbtn
            // 
            clrbtn.Location = new Point(545, 336);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(94, 29);
            clrbtn.TabIndex = 10;
            clrbtn.Text = "Clear";
            clrbtn.UseVisualStyleBackColor = true;
            clrbtn.Click += clrbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clrbtn);
            Controls.Add(Removebtn);
            Controls.Add(addbtn);
            Controls.Add(selectbtn);
            Controls.Add(flstbox);
            Controls.Add(fchcklstbox);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private CheckedListBox fchcklstbox;
        private ListBox flstbox;
        private Button selectbtn;
        private Button addbtn;
        private Button Removebtn;
        private Button clrbtn;
    }
}
