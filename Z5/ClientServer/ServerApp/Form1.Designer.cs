namespace ServerApp {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.startButton = new System.Windows.Forms.Button();
			this.folderBrowseButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(12, 226);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(260, 23);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start/Stop";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// folderBrowseButton
			// 
			this.folderBrowseButton.Location = new System.Drawing.Point(197, 134);
			this.folderBrowseButton.Name = "folderBrowseButton";
			this.folderBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.folderBrowseButton.TabIndex = 1;
			this.folderBrowseButton.Text = "Browse";
			this.folderBrowseButton.UseVisualStyleBackColor = true;
			this.folderBrowseButton.Click += new System.EventHandler(this.folderBrowseButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(77, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(77, 72);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(165, 20);
			this.textBox3.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "IP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Folder path";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(12, 186);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(35, 13);
			this.statusLabel.TabIndex = 8;
			this.statusLabel.Text = "label4";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.folderBrowseButton);
			this.Controls.Add(this.startButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button folderBrowseButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label statusLabel;
	}
}

