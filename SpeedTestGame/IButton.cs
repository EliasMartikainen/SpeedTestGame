using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestGame
{
    internal interface IButton
    {
        ButtonColorType ColorType { get; set; }
        ButtonLightState LightState { get; set; }
        void TurnLightOn ();
        void TurnLightOff ();
        bool IsPressed { get; set; }
    }
}
