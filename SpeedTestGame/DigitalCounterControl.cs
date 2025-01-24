using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedTestGame
{
    public partial class DigitalCounterControl : UserControl
    {
        private int _counterValue = 0;
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        private void LoadCustomFont()
        {
            // Replace "YourNamespace" with the actual namespace of your project
            string fontResourceName = "SpeedTestGame.Resources.digital_counter_7.ttf";
            using (var fontStream = typeof(DigitalCounterControl).Assembly.GetManifestResourceStream(fontResourceName))
            {
                if (fontStream == null)
                {
                    throw new Exception("Could not find font resource: " + fontResourceName);
                }

                var fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, (int)fontStream.Length);

                var fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);
            }
        }

        [Browsable(true)]
        [Category("Digital Counter")]
        [Description("Sets the counter value.")]
        public int CounterValue
        {
            get { return _counterValue; }
            set
            {
                _counterValue = value;
                UpdateDisplay();
            }
        }

        public DigitalCounterControl()
        {
            LoadCustomFont();
            InitializeComponent();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblDisplay.Text = _counterValue.ToString();
        }

        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pnlDisplayBackground = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDisplayBackground
            // 
            this.pnlDisplayBackground.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDisplayBackground.Location = new System.Drawing.Point(50, 25); // Adjust position as needed
            this.pnlDisplayBackground.Size = new System.Drawing.Size(400, 100); // Adjust size as needed
            this.pnlDisplayBackground.Controls.Add(this.lblDisplay);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(80,11,12);
            this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplay.Font = new System.Drawing.Font(privateFonts.Families[0], 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(500, 150);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DigitalCounterControl
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlDisplayBackground);
            this.Name = "DigitalCounterControl";
            this.Size = new System.Drawing.Size(500, 150);
            this.pnlDisplayBackground.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel pnlDisplayBackground;
    }
}
