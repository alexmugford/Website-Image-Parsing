namespace ProgrammingInterviewQuestion
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WebsiteInput = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.ParseButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.WebsiteInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DisplayBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ParseButton
            // 
            this.ParseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParseButton.Location = new System.Drawing.Point(3, 313);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(82, 26);
            this.ParseButton.TabIndex = 0;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WebsiteInput
            // 
            this.WebsiteInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebsiteInput.Location = new System.Drawing.Point(91, 313);
            this.WebsiteInput.Name = "WebsiteInput";
            this.WebsiteInput.Size = new System.Drawing.Size(498, 20);
            this.WebsiteInput.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(91, 279);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(498, 31);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Enter Website URL here:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 282);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DisplayBox.Location = new System.Drawing.Point(91, 3);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(489, 260);
            this.DisplayBox.TabIndex = 4;
            this.DisplayBox.Text = "";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 53);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load File";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Web Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox WebsiteInput;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RichTextBox DisplayBox;
        private System.Windows.Forms.Button LoadButton;
    }
}

