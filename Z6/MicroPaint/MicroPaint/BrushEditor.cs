using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroPaint {
	public partial class BrushEditor : Form {
		public Color selectedColor = Color.Black;
		public float size = 1f;
		Bitmap bitmap;
		Graphics g;
		bool initFlag = true;

		public Color SelectedColor {
			get {
				return selectedColor;
			}

			set {
				selectedColor = value;
			}
		}

		public float Size {
			get {
				return size;
			}

			set {
				size = value;
			}
		}

		public BrushEditor() {
			InitializeComponent();
			bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
			g = Graphics.FromImage(bitmap);
			blueUD.Minimum = 0;
			blueUD.Maximum = 255;
			redUD.Minimum = 0;
			redUD.Maximum = 255;
			greenUD.Minimum = 0;
			greenUD.Maximum = 255;
			sizeUD.Minimum = 1;
			sizeUD.Maximum = 20;
			g.DrawRectangle(new Pen(Brushes.White), new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height));
			pictureBox1.Image = bitmap;
		}
		public BrushEditor(Color color, float width):this() {
			selectedColor = color;
			size = width;
			SetSelectedColor(selectedColor);
			sizeUD.Value = (decimal)size;
			initFlag = false;
			SetColorAndSizeAndDraw();
		}

		private void button1_Click(object sender, EventArgs e) {
			ColorDialog colorDialog = new ColorDialog();
			if(selectedColor != Color.Empty) {
				colorDialog.Color = selectedColor;
			}
			colorDialog.ShowDialog();
			selectedColor = colorDialog.Color;
			SetSelectedColor(selectedColor);
		}

		private void SetSelectedColor(Color c) {
			redUD.Value = (decimal)c.R;
			blueUD.Value = (decimal)c.B;
			greenUD.Value = (decimal)c.G;
		}

		private void SetColorAndSizeAndDraw() {
			selectedColor = Color.FromArgb((int)redUD.Value, (int)greenUD.Value, (int)blueUD.Value);
			size = (float)sizeUD.Value;
			DrawPoint();
			pictureBox1.Image = bitmap;
		}

		private void DrawPoint() {
			g.DrawRectangle(new Pen(Brushes.White,pictureBox1.Size.Width), new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height));
			g.DrawEllipse(new Pen(selectedColor,size), pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2, size, size);
		}

		private void redUD_ValueChanged(object sender, EventArgs e) {
			if(!initFlag)
			SetColorAndSizeAndDraw();
		}

		private void greenUD_ValueChanged(object sender, EventArgs e) {
			if (!initFlag)
				SetColorAndSizeAndDraw();
		}

		private void blueUD_ValueChanged(object sender, EventArgs e) {
			if (!initFlag)
				SetColorAndSizeAndDraw();
		}

		private void sizeUD_ValueChanged(object sender, EventArgs e) {
			if (!initFlag)
				SetColorAndSizeAndDraw();
		}

		private void button2_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			selectedColor = Color.Empty;
			size = 0;
			this.Close();
		}
	}
}
