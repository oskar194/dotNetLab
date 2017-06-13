using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroPaint {
	public partial class Form1 : Form {
		Image bitmap = null;
		float imageRatio = 0f;
		Size initalWindowSize = new Size(0, 0);
		Size initalPictureBoxSize = new Size(0, 0);
		int minWidth = 200;
		int minHeight = 200;
		Pen myPen = null;
		Color penColor = Color.Black;
		float penWidth = 10f;
		public Form1() {
			InitializeComponent();
			initalWindowSize = this.Size;
			initalPictureBoxSize = pictureBox1.Size;
			saveToolStripMenuItem.Enabled = false;
			filtersToolStripMenuItem.Enabled = false;
			myPen = new Pen(penColor, penWidth);
			myPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.ShowDialog();
			if (File.Exists(fileDialog.FileName)) {
				string path = fileDialog.FileName;
				FileStream file = new FileStream(path, FileMode.Open);
				try {
					bitmap = Bitmap.FromStream(file);
				} catch (ArgumentException ex) {
					MessageBox.Show("File cannot be opened");
					return;
				} finally {
					file.Close();
				}
				if (bitmap.Size.Width > pictureBox1.Size.Width || bitmap.Size.Height > pictureBox1.Size.Width) {
					bitmap = CalculateRatioAndResizeImage(bitmap);
				}
				pictureBox1.Image = bitmap;
				saveToolStripMenuItem.Enabled = true;
				filtersToolStripMenuItem.Enabled = true;
			}

		}

		private Image CalculateRatioAndResizeImage(Image image) {
			var ratioX = (float)image.Height / (float)image.Width;
			var ratioY = (float)image.Width / (float)image.Height;
			imageRatio = Math.Min(ratioX, ratioY);
			int height = (int)(imageRatio * pictureBox1.Size.Height);
			if (height < minHeight)
				height = minHeight;
			int width = (int)(imageRatio * pictureBox1.Size.Width);
			if (width < minWidth)
				width = minWidth;
			return new Bitmap(image, new Size(width, height));
		}

		private void ResizeImageBox(Size size) {
			int height = size.Height - initalWindowSize.Height;
			int width = size.Width - initalWindowSize.Width ;
			pictureBox1.Size = new Size(initalPictureBoxSize.Width + width, initalPictureBoxSize.Height + height);
		}

		private Image ResizeImage(Image image) {
			int height = (int)(imageRatio * pictureBox1.Size.Height);
			if (height < minHeight)
				height = minHeight;
			int width = (int)(imageRatio * pictureBox1.Size.Width);
			if (width < minWidth)
				width = minWidth;
			return new Bitmap(image, new Size(width, height));
		}

		private void Form1_SizeChanged(object sender, EventArgs e) {

			ResizeImageBox(this.Size);
			if (pictureBox1.Image != null) {
				pictureBox1.Image = ResizeImage(pictureBox1.Image);
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			if(pictureBox1.Image != null) {
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.DefaultExt=".jpg";
				saveFileDialog.Filter = "Jpeg files | *.jpg";
				saveFileDialog.ShowDialog();
				if (File.Exists(saveFileDialog.FileName)) {
					MessageBox.Show("File already exist! Can't save!");
					return;
				}
				pictureBox1.Image.Save(saveFileDialog.FileName);
			}
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
			if(pictureBox1.Image != null) {
				if (e.Button == MouseButtons.Left) {
					if (e.X > 0 && e.X < pictureBox1.Size.Width && e.Y > 0 && e.Y < pictureBox1.Size.Height) {
						Bitmap copy = new Bitmap(pictureBox1.Image);
						Graphics g = Graphics.FromImage(copy);
						g.DrawEllipse(myPen, e.X, e.Y, penWidth, penWidth);
						pictureBox1.Image = (Image)copy;
					}
				}

			}
		}

		private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e) {
			if(pictureBox1.Image != null) {
				Grayscale gray = new Grayscale(0.2125, 0.7154, 0.0721);
				Bitmap img = new Bitmap(pictureBox1.Image);
				pictureBox1.Image = (Image)(gray.Apply(img));
			}
		}

		private void sharpenToolStripMenuItem_Click(object sender, EventArgs e) {
			if (pictureBox1.Image != null) {
				Sharpen sharp = new Sharpen();
				Bitmap img = new Bitmap(pictureBox1.Image);
				pictureBox1.Image = (Image)(sharp.Apply(img));
			}
		}

		private void edgesToolStripMenuItem_Click(object sender, EventArgs e) {
			if (pictureBox1.Image != null) {
				Edges edges = new Edges();
				Bitmap img = new Bitmap(pictureBox1.Image);
				pictureBox1.Image = (Image)(edges.Apply(img));
			}
		}

		private void brushToolStripMenuItem_Click(object sender, EventArgs e) {
			BrushEditor brushEditor = new BrushEditor(penColor, penWidth);
			brushEditor.ShowDialog();
			if(brushEditor.DialogResult != DialogResult.Cancel) {
				penColor = brushEditor.SelectedColor;
				penWidth = brushEditor.size;
			}
			myPen = new Pen(penColor, penWidth);
		}
	}
}
