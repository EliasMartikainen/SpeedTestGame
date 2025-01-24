using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SpeedTestGame
{
    internal class ButtonLightStateChangedEventArgs : EventArgs
    {
        public ButtonColorType ButtonColor { get; }
        public ButtonLightState LightState { get; }

        public ButtonLightStateChangedEventArgs(ButtonColorType buttonColor, ButtonLightState lightState)
        {
            ButtonColor = buttonColor;
            LightState = lightState;
        }
    }

    internal class GameLogic
    {
        private const int MAX_CONSECUTIVE_MISSES = 2;
        private const int LIGHT_UP_INTERVAL = 800;

        private int _consecutiveMisses;
        private int _currentButtonIndex;
        private int _score;

        private bool _gameIsOver;
        private List<Button> _buttons;
        private List<int> _buttonIndexHistory;
        private int _currentOrderIndex;

        public event EventHandler GameOver;
        public event EventHandler<ButtonLightStateChangedEventArgs> ButtonLightStateChanged;
        public event EventHandler<int> ScoreChanged;

        private Timer _timer;

        public GameLogic()
        {
            GameInitialization();
        }

        private void GameInitialization()
        {
            _buttons = new List<Button>();
            _buttons.Add(new Button(ButtonColorType.Yellow, ButtonLightState.Off));
            _buttons.Add(new Button(ButtonColorType.Red, ButtonLightState.Off));
            _buttons.Add(new Button(ButtonColorType.Green, ButtonLightState.Off));
            _buttons.Add(new Button(ButtonColorType.Orange, ButtonLightState.Off));

            _timer = new Timer
            {
                Interval = LIGHT_UP_INTERVAL
            };
            _timer.Tick += OnTimerTick;
        }

        public void StartGame()
        {
            ResetVariables();
            _timer.Start();
        }

        private void ResetVariables()
        {
            _consecutiveMisses = 0;
            _score = 0;
            _gameIsOver = false;
            _currentButtonIndex = -1;
            _buttonIndexHistory = new List<int> { -1, -1, -1 };
            _currentOrderIndex = 0;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (_gameIsOver)
            {
                _timer.Stop();
                return;
            }

            if (_currentButtonIndex != -1 && _buttons[_currentButtonIndex].LightState == ButtonLightState.On)
            {
                _consecutiveMisses++;

                if (_consecutiveMisses >= MAX_CONSECUTIVE_MISSES)
                {
                    OnGameOver();
                    return;
                }
                ChangeLight(_currentButtonIndex, ButtonLightState.Off);
            }

            LightUp();
        }

        private void LightUp()
        {
            int currentButtonIndex;

            do
            {
                currentButtonIndex = new Random().Next(0, _buttons.Count);
            } while (currentButtonIndex == _currentButtonIndex);

            ChangeLight(currentButtonIndex, ButtonLightState.On);
            _currentButtonIndex = currentButtonIndex;
            UpdateButtonHistory(currentButtonIndex);
        }

        private void ChangeLight(int buttonIndex, ButtonLightState buttonLightState)
        {
            _buttons[buttonIndex].LightState = buttonLightState;
            OnButtonStateChanged(_buttons[buttonIndex].ColorType, buttonLightState);
        }

        private void IncrementScore()
        {
            _score++;
            OnScoreChanged();
        }

        private void UpdateButtonHistory(int currentIndex)
        {
            _buttonIndexHistory[2] = _buttonIndexHistory[1];
            _buttonIndexHistory[1] = _buttonIndexHistory[0];
            _buttonIndexHistory[0] = currentIndex;
            _currentOrderIndex = 0;
        }

        public void OnButtonClicked(int buttonIndex)
        {
            if (_gameIsOver)
            {
                return;
            }

            // Handle the case where the button clicked is the currently lit button
            if (_buttons[buttonIndex].LightState == ButtonLightState.On)
            {
                ChangeLight(buttonIndex, ButtonLightState.Off);
                IncrementScore();
                _consecutiveMisses = 0;
                return;
            }

            // Handle subsequent clicks
            if (IsButtonInHistory(buttonIndex) && IsCorrectOrder(buttonIndex))
            {
                _currentOrderIndex++;
                if (_currentOrderIndex == 3)
                {
                    CompleteOrderSequence();
                }
            }
            else
            {
                OnGameOver();
            }
        }

        private bool IsValidFirstClick(int buttonIndex)
        {
            // Check if it's the first click and the button is the currently lit button
            return _buttonIndexHistory.All(index => index == -1) && buttonIndex == _currentButtonIndex;
        }

        private void HandleFirstClick(int buttonIndex)
        {
            ChangeLight(buttonIndex, ButtonLightState.Off);
            IncrementScore();
            _consecutiveMisses = 0;
        }

        private bool IsButtonInHistory(int buttonIndex)
        {
            return _buttonIndexHistory.Contains(buttonIndex);
        }

        private bool IsCorrectOrder(int buttonIndex)
        {
            return buttonIndex == _buttonIndexHistory[2 - _currentOrderIndex];
        }

        private void CompleteOrderSequence()
        {
            ChangeLight(_buttonIndexHistory[0], ButtonLightState.Off);
            _consecutiveMisses = 0;
            IncrementScore();
            _currentOrderIndex = 0; // Reset order index for the next round
        }

        protected virtual void OnButtonStateChanged(ButtonColorType buttonColorType, ButtonLightState lightState)
        {
            ButtonLightStateChanged?.Invoke(this, new ButtonLightStateChangedEventArgs(buttonColorType, lightState));
        }

        protected virtual void OnGameOver()
        {
            _gameIsOver = true;
            _timer.Stop();
            GameOver?.Invoke(this, EventArgs.Empty);

            foreach (var button in _buttons)
            {
                ChangeLight(_buttons.IndexOf(button), ButtonLightState.Off);
            }
        }

        protected virtual void OnScoreChanged()
        {
            ScoreChanged?.Invoke(this, _score);
        }
    }
}


