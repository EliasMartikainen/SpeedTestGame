using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestGame
{
    internal class Button: IButton
    {
        public ButtonColorType ColorType { get; set; }
        public ButtonLightState LightState { get; set; }

        public Button(ButtonColorType selectedColorType, ButtonLightState selectedLightState)
        {
            ColorType = selectedColorType;
            LightState = selectedLightState;
        }

        public void TurnLightOn()
        {
            LightState = ButtonLightState.On;
        }

        public void TurnLightOff()
        {
            LightState = ButtonLightState.Off;
        }

        public bool IsPressed { get; set; }
    }
}
