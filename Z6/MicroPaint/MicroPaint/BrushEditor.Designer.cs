namespace MicroPaint {
	partial class BrushEditor {
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
			this.redUD = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.greenUD = new System.Windows.Forms.NumericUpDown();
			this.blueUD = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.sizeUD = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.redUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greenUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blueUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// redUD
			// 
			this.redUD.Location = new System.Drawing.Point(89, 22);
			this.redUD.Name = "redUD";
			this.redUD.Size = new System.Drawing.Size(72, 20);
			this.redUD.TabIndex = 2;
			this.redUD.ValueChanged += new System.EventHandler(this.redUD_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Red";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Green";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Blue";
			// 
			// greenUD
			// 
			this.greenUD.Location = new System.Drawing.Point(89, 48);
			this.greenUD.Name = "greenUD";
			this.greenUD.Size = new System.Drawing.Size(72, 20);
			this.greenUD.TabIndex = 6;
			this.greenUD.ValueChanged += new System.EventHandler(this.greenUD_ValueChanged);
			// 
			// blueUD
			// 
			this.blueUD.Location = new System.Drawing.Point(89, 74);
			this.blueUD.Name = "blueUD";
			this.blueUD.Size = new System.Drawing.Size(72, 20);
			this.blueUD.TabIndex = 7;
			this.blueUD.ValueChanged += new System.EventHandler(this.blueUD_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Pick color";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// sizeUD
			// 
			this.sizeUD.Location = new System.Drawing.Point(84, 146);
			this.sizeUD.Name = "sizeUD";
			this.sizeUD.Size = new System.Drawing.Size(77, 20);
			this.sizeUD.TabIndex = 1;
			this.sizeUD.ValueChanged += new System.EventHandler(this.sizeUD_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Size";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(181, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(180, 144);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(236, 185);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Apply";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(155, 185);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// BrushEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 233);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.sizeUD);
			this.Controls.Add(this.blueUD);
			this.Controls.Add(this.greenUD);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.redUD);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "BrushEditor";
			this.Text = "BrushEditor";
			((System.ComponentModel.ISupportInitialize)(this.redUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greenUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blueUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sizeUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown redUD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown greenUD;
		private System.Windows.Forms.NumericUpDown blueUD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown sizeUD;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}