
// Type: KeyAuth.Main
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using DiscordRPC;
using Guna.UI2.WinForms;
using Loader;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KeyAuth
{
  public class Main : Form
  {
    private DiscordRpcClient client;
    private string chatchannel = "testing";
    private IContainer components;
    private SiticoneDragControl siticoneDragControl1;
    private SiticoneControlBox siticoneControlBox1;
    private SiticoneControlBox siticoneControlBox2;
    private SiticoneTransition siticoneTransition1;
    private Label label1;
    private SiticoneShadowForm siticoneShadowForm;
    private Timer timer1;
    private System.Windows.Forms.Panel panel1;
    private Guna2Button guna2Button1;
    private Guna2Button guna2Button2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2Button guna2Button4;
    private Dashboard dashboard1;
    private GameSpoofer gameSpoofer1;
    private Spoofer spoofer1;
    private Label expiry;
    private Label key;
    private Label lastLogin;
    private Label subscription;
    private Guna2Button guna2Button5;
    private Guna2AnimateWindow guna2AnimateWindow1;
    private UserControl2 userControl21;
    private Setting setting2;

    public Main() => this.InitializeComponent();

    private void siticoneControlBox1_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void Main_Load(object sender, EventArgs e)
    {
      if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "User")
        this.guna2Button5.Hide();
      else if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Premium User")
        this.guna2Button5.Show();
      this.userControl21.Hide();
      this.setting2.Hide();
      this.gameSpoofer1.Hide();
      this.setting2.Hide();
      this.spoofer1.Hide();
      Login.KeyAuthApp.check();
      this.key.Text = Login.KeyAuthApp.user_data.username;
      Label expiry = this.expiry;
      DateTime dateTime = this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry));
      string str1 = dateTime.ToString() ?? "";
      expiry.Text = str1;
      this.subscription.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
      Label lastLogin = this.lastLogin;
      dateTime = this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin));
      string str2 = dateTime.ToString() ?? "";
      lastLogin.Text = str2;
    }

    public DateTime UnixTimeToDateTime(long unixtime) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds((double) unixtime).ToLocalTime();

    private void guna2Button1_Click(object sender, EventArgs e)
    {
      this.dashboard1.Show();
      this.gameSpoofer1.Hide();
      this.spoofer1.Hide();
      this.key.Show();
      this.expiry.Show();
      this.lastLogin.Show();
      this.setting2.Hide();
      this.subscription.Show();
      this.userControl21.Hide();
      this.setting2.Hide();
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
      this.dashboard1.Hide();
      this.gameSpoofer1.Show();
      this.spoofer1.Hide();
      this.key.Hide();
      this.expiry.Hide();
      this.lastLogin.Hide();
      this.subscription.Hide();
      this.setting2.Hide();
      this.userControl21.Hide();
      this.setting2.Hide();
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
      this.setting2.Hide();
      this.spoofer1.Show();
      this.gameSpoofer1.Hide();
      this.dashboard1.Hide();
      this.key.Hide();
      this.expiry.Hide();
      this.lastLogin.Hide();
      this.subscription.Hide();
      this.userControl21.Hide();
      this.setting2.Hide();
    }

    private void guna2Button4_Click(object sender, EventArgs e)
    {
      this.setting2.Show();
      this.key.Hide();
      this.expiry.Hide();
      this.lastLogin.Hide();
      this.subscription.Hide();
      this.dashboard1.Hide();
      this.gameSpoofer1.Hide();
      this.userControl21.Hide();
      this.spoofer1.Hide();
    }

    private void setting1_Load(object sender, EventArgs e)
    {
    }

    private void guna2Button5_Click(object sender, EventArgs e)
    {
      this.userControl21.Show();
      this.key.Hide();
      this.expiry.Hide();
      this.lastLogin.Hide();
      this.subscription.Hide();
      this.setting2.Hide();
      this.dashboard1.Hide();
      this.gameSpoofer1.Hide();
      this.spoofer1.Hide();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void setting2_Load(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e) => Process.Start("https://discord.gg/XqwqdwcMEX");

    private void dashboard1_Load(object sender, EventArgs e)
    {
    }

    private void siticoneControlBox2_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if ((disposing ? (this.components != null ? 1 : 0) : 0) != 0)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      Animation animation = new Animation();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Main));
      this.siticoneDragControl1 = new SiticoneDragControl(this.components);
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.siticoneControlBox1 = new SiticoneControlBox();
      this.siticoneControlBox2 = new SiticoneControlBox();
      this.siticoneTransition1 = new SiticoneTransition();
      this.label1 = new Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.guna2Button5 = new Guna2Button();
      this.guna2Button4 = new Guna2Button();
      this.guna2Button2 = new Guna2Button();
      this.guna2Button1 = new Guna2Button();
      this.key = new Label();
      this.expiry = new Label();
      this.subscription = new Label();
      this.lastLogin = new Label();
      this.siticoneShadowForm = new SiticoneShadowForm(this.components);
      this.timer1 = new Timer(this.components);
      this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
      this.guna2AnimateWindow1 = new Guna2AnimateWindow(this.components);
      this.setting2 = new Setting();
      this.userControl21 = new UserControl2();
      this.spoofer1 = new Spoofer();
      this.gameSpoofer1 = new GameSpoofer();
      this.dashboard1 = new Dashboard();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.siticoneDragControl1.TargetControl = (Control) this;
      this.pictureBox1.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.pictureBox1, DecorationType.None);
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(34, 20);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(137, 86);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 24;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox1.BackColor = Color.Transparent;
      this.siticoneControlBox1.BorderRadius = 10;
      this.siticoneTransition1.SetDecoration((Control) this.siticoneControlBox1, DecorationType.None);
      this.siticoneControlBox1.FillColor = Color.Transparent;
      this.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
      this.siticoneControlBox1.HoveredState.IconColor = Color.White;
      this.siticoneControlBox1.HoveredState.Parent = (ControlBox) this.siticoneControlBox1;
      this.siticoneControlBox1.IconColor = Color.White;
      this.siticoneControlBox1.Location = new Point(641, 4);
      this.siticoneControlBox1.Name = "siticoneControlBox1";
      this.siticoneControlBox1.ShadowDecoration.Parent = (Control) this.siticoneControlBox1;
      this.siticoneControlBox1.Size = new Size(45, 29);
      this.siticoneControlBox1.TabIndex = 1;
      this.siticoneControlBox1.Click += new EventHandler(this.siticoneControlBox1_Click);
      this.siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox2.BackColor = Color.Transparent;
      this.siticoneControlBox2.BorderRadius = 10;
      this.siticoneControlBox2.ControlBoxType = ControlBoxType.MinimizeBox;
      this.siticoneTransition1.SetDecoration((Control) this.siticoneControlBox2, DecorationType.None);
      this.siticoneControlBox2.FillColor = Color.Transparent;
      this.siticoneControlBox2.HoveredState.Parent = (ControlBox) this.siticoneControlBox2;
      this.siticoneControlBox2.IconColor = Color.White;
      this.siticoneControlBox2.Location = new Point(596, 4);
      this.siticoneControlBox2.Name = "siticoneControlBox2";
      this.siticoneControlBox2.ShadowDecoration.Parent = (Control) this.siticoneControlBox2;
      this.siticoneControlBox2.Size = new Size(45, 29);
      this.siticoneControlBox2.TabIndex = 2;
      this.siticoneControlBox2.Click += new EventHandler(this.siticoneControlBox2_Click);
      this.siticoneTransition1.AnimationType = AnimationType.Rotate;
      this.siticoneTransition1.Cursor = (Cursor) null;
      animation.AnimateOnlyDifferences = true;
      animation.BlindCoeff = (PointF) componentResourceManager.GetObject("animation1.BlindCoeff");
      animation.LeafCoeff = 0.0f;
      animation.MaxTime = 1f;
      animation.MinTime = 0.0f;
      animation.MosaicCoeff = (PointF) componentResourceManager.GetObject("animation1.MosaicCoeff");
      animation.MosaicShift = (PointF) componentResourceManager.GetObject("animation1.MosaicShift");
      animation.MosaicSize = 0;
      animation.Padding = new Padding(50);
      animation.RotateCoeff = 1f;
      animation.RotateLimit = 0.0f;
      animation.ScaleCoeff = (PointF) componentResourceManager.GetObject("animation1.ScaleCoeff");
      animation.SlideCoeff = (PointF) componentResourceManager.GetObject("animation1.SlideCoeff");
      animation.TimeCoeff = 0.0f;
      animation.TransparencyCoeff = 1f;
      this.siticoneTransition1.DefaultAnimation = animation;
      this.label1.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.label1, DecorationType.None);
      this.label1.Font = new Font("Segoe UI Light", 10f);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(-1, 136);
      this.label1.Name = "label1";
      this.label1.Size = new Size(0, 19);
      this.label1.TabIndex = 22;
      this.panel1.BackColor = Color.White;
      this.panel1.BackgroundImage = (Image) componentResourceManager.GetObject("panel1.BackgroundImage");
      this.panel1.Controls.Add((Control) this.guna2Button5);
      this.panel1.Controls.Add((Control) this.guna2Button4);
      this.panel1.Controls.Add((Control) this.pictureBox1);
      this.panel1.Controls.Add((Control) this.guna2Button2);
      this.panel1.Controls.Add((Control) this.guna2Button1);
      this.siticoneTransition1.SetDecoration((Control) this.panel1, DecorationType.None);
      this.panel1.ForeColor = Color.Coral;
      this.panel1.Location = new Point(-22, -8);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(174, 592);
      this.panel1.TabIndex = 23;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.guna2Button5.BorderColor = Color.FromArgb(50, 50, 50);
      this.guna2Button5.BorderRadius = 1;
      this.guna2Button5.BorderThickness = 1;
      this.siticoneTransition1.SetDecoration((Control) this.guna2Button5, DecorationType.None);
      this.guna2Button5.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button5.FillColor = Color.FromArgb(10, 10, 10);
      this.guna2Button5.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
      this.guna2Button5.ForeColor = Color.White;
      this.guna2Button5.Image = (Image) componentResourceManager.GetObject("guna2Button5.Image");
      this.guna2Button5.ImageSize = new Size(30, 30);
      this.guna2Button5.Location = new Point(29, 262);
      this.guna2Button5.Name = "guna2Button5";
      this.guna2Button5.Size = new Size(142, 45);
      this.guna2Button5.TabIndex = 27;
      ((Control) this.guna2Button5).Text = "VIP";
      this.guna2Button5.Click += new EventHandler(this.guna2Button5_Click);
      this.guna2Button4.BorderColor = Color.FromArgb(50, 50, 50);
      this.guna2Button4.BorderRadius = 1;
      this.guna2Button4.BorderThickness = 1;
      this.siticoneTransition1.SetDecoration((Control) this.guna2Button4, DecorationType.None);
      this.guna2Button4.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button4.FillColor = Color.FromArgb(10, 10, 10);
      this.guna2Button4.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
      this.guna2Button4.ForeColor = Color.White;
      this.guna2Button4.Image = (Image) componentResourceManager.GetObject("guna2Button4.Image");
      this.guna2Button4.ImageSize = new Size(30, 30);
      this.guna2Button4.Location = new Point(29, 335);
      this.guna2Button4.Name = "guna2Button4";
      this.guna2Button4.Size = new Size(142, 45);
      this.guna2Button4.TabIndex = 26;
      ((Control) this.guna2Button4).Text = "Settings";
      this.guna2Button4.Click += new EventHandler(this.guna2Button4_Click);
      this.guna2Button2.BorderColor = Color.FromArgb(50, 50, 50);
      this.guna2Button2.BorderThickness = 1;
      this.siticoneTransition1.SetDecoration((Control) this.guna2Button2, DecorationType.None);
      this.guna2Button2.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button2.FillColor = Color.FromArgb(10, 10, 10);
      this.guna2Button2.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
      this.guna2Button2.ForeColor = Color.White;
      this.guna2Button2.Image = (Image) componentResourceManager.GetObject("guna2Button2.Image");
      this.guna2Button2.ImageSize = new Size(30, 30);
      this.guna2Button2.Location = new Point(29, 187);
      this.guna2Button2.Name = "guna2Button2";
      this.guna2Button2.Size = new Size(142, 45);
      this.guna2Button2.TabIndex = 25;
      ((Control) this.guna2Button2).Text = "Games";
      this.guna2Button2.Click += new EventHandler(this.guna2Button2_Click);
      this.guna2Button1.BorderColor = Color.FromArgb(50, 50, 50);
      this.guna2Button1.BorderThickness = 1;
      this.siticoneTransition1.SetDecoration((Control) this.guna2Button1, DecorationType.None);
      this.guna2Button1.DisabledState.BorderColor = Color.DarkGray;
      this.guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
      this.guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.guna2Button1.FillColor = Color.FromArgb(10, 10, 10);
      this.guna2Button1.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
      this.guna2Button1.ForeColor = Color.White;
      this.guna2Button1.Image = (Image) componentResourceManager.GetObject("guna2Button1.Image");
      this.guna2Button1.ImageSize = new Size(30, 30);
      this.guna2Button1.Location = new Point(29, 112);
      this.guna2Button1.Name = "guna2Button1";
      this.guna2Button1.Size = new Size(142, 45);
      this.guna2Button1.TabIndex = 24;
      ((Control) this.guna2Button1).Text = "Dashboard";
      this.guna2Button1.Click += new EventHandler(this.guna2Button1_Click);
      this.key.AutoSize = true;
      this.key.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.key, DecorationType.None);
      this.key.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.key.ForeColor = Color.White;
      this.key.Location = new Point(219, 179);
      this.key.Name = "key";
      this.key.Size = new Size(66, 15);
      this.key.TabIndex = 28;
      this.key.Text = "username";
      this.expiry.AutoSize = true;
      this.expiry.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.expiry, DecorationType.None);
      this.expiry.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.expiry.ForeColor = Color.White;
      this.expiry.Location = new Point(459, 179);
      this.expiry.Name = "expiry";
      this.expiry.Size = new Size(66, 15);
      this.expiry.TabIndex = 29;
      this.expiry.Text = "username";
      this.subscription.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.subscription, DecorationType.None);
      this.subscription.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.subscription.ForeColor = Color.White;
      this.subscription.Location = new Point(219, 321);
      this.subscription.Name = "subscription";
      this.subscription.Size = new Size(66, 15);
      this.subscription.TabIndex = 30;
      this.subscription.Text = "username";
      this.lastLogin.AutoSize = true;
      this.siticoneTransition1.SetDecoration((Control) this.lastLogin, DecorationType.None);
      this.lastLogin.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.lastLogin.ForeColor = Color.White;
      this.lastLogin.Location = new Point(459, 321);
      this.lastLogin.Name = "lastLogin";
      this.lastLogin.Size = new Size(66, 15);
      this.lastLogin.TabIndex = 31;
      this.lastLogin.Text = "username";
      this.guna2BorderlessForm1.BorderRadius = 7;
      this.guna2BorderlessForm1.ContainerControl = (ContainerControl) this;
      this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.9;
      this.guna2BorderlessForm1.DragEndTransparencyValue = 0.9;
      this.guna2BorderlessForm1.TransparentWhileDrag = true;
      this.setting2.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.setting2, DecorationType.None);
      this.setting2.Location = new Point(158, 50);
      this.setting2.Name = "setting2";
      this.setting2.Size = new Size(503, 322);
      this.setting2.TabIndex = 34;
      this.setting2.Load += new EventHandler(this.setting2_Load);
      this.userControl21.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.userControl21, DecorationType.None);
      this.userControl21.Location = new Point(158, 52);
      this.userControl21.Name = "userControl21";
      this.userControl21.Size = new Size(503, 453);
      this.userControl21.TabIndex = 33;
      this.spoofer1.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.spoofer1, DecorationType.None);
      this.spoofer1.Location = new Point(158, 52);
      this.spoofer1.Name = "spoofer1";
      this.spoofer1.Size = new Size(503, 453);
      this.spoofer1.TabIndex = 26;
      this.gameSpoofer1.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.gameSpoofer1, DecorationType.None);
      this.gameSpoofer1.Location = new Point(158, 52);
      this.gameSpoofer1.Name = "gameSpoofer1";
      this.gameSpoofer1.Size = new Size(503, 453);
      this.gameSpoofer1.TabIndex = 25;
      this.dashboard1.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.dashboard1, DecorationType.None);
      this.dashboard1.Location = new Point(158, 52);
      this.dashboard1.Name = "dashboard1";
      this.dashboard1.Size = new Size(528, 345);
      this.dashboard1.TabIndex = 24;
      this.dashboard1.Load += new EventHandler(this.dashboard1_Load);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.Disable;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(690, 389);
      this.Controls.Add((Control) this.setting2);
      this.Controls.Add((Control) this.userControl21);
      this.Controls.Add((Control) this.lastLogin);
      this.Controls.Add((Control) this.subscription);
      this.Controls.Add((Control) this.expiry);
      this.Controls.Add((Control) this.key);
      this.Controls.Add((Control) this.spoofer1);
      this.Controls.Add((Control) this.gameSpoofer1);
      this.Controls.Add((Control) this.dashboard1);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.siticoneControlBox2);
      this.Controls.Add((Control) this.siticoneControlBox1);
      this.siticoneTransition1.SetDecoration((Control) this, DecorationType.BottomMirror);
      this.ForeColor = SystemColors.ControlText;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Main);
      this.Opacity = 0.9;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Loader";
      this.TransparencyKey = Color.Maroon;
      this.Load += new EventHandler(this.Main_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
