namespace student_entry_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.resultlistView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(98, 29);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(98, 75);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(100, 20);
            this.emailtextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "email";
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(98, 114);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(100, 20);
            this.addresstextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "adress";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(249, 57);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resultlistView
            // 
            this.resultlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.resultlistView.Location = new System.Drawing.Point(38, 183);
            this.resultlistView.Name = "resultlistView";
            this.resultlistView.Size = new System.Drawing.Size(299, 97);
            this.resultlistView.TabIndex = 7;
            this.resultlistView.UseCompatibleStateImageBehavior = false;
            this.resultlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "email";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 292);
            this.Controls.Add(this.resultlistView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView resultlistView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

