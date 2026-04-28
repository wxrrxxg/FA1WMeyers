namespace HomeAffairsDigitalIdentityProcessor
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblTitle = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            button1 = new Button();
            cmbCitizenship = new ComboBox();
            button2 = new Button();
            txtResult = new TextBox();
            lblResults = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 375);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 192, 0);
            lblTitle.Location = new Point(387, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(349, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 89);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter your name";
            // 
            // txtName
            // 
            txtName.Location = new Point(476, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 131);
            label3.Name = "label3";
            label3.Size = new Size(130, 28);
            label3.TabIndex = 5;
            label3.Text = "Enter your ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(282, 179);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 6;
            label4.Text = "Choose your Citizen:";
            // 
            // txtID
            // 
            txtID.Location = new Point(478, 131);
            txtID.Name = "txtID";
            txtID.Size = new Size(219, 27);
            txtID.TabIndex = 7;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Location = new Point(511, 217);
            button1.Name = "button1";
            button1.Size = new Size(139, 32);
            button1.TabIndex = 9;
            button1.Text = "Validate ID";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Items.AddRange(new object[] { "South African", "Permanent Resident", "Visitor" });
            cmbCitizenship.Location = new Point(478, 183);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(219, 28);
            cmbCitizenship.TabIndex = 10;
            cmbCitizenship.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(511, 404);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 11;
            button2.Text = "Generate Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnGenerate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(476, 295);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(221, 104);
            txtResult.TabIndex = 12;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(521, 250);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 20);
            lblResults.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResults);
            Controls.Add(txtResult);
            Controls.Add(button2);
            Controls.Add(cmbCitizenship);
            Controls.Add(button1);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblTitle;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private Button button1;
        private ComboBox cmbCitizenship;
        private Button button2;
        private TextBox txtResult;
        private Label lblResults;
    }
}
