namespace Zabawki
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
            this.nameCombo = new System.Windows.Forms.ComboBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accButton = new System.Windows.Forms.Button();
            this.riseButton = new System.Windows.Forms.Button();
            this.diveButton = new System.Windows.Forms.Button();
            this.selectedDesc = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.typeComboAdd = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameCombo
            // 
            this.nameCombo.FormattingEnabled = true;
            this.nameCombo.Location = new System.Drawing.Point(6, 19);
            this.nameCombo.Name = "nameCombo";
            this.nameCombo.Size = new System.Drawing.Size(161, 21);
            this.nameCombo.TabIndex = 0;
            this.nameCombo.SelectedIndexChanged += new System.EventHandler(this.nameCombo_SelectedIndexChanged);
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(173, 19);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(239, 21);
            this.typeCombo.TabIndex = 1;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(418, 17);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameCombo);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.typeCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecting objects";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.accButton);
            this.groupBox2.Controls.Add(this.riseButton);
            this.groupBox2.Controls.Add(this.diveButton);
            this.groupBox2.Controls.Add(this.selectedDesc);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 141);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting parameters";
            // 
            // accButton
            // 
            this.accButton.Location = new System.Drawing.Point(418, 73);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(75, 23);
            this.accButton.TabIndex = 3;
            this.accButton.Text = "Accelerate";
            this.accButton.UseVisualStyleBackColor = true;
            this.accButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // riseButton
            // 
            this.riseButton.Location = new System.Drawing.Point(418, 44);
            this.riseButton.Name = "riseButton";
            this.riseButton.Size = new System.Drawing.Size(75, 23);
            this.riseButton.TabIndex = 2;
            this.riseButton.Text = "Rise";
            this.riseButton.UseVisualStyleBackColor = true;
            this.riseButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // diveButton
            // 
            this.diveButton.Location = new System.Drawing.Point(418, 15);
            this.diveButton.Name = "diveButton";
            this.diveButton.Size = new System.Drawing.Size(75, 23);
            this.diveButton.TabIndex = 1;
            this.diveButton.Text = "Dive";
            this.diveButton.UseVisualStyleBackColor = true;
            this.diveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // selectedDesc
            // 
            this.selectedDesc.AutoSize = true;
            this.selectedDesc.Location = new System.Drawing.Point(9, 20);
            this.selectedDesc.Name = "selectedDesc";
            this.selectedDesc.Size = new System.Drawing.Size(35, 13);
            this.selectedDesc.TabIndex = 0;
            this.selectedDesc.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.typeComboAdd);
            this.groupBox3.Location = new System.Drawing.Point(12, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adding objects";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(418, 17);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeComboAdd
            // 
            this.typeComboAdd.FormattingEnabled = true;
            this.typeComboAdd.Location = new System.Drawing.Point(6, 19);
            this.typeComboAdd.Name = "typeComboAdd";
            this.typeComboAdd.Size = new System.Drawing.Size(406, 21);
            this.typeComboAdd.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(292, 15);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 286);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox nameCombo;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox typeComboAdd;
        private System.Windows.Forms.Button accButton;
        private System.Windows.Forms.Button riseButton;
        private System.Windows.Forms.Button diveButton;
        private System.Windows.Forms.Label selectedDesc;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

