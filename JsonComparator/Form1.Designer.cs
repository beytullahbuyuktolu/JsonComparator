namespace JsonComparator
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
            lbNewKeys = new ListBox();
            lbtobeCompared = new ListBox();
            lbDifference = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCompare = new Button();
            btnNewKey = new Button();
            btntobeCompared = new Button();
            btnDifference = new Button();
            SuspendLayout();
            // 
            // lbNewKeys
            // 
            lbNewKeys.FormattingEnabled = true;
            lbNewKeys.Location = new Point(12, 65);
            lbNewKeys.Name = "lbNewKeys";
            lbNewKeys.Size = new Size(166, 284);
            lbNewKeys.TabIndex = 0;
            // 
            // lbtobeCompared
            // 
            lbtobeCompared.FormattingEnabled = true;
            lbtobeCompared.Location = new Point(198, 65);
            lbtobeCompared.Name = "lbtobeCompared";
            lbtobeCompared.Size = new Size(166, 284);
            lbtobeCompared.TabIndex = 1;
            // 
            // lbDifference
            // 
            lbDifference.FormattingEnabled = true;
            lbDifference.Location = new Point(380, 65);
            lbDifference.Name = "lbDifference";
            lbDifference.Size = new Size(166, 284);
            lbDifference.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "New Keys";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 23);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 2;
            label2.Text = "To be Compared";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 23);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Difference";
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(82, 438);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(299, 44);
            btnCompare.TabIndex = 3;
            btnCompare.Text = "Find Differences of 2 Selected Files";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // btnNewKey
            // 
            btnNewKey.Location = new Point(12, 355);
            btnNewKey.Name = "btnNewKey";
            btnNewKey.Size = new Size(166, 77);
            btnNewKey.TabIndex = 4;
            btnNewKey.Text = "Select the File to Find Differences";
            btnNewKey.UseVisualStyleBackColor = true;
            btnNewKey.Click += btnNewKey_Click;
            // 
            // btntobeCompared
            // 
            btntobeCompared.Location = new Point(198, 355);
            btntobeCompared.Name = "btntobeCompared";
            btntobeCompared.Size = new Size(166, 77);
            btntobeCompared.TabIndex = 4;
            btntobeCompared.Text = "Select File to Compare";
            btntobeCompared.UseVisualStyleBackColor = true;
            btntobeCompared.Click += btntobeCompared_Click;
            // 
            // btnDifference
            // 
            btnDifference.Location = new Point(380, 355);
            btnDifference.Name = "btnDifference";
            btnDifference.Size = new Size(166, 77);
            btnDifference.TabIndex = 4;
            btnDifference.Text = "Transfer the Differences to Listbox 1 and Save";
            btnDifference.UseVisualStyleBackColor = true;
            btnDifference.Click += btnDifference_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 527);
            Controls.Add(btnDifference);
            Controls.Add(btntobeCompared);
            Controls.Add(btnNewKey);
            Controls.Add(btnCompare);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbDifference);
            Controls.Add(lbtobeCompared);
            Controls.Add(lbNewKeys);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNewKeys;
        private ListBox lbtobeCompared;
        private ListBox lbDifference;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCompare;
        private Button btnNewKey;
        private Button btntobeCompared;
        private Button btnDifference;
    }
}
