namespace PersonManagementSystem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblReadId = new System.Windows.Forms.Label();
            this.lblReadName = new System.Windows.Forms.Label();
            this.lblReadAge = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mr.",
            "Miss."});
            this.comboBox1.Location = new System.Drawing.Point(44, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(44, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(172, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(44, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(172, 20);
            this.txtAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblReadId
            // 
            this.lblReadId.BackColor = System.Drawing.Color.White;
            this.lblReadId.Location = new System.Drawing.Point(243, 23);
            this.lblReadId.Name = "lblReadId";
            this.lblReadId.Size = new System.Drawing.Size(175, 20);
            this.lblReadId.TabIndex = 8;
            this.lblReadId.Text = "Id";
            // 
            // lblReadName
            // 
            this.lblReadName.BackColor = System.Drawing.Color.White;
            this.lblReadName.Location = new System.Drawing.Point(243, 50);
            this.lblReadName.Name = "lblReadName";
            this.lblReadName.Size = new System.Drawing.Size(175, 20);
            this.lblReadName.TabIndex = 9;
            this.lblReadName.Text = "Name";
            // 
            // lblReadAge
            // 
            this.lblReadAge.BackColor = System.Drawing.Color.White;
            this.lblReadAge.Location = new System.Drawing.Point(243, 75);
            this.lblReadAge.Name = "lblReadAge";
            this.lblReadAge.Size = new System.Drawing.Size(175, 20);
            this.lblReadAge.TabIndex = 10;
            this.lblReadAge.Text = "Age";
            this.lblReadAge.Click += new System.EventHandler(this.lblReadAge_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(240, 101);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(180, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(432, 146);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblReadAge);
            this.Controls.Add(this.lblReadName);
            this.Controls.Add(this.lblReadId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonManagementSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblReadId;
        private System.Windows.Forms.Label lblReadName;
        private System.Windows.Forms.Label lblReadAge;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
    }
}

