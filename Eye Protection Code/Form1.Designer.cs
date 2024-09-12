using Eye_Protection;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Task_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemHide;
        private ToolStripMenuItem toolStripMenuItemShow;
        private Timer filterTimer = new Timer();
        private TimeSpan startTime = new TimeSpan(8, 0, 0);  
        private TimeSpan endTime = new TimeSpan(17, 0, 0);   

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            button8 = new Button();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button7 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            contextMenuStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 277);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            label2.SizeChanged += CloseToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Eye Protection";
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(115, 52);
            contextMenuStrip2.Text = "Open";
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.Gray;
            openToolStripMenuItem.ForeColor = Color.Black;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 24);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = Color.Gray;
            closeToolStripMenuItem.ForeColor = Color.Black;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(114, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(13, 20);
            button1.Name = "button1";
            button1.Size = new Size(149, 36);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(13, 62);
            button2.Name = "button2";
            button2.Size = new Size(149, 36);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(219, 62);
            button3.Name = "button3";
            button3.Size = new Size(149, 36);
            button3.TabIndex = 9;
            button3.Text = "Time";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 369);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(13, 150);
            label6.Name = "label6";
            label6.Size = new Size(168, 30);
            label6.TabIndex = 22;
            label6.Text = "VERSION 1.6";
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(219, 147);
            button8.Name = "button8";
            button8.Size = new Size(149, 36);
            button8.TabIndex = 21;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(80, 210, 250);
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 256);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 20;
            label1.Text = "00:00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(76, 228);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(199, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(191, 155);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 17;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(13, 104);
            button7.Name = "button7";
            button7.Size = new Size(149, 36);
            button7.TabIndex = 16;
            button7.Text = "Background Color";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(219, 104);
            button6.Name = "button6";
            button6.Size = new Size(149, 36);
            button6.TabIndex = 15;
            button6.Text = "About Program";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 64, 0);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(219, 20);
            button5.Name = "button5";
            button5.Size = new Size(149, 36);
            button5.TabIndex = 12;
            button5.Text = "Developer";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(406, 393);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Eye Protection";
            Load += Form1_Load_1;
            Resize += Form1_Resize;
            contextMenuStrip2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Form1 form1 = null;

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNotifyIcon();
        }

        private void InitializeNotifyIcon()
        {
            throw new NotImplementedException();
        }

        private void HideForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Hide();
            }
        }

        private void ShowForm(object sender, EventArgs e)
        {
            if (form1 != null && !form1.IsDisposed)
            {
                form1.Show();
                form1.WindowState = FormWindowState.Normal;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (form1 == null || form1.IsDisposed)
                {
                    form1 = new Form1();
                    form1.FormClosed += (s, args) => form1 = null;
                    form1.Show();
                }
                else
                {
                    form1.WindowState = FormWindowState.Normal;
                    form1.Activate();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                this.Hide();
                notifyIcon1.Visible = true;
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void FilterTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            if (currentTime >= startTime && currentTime <= endTime)
            {
                ApplyScreenFilter(); 
            }
            else
            {
            }
        }

        private void ApplyScreenFilter()
        {
            try
            {
                SetGammaRamp(selectedRedGamma, selectedGreenGamma, selectedBlueGamma);
            }
            catch (Exception)
            {
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ApplyScreenFilter();
        }

        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(IntPtr hdc, void* ramp);

        [DllImport("gdi32.dll")]
        private static extern bool SetDeviceGammaRamp(IntPtr hdc, ref RampParams ramp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RampParams
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Red;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Green;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public ushort[] Blue;
        }

        private void SetGammaRamp(float red, float green, float blue)
        {
            RampParams ramp = new RampParams
            {
                Red = CalculateGammaRamp(red),
                Green = CalculateGammaRamp(green),
                Blue = CalculateGammaRamp(blue)
            };

            IntPtr hdc = IntPtr.Zero;

            try
            {
                hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
                SetDeviceGammaRamp(hdc, ref ramp);
            }
            finally
            {
                if (hdc != IntPtr.Zero)
                    Graphics.FromHwnd(IntPtr.Zero).ReleaseHdc(hdc);
            }
        }

        private ushort[] CalculateGammaRamp(float gamma)
        {
            const int size = 256;
            ushort[] ramp = new ushort[size];

            for (int i = 0; i < size; i++)
            {
                ramp[i] = (ushort)Math.Min(65535, Math.Pow(i / 255.0, 1.0 / gamma) * 65535);
            }

            return ramp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterTimer.Start();  
            ApplyScreenFilter();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterTimer.Stop();  
            RestoreDefaultGamma();  
        }

        private void RestoreDefaultGamma()
        {
            try
            {
                SetGammaRamp(1.0f, 1.0f, 1.0f); 
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                groupBox1.ClientRectangle,
                Color.Purple, 
                Color.Blue, 
                LinearGradientMode.Vertical); 

            e.Graphics.FillRectangle(gradientBrush, groupBox1.ClientRectangle);
        }

        private Form _openForm = null;

        private void OpenForm(Form form)
        {
            if (_openForm != null)
            {
                _openForm.Close();
            }

            _openForm = form;
            _openForm.FormClosed += (s, args) => _openForm = null;
            _openForm.Show();
        }

        private Form2 form2Instance;

        private void button5_Click(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2(this);
                form2Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form3 form3Instance;

        private void button6_Click(object sender, EventArgs e)
        {
            if (form3Instance == null || form3Instance.IsDisposed)
            {
                form3Instance = new Form3(this);
                form3Instance.Show();
            }
            else
            {
                //
            }
        }

        private Form4 form4Instance;

        private void button7_Click(object sender, EventArgs e)
        {
            if (form4Instance == null || form4Instance.IsDisposed)
            {
                form4Instance = new Form4(this);
                form4Instance.Show();
            }
            else
            {
                //
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetSelectedColor(float redGamma, float greenGamma, float blueGamma)
        {
            selectedRedGamma = redGamma;
            selectedGreenGamma = greenGamma;
            selectedBlueGamma = blueGamma;
        }

        private Label label2;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button7;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label1;
        private float selectedRedGamma = 1.0f;
        private float selectedGreenGamma = 1.0f;
        private float selectedBlueGamma = 1.0f;
        private Button button8;
        private Label label6;
    }
}