using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedTestGame
{

    public partial class GameWindow : Form
    {
        private GameLogic _gameLogic;

        private static readonly Dictionary<ButtonColorType, int> ButtonColorIndexDictionary = new Dictionary<ButtonColorType, int>()
        {
            { ButtonColorType.Yellow, 0 },
            { ButtonColorType.Red, 1 },
            { ButtonColorType.Green, 2 },
            { ButtonColorType.Orange, 3 },
        };

        private readonly Dictionary<ButtonColorType, (System.Windows.Forms.Button, Image litImage, Image defaultImage)> _buttonImageChangeDictionary;

        public GameWindow()
        {
            InitializeComponent();
            ToggleColorButtonEnable(false);
            _buttonImageChangeDictionary = new Dictionary<ButtonColorType, (System.Windows.Forms.Button, Image litImage, Image defaultImage)>
            {
                { ButtonColorType.Green, (greenButton, Properties.Resources.GreenButtonLit, Properties.Resources.GreenButton) },
                { ButtonColorType.Orange, (orangeButton, Properties.Resources.OrangeButtonLit, Properties.Resources.OrangeButton) },
                { ButtonColorType.Red, (redButton, Properties.Resources.RedButtonLit, Properties.Resources.RedButton) },
                { ButtonColorType.Yellow, (yellowButton, Properties.Resources.YellowButtonLit, Properties.Resources.YellowButton) }
            };

            _gameLogic = new GameLogic();
            _gameLogic.GameOver += OnGameOver;
            _gameLogic.ButtonLightStateChanged += OnButtonLightStateChanged;
            _gameLogic.ScoreChanged += OnScoreChanged;
        }

        private void ToggleColorButtonEnable(bool enabledBool)
        {
            redButton.Enabled = enabledBool;
            greenButton.Enabled = enabledBool;
            yellowButton.Enabled = enabledBool;
            orangeButton.Enabled = enabledBool;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Make the application fullscreen
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

        }

        public int GetButtonIndex(ButtonColorType colorType)
        {
            if (ButtonColorIndexDictionary.TryGetValue(colorType, out int index))
            {
                return index;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(colorType));
            }
        }

        private void OnGameOver(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!");
            resetGameButton.Enabled = true;
            ToggleColorButtonEnable(false);
        }

        private void OnResetGameButtonClicked(object sender, EventArgs e)
        {
            resetGameButton.Enabled = false;
            digitalCounter.CounterValue = 0;
            Task.Delay(2000);
            _gameLogic.StartGame();
            ToggleColorButtonEnable(true);
        }

        private void OnStartGameButtonClicked(object sender, EventArgs e)
        {
            startGameButton.Enabled = false;
            startGameButton.Visible = false;

            _gameLogic.StartGame();
            ToggleColorButtonEnable(true);
            resetGameButton.Visible = true;
            resetGameButton.Enabled = false;
        }

        private void OnExitGameButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnYellowButtonClicked(object sender, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(ButtonColorType.Yellow);
            _gameLogic.OnButtonClicked(buttonIndex);
        }

        private void OnRedButtonClicked(object sender, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(ButtonColorType.Red);
            _gameLogic.OnButtonClicked(buttonIndex);
        }

        private void OnGreenButtonClicked(object sender, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(ButtonColorType.Green);
            _gameLogic.OnButtonClicked(buttonIndex);
        }

        private void OnOrangeButtonClicked(object sender, EventArgs e)
        {
            var buttonIndex = GetButtonIndex(ButtonColorType.Orange);
            _gameLogic.OnButtonClicked(buttonIndex);
        }

        private void OnButtonLightStateChanged(object sender, ButtonLightStateChangedEventArgs e)
        {
            if (_buttonImageChangeDictionary.TryGetValue(e.ButtonColor, out var mapping))
            {
                mapping.Item1.BackgroundImage = e.LightState == ButtonLightState.On ? mapping.litImage : mapping.defaultImage;
            }
            else
            {
                Console.WriteLine("The color type couldn't be identified in OnButtonLightStateChanged");
            }
        }

        private void OnScoreChanged(object sender, int e)
        {
            digitalCounter.CounterValue = e;
        }
    }
}
