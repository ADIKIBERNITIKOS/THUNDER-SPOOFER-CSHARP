
// Type: KeyAuth.Dashboard
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KeyAuth
{
  public class Dashboard : UserControl
  {
    private IContainer components;
    private Label label1;
    private Guna2Panel guna2Panel1;
    private Label label2;
    private Guna2Panel guna2Panel2;
    private Label label3;
    private Guna2Panel guna2Panel3;
    private Label label4;
    private Guna2Panel guna2Panel4;
    private Label label5;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private Label label6;
    private Guna2PictureBox guna2PictureBox1;

    public Dashboard() => this.InitializeComponent();

    private void Dashboard_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Dashboard));
      this.label1 = new Label();
      this.guna2Panel1 = new Guna2Panel();
      this.pictureBox3 = new PictureBox();
      this.label2 = new Label();
      this.guna2Panel2 = new Guna2Panel();
      this.pictureBox2 = new PictureBox();
      this.label3 = new Label();
      this.guna2Panel3 = new Guna2Panel();
      this.pictureBox4 = new PictureBox();
      this.label4 = new Label();
      this.guna2Panel4 = new Guna2Panel();
      this.pictureBox5 = new PictureBox();
      this.label5 = new Label();
      this.label6 = new Label();
      this.guna2PictureBox1 = new Guna2PictureBox();
      this.guna2Panel1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.guna2Panel2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.guna2Panel3.SuspendLayout();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      this.guna2Panel4.SuspendLayout();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(76, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(124, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = nameof (Dashboard);
      this.guna2Panel1.BackColor = Color.FromArgb(10, 10, 10);
      this.guna2Panel1.Controls.Add((Control) this.pictureBox3);
      this.guna2Panel1.Controls.Add((Control) this.label2);
      this.guna2Panel1.Location = new Point(25, 76);
      this.guna2Panel1.Name = "guna2Panel1";
      this.guna2Panel1.Size = new Size(200, 111);
      this.guna2Panel1.TabIndex = 1;
      this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
      this.pictureBox3.Location = new Point(153, 10);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(35, 33);
      this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 5;
      this.pictureBox3.TabStop = false;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(13, 10);
      this.label2.Name = "label2";
      this.label2.Size = new Size(89, 21);
      this.label2.TabIndex = 2;
      this.label2.Text = "Username";
      this.guna2Panel2.BackColor = Color.FromArgb(10, 10, 10);
      this.guna2Panel2.Controls.Add((Control) this.pictureBox2);
      this.guna2Panel2.Controls.Add((Control) this.label3);
      this.guna2Panel2.Location = new Point(287, 76);
      this.guna2Panel2.Name = "guna2Panel2";
      this.guna2Panel2.Size = new Size(186, 111);
      this.guna2Panel2.TabIndex = 3;
      this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
      this.pictureBox2.Location = new Point(139, 10);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(35, 33);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 4;
      this.pictureBox2.TabStop = false;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(13, 10);
      this.label3.Name = "label3";
      this.label3.Size = new Size(60, 21);
      this.label3.TabIndex = 2;
      this.label3.Text = "Expiry";
      this.guna2Panel3.BackColor = Color.FromArgb(10, 10, 10);
      this.guna2Panel3.Controls.Add((Control) this.pictureBox4);
      this.guna2Panel3.Controls.Add((Control) this.label4);
      this.guna2Panel3.Location = new Point(25, 211);
      this.guna2Panel3.Name = "guna2Panel3";
      this.guna2Panel3.Size = new Size(200, 111);
      this.guna2Panel3.TabIndex = 3;
      this.pictureBox4.Image = (Image) componentResourceManager.GetObject("pictureBox4.Image");
      this.pictureBox4.Location = new Point(140, 10);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(48, 33);
      this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox4.TabIndex = 6;
      this.pictureBox4.TabStop = false;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(13, 10);
      this.label4.Name = "label4";
      this.label4.Size = new Size(109, 21);
      this.label4.TabIndex = 2;
      this.label4.Text = "Subscription";
      this.guna2Panel4.BackColor = Color.FromArgb(10, 10, 10);
      this.guna2Panel4.Controls.Add((Control) this.pictureBox5);
      this.guna2Panel4.Controls.Add((Control) this.label5);
      this.guna2Panel4.Location = new Point(287, 211);
      this.guna2Panel4.Name = "guna2Panel4";
      this.guna2Panel4.Size = new Size(186, 111);
      this.guna2Panel4.TabIndex = 4;
      this.pictureBox5.Image = (Image) componentResourceManager.GetObject("pictureBox5.Image");
      this.pictureBox5.Location = new Point(139, 10);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new Size(35, 33);
      this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox5.TabIndex = 7;
      this.pictureBox5.TabStop = false;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(13, 10);
      this.label5.Name = "label5";
      this.label5.Size = new Size(91, 21);
      this.label5.TabIndex = 2;
      this.label5.Text = "Last Login";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI Black", 5.75f, FontStyle.Bold);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(85, 49);
      this.label6.Name = "label6";
      this.label6.Size = new Size(70, 11);
      this.label6.TabIndex = 21;
      this.label6.Text = "User Inforamtion";
      this.guna2PictureBox1.FillColor = Color.Transparent;
      this.guna2PictureBox1.Image = (Image) componentResourceManager.GetObject("guna2PictureBox1.Image");
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(33, 19);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(46, 41);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 31;
      this.guna2PictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.Controls.Add((Control) this.guna2PictureBox1);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.guna2Panel4);
      this.Controls.Add((Control) this.guna2Panel3);
      this.Controls.Add((Control) this.guna2Panel2);
      this.Controls.Add((Control) this.guna2Panel1);
      this.Controls.Add((Control) this.label1);
      this.Name = nameof (Dashboard);
      this.Size = new Size(521, 345);
      this.Load += new EventHandler(this.Dashboard_Load);
      this.guna2Panel1.ResumeLayout(false);
      this.guna2Panel1.PerformLayout();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.guna2Panel2.ResumeLayout(false);
      this.guna2Panel2.PerformLayout();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.guna2Panel3.ResumeLayout(false);
      this.guna2Panel3.PerformLayout();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      this.guna2Panel4.ResumeLayout(false);
      this.guna2Panel4.PerformLayout();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
