namespace WinFormsApp
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
            lstLanguages = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblStatus = new Label();
            txtLanguageInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 48);
            label1.Name = "label1";
            label1.Size = new Size(515, 38);
            label1.TabIndex = 0;
            label1.Text = "My Favourite Programming Language";
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(133, 110);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(403, 184);
            lstLanguages.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Location = new Point(136, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.OrangeRed;
            btnRemove.Location = new Point(366, 355);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(170, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(140, 399);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 5;
            // 
            // txtLanguageInput
            // 
            txtLanguageInput.Location = new Point(136, 309);
            txtLanguageInput.Name = "txtLanguageInput";
            txtLanguageInput.PlaceholderText = "Enter Programming Language";
            txtLanguageInput.Size = new Size(218, 27);
            txtLanguageInput.TabIndex = 6;
            txtLanguageInput.TextChanged += txtLanguageInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLanguageInput);
            Controls.Add(lblStatus);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstLanguages);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstLanguages;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblStatus;
        private TextBox txtLanguageInput;
    }
}
