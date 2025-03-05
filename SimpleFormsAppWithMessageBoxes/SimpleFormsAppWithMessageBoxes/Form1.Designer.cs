
namespace SimpleFormsAppWithMessageBoxes
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
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtSuffix = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(296, 99);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(246, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(296, 174);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(246, 27);
            txtMiddleName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(296, 253);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(246, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(296, 338);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(246, 27);
            txtSuffix.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 151);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 5;
            label2.Text = "Middle Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 230);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 315);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Suffix";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(323, 393);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(182, 45);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSuffix);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtSuffix;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSubmit;
    }
}
