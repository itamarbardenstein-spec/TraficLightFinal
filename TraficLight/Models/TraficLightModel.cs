using TraficLight.ModelsLogic;

namespace TraficLight.Models
{
    internal abstract class TraficLightModel
    {
        public enum TraficLightState
        {
            Red,
            RedYellow,
            Yellow,
            Green
        }
        public enum TraficLight
        {
            Red,
            Yellow,
            Green
        }
        protected TraficLightState currentState = TraficLightState.Red;
        protected Light[] lights = [new Light(Colors.Red,true), new Light(Colors.Yellow, false), new Light(Colors.Green, false)];
        public EventHandler<LightChengedEventArgs>? LightChanged;
        public Color RedColor => lights[(int)TraficLight.Red].Color;
        public Color YellowColor => lights[(int)TraficLight.Yellow].Color;
        public Color GreenColor => lights[(int)TraficLight.Green].Color;
        public abstract void ChangeLight();
    }
}
