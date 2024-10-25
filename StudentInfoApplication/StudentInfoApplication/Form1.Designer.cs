namespace StudentInfoApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            studentID = new TextBox();
            fName = new TextBox();
            lName = new TextBox();
            listBoxStudentID = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            listBoxLName = new ListBox();
            listBoxFName = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(606, 27);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 27);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            label3.Click += label3_Click;
            // 
            // studentID
            // 
            studentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentID.BackColor = Color.Thistle;
            studentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentID.Location = new Point(42, 66);
            studentID.Name = "studentID";
            studentID.Size = new Size(169, 29);
            studentID.TabIndex = 3;
            // 
            // fName
            // 
            fName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fName.BackColor = Color.Thistle;
            fName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fName.Location = new Point(563, 66);
            fName.Name = "fName";
            fName.Size = new Size(150, 29);
            fName.TabIndex = 4;
            // 
            // lName
            // 
            lName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lName.BackColor = Color.Thistle;
            lName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lName.Location = new Point(293, 66);
            lName.Name = "lName";
            lName.Size = new Size(175, 29);
            lName.TabIndex = 5;
            // 
            // listBoxStudentID
            // 
            listBoxStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxStudentID.BackColor = Color.Thistle;
            listBoxStudentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxStudentID.FormattingEnabled = true;
            listBoxStudentID.ItemHeight = 21;
            listBoxStudentID.Location = new Point(42, 208);
            listBoxStudentID.Name = "listBoxStudentID";
            listBoxStudentID.Size = new Size(169, 193);
            listBoxStudentID.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            label4.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 175);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 8;
            label4.Text = "Student ID List:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            label5.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(333, 175);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 9;
            label5.Text = "Last Name List:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Thistle;
            label6.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(606, 175);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 10;
            label6.Text = "First Name List:";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(668, 120);
            button1.Name = "button1";
            button1.Size = new Size(79, 35);
            button1.TabIndex = 11;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBoxLName
            // 
            listBoxLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxLName.BackColor = Color.Thistle;
            listBoxLName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxLName.FormattingEnabled = true;
            listBoxLName.ItemHeight = 21;
            listBoxLName.Location = new Point(293, 208);
            listBoxLName.Name = "listBoxLName";
            listBoxLName.Size = new Size(175, 193);
            listBoxLName.TabIndex = 12;
            listBoxLName.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxFName
            // 
            listBoxFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxFName.BackColor = Color.Thistle;
            listBoxFName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFName.FormattingEnabled = true;
            listBoxFName.ItemHeight = 21;
            listBoxFName.Location = new Point(563, 207);
            listBoxFName.Name = "listBoxFName";
            listBoxFName.Size = new Size(150, 193);
            listBoxFName.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxFName);
            Controls.Add(listBoxLName);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBoxStudentID);
            Controls.Add(lName);
            Controls.Add(fName);
            Controls.Add(studentID);
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
        private TextBox studentID;
        private TextBox fName;
        private TextBox lName;
        private ListBox listBoxStudentID;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ListBox listBoxLName;
        private ListBox listBoxFName;
    }
}
