namespace BankAccountt
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
            Owner = new Label();
            Amount = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            AccountGrid = new DataGridView();
            CreateAccountBtn = new Button();
            DepositBtn = new Button();
            WhitdrawBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountGrid).BeginInit();
            SuspendLayout();
            // 
            // Owner
            // 
            Owner.AutoSize = true;
            Owner.Location = new Point(51, 50);
            Owner.Margin = new Padding(4, 0, 4, 0);
            Owner.Name = "Owner";
            Owner.Size = new Size(89, 32);
            Owner.TabIndex = 0;
            Owner.Text = "Owner";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Location = new Point(34, 303);
            Amount.Margin = new Padding(4, 0, 4, 0);
            Amount.Name = "Amount";
            Amount.Size = new Size(107, 32);
            Amount.TabIndex = 1;
            Amount.Text = "Amount";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(155, 303);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { -727379969, 232, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(183, 39);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 48);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 39);
            textBox1.TabIndex = 3;
            // 
            // AccountGrid
            // 
            AccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountGrid.Location = new Point(397, 31);
            AccountGrid.Margin = new Padding(2);
            AccountGrid.Name = "AccountGrid";
            AccountGrid.RowHeadersWidth = 62;
            AccountGrid.Size = new Size(435, 230);
            AccountGrid.TabIndex = 4;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(51, 158);
            CreateAccountBtn.Margin = new Padding(2);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(287, 53);
            CreateAccountBtn.TabIndex = 5;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(397, 303);
            DepositBtn.Margin = new Padding(2);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(199, 53);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WhitdrawBtn
            // 
            WhitdrawBtn.Location = new Point(633, 303);
            WhitdrawBtn.Margin = new Padding(2);
            WhitdrawBtn.Name = "WhitdrawBtn";
            WhitdrawBtn.Size = new Size(199, 53);
            WhitdrawBtn.TabIndex = 7;
            WhitdrawBtn.Text = "Whitdraw";
            WhitdrawBtn.UseVisualStyleBackColor = true;
            WhitdrawBtn.Click += WhitdrawBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 402);
            Controls.Add(WhitdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(AccountGrid);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(Amount);
            Controls.Add(Owner);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Owner;
        private Label Amount;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private DataGridView AccountGrid;
        private Button CreateAccountBtn;
        private Button DepositBtn;
        private Button WhitdrawBtn;
    }
}
