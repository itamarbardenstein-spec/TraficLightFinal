using TraficLight.Models;

namespace TraficLight.ModelsLogic
{
    internal class TraficLight : TraficLightModel
    {
        public override void ChangeLight()
        {
            if (currentState == TraficLightState.Red)
            {
                currentState = TraficLightState.RedYellow;
                lights[(int)TraficLight.Yellow].IsOn = true;
                LightChanged?.Invoke(this, new LightChengedEventArgs(TraficLight.Yellow));
            }
            else if (currentState == TraficLightState.RedYellow)
            {
                currentState = TraficLightState.Green;
                lights[(int)TraficLight.Red].IsOn = false;
                lights[(int)TraficLight.Yellow].IsOn = false;
                lights[(int)TraficLight.Green].IsOn = true;
                for (int i = 0; i < 3; i++)
                    LightChanged?.Invoke(this, new LightChengedEventArgs((TraficLight)i));
            }
            else if (currentState == TraficLightState.Green)
            {
                currentState = TraficLightState.Yellow;
                lights[(int)TraficLight.Green].IsOn = false;
                lights[(int)TraficLight.Yellow].IsOn = true;
                for (int i = 1; i < 3; i++)
                    LightChanged?.Invoke(this, new LightChengedEventArgs((TraficLight)i));
            }
            else if (currentState == TraficLightState.Yellow)
            {
                currentState = TraficLightState.Red;
                lights[(int)TraficLight.Red].IsOn = true;
                lights[(int)TraficLight.Yellow].IsOn = false;
                for (int i = 0; i < 2; i++)
                    LightChanged?.Invoke(this, new LightChengedEventArgs((TraficLight)i));
            }
        }
    }
}
