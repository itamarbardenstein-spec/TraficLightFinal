using System.Windows.Input;

namespace TraficLight.ViewModels
{
    class MainPageVM
    {
        public ICommand ChangeLightCommand { get;}
        public MainPageVM() 
        {
            ChangeLightCommand = new Command(ChangeLight);
        }

        private void ChangeLight()
        {
            
        }
    }
}
