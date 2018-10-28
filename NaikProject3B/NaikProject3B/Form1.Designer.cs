namespace NaikProject3B
{
    partial class String
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.string1 = new System.Windows.Forms.MaskedTextBox();
            this.outptstring1 = new System.Windows.Forms.MaskedTextBox();
            this.string2 = new System.Windows.Forms.MaskedTextBox();
            this.String3 = new System.Windows.Forms.MaskedTextBox();
            this.butvalidate1 = new System.Windows.Forms.Button();
            this.butvalidate2 = new System.Windows.Forms.Button();
            this.butvalidate3 = new System.Windows.Forms.Button();
            this.butValidateall = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.String4 = new System.Windows.Forms.MaskedTextBox();
            this.butValidate4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output for String1 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "String2 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "String 3 ";
            // 
            // string1
            // 
            this.string1.Location = new System.Drawing.Point(215, 48);
            this.string1.Name = "string1";
            this.string1.Size = new System.Drawing.Size(139, 20);
            this.string1.TabIndex = 0;
            // 
            // outptstring1
            // 
            this.outptstring1.Location = new System.Drawing.Point(215, 74);
            this.outptstring1.Name = "outptstring1";
            this.outptstring1.ReadOnly = true;
            this.outptstring1.Size = new System.Drawing.Size(139, 20);
            this.outptstring1.TabIndex = 6;
            this.outptstring1.TabStop = false;
            // 
            // string2
            // 
            this.string2.Location = new System.Drawing.Point(215, 108);
            this.string2.Name = "string2";
            this.string2.Size = new System.Drawing.Size(139, 20);
            this.string2.TabIndex = 2;
            // 
            // String3
            // 
            this.String3.Location = new System.Drawing.Point(215, 137);
            this.String3.Name = "String3";
            this.String3.Size = new System.Drawing.Size(139, 20);
            this.String3.TabIndex = 4;
            // 
            // butvalidate1
            // 
            this.butvalidate1.Location = new System.Drawing.Point(360, 62);
            this.butvalidate1.Name = "butvalidate1";
            this.butvalidate1.Size = new System.Drawing.Size(75, 23);
            this.butvalidate1.TabIndex = 1;
            this.butvalidate1.Text = "Validate";
            this.butvalidate1.UseVisualStyleBackColor = true;
            this.butvalidate1.Click += new System.EventHandler(this.butvalidate1_Click);
            // 
            // butvalidate2
            // 
            this.butvalidate2.Location = new System.Drawing.Point(360, 106);
            this.butvalidate2.Name = "butvalidate2";
            this.butvalidate2.Size = new System.Drawing.Size(75, 23);
            this.butvalidate2.TabIndex = 3;
            this.butvalidate2.Text = "Validate";
            this.butvalidate2.UseVisualStyleBackColor = true;
            this.butvalidate2.Click += new System.EventHandler(this.butvalidate2_Click);
            // 
            // butvalidate3
            // 
            this.butvalidate3.Location = new System.Drawing.Point(360, 135);
            this.butvalidate3.Name = "butvalidate3";
            this.butvalidate3.Size = new System.Drawing.Size(75, 23);
            this.butvalidate3.TabIndex = 5;
            this.butvalidate3.Text = "Validate";
            this.butvalidate3.UseVisualStyleBackColor = true;
            this.butvalidate3.Click += new System.EventHandler(this.butvalidate3_Click);
            // 
            // butValidateall
            // 
            this.butValidateall.Location = new System.Drawing.Point(224, 200);
            this.butValidateall.Name = "butValidateall";
            this.butValidateall.Size = new System.Drawing.Size(75, 23);
            this.butValidateall.TabIndex = 8;
            this.butValidateall.Text = "Validate All";
            this.butValidateall.UseVisualStyleBackColor = true;
            this.butValidateall.Click += new System.EventHandler(this.butValidateall_Click);
            // 
            // butExit
            // 
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Location = new System.Drawing.Point(318, 200);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(98, 23);
            this.butExit.TabIndex = 9;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "String 4";
            // 
            // String4
            // 
            this.String4.Location = new System.Drawing.Point(215, 163);
            this.String4.Name = "String4";
            this.String4.Size = new System.Drawing.Size(139, 20);
            this.String4.TabIndex = 6;
            // 
            // butValidate4
            // 
            this.butValidate4.Location = new System.Drawing.Point(360, 163);
            this.butValidate4.Name = "butValidate4";
            this.butValidate4.Size = new System.Drawing.Size(75, 23);
            this.butValidate4.TabIndex = 7;
            this.butValidate4.Text = "Validate";
            this.butValidate4.UseVisualStyleBackColor = true;
            this.butValidate4.Click += new System.EventHandler(this.butValidate4_Click);
            // 
            // String
            // 
            this.AcceptButton = this.butValidateall;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butExit;
            this.ClientSize = new System.Drawing.Size(800, 263);
            this.Controls.Add(this.butValidate4);
            this.Controls.Add(this.String4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butValidateall);
            this.Controls.Add(this.butvalidate3);
            this.Controls.Add(this.butvalidate2);
            this.Controls.Add(this.butvalidate1);
            this.Controls.Add(this.String3);
            this.Controls.Add(this.string2);
            this.Controls.Add(this.outptstring1);
            this.Controls.Add(this.string1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "String";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox string1;
        private System.Windows.Forms.MaskedTextBox outptstring1;
        private System.Windows.Forms.MaskedTextBox string2;
        private System.Windows.Forms.MaskedTextBox String3;
        private System.Windows.Forms.Button butvalidate1;
        private System.Windows.Forms.Button butvalidate2;
        private System.Windows.Forms.Button butvalidate3;
        private System.Windows.Forms.Button butValidateall;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox String4;
        private System.Windows.Forms.Button butValidate4;
    }
}

