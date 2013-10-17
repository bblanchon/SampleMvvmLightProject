using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using SampleMvvmLightProject.Model;

namespace SampleMvvmLightProject.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        readonly IModel model;
        string someText;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            model = SimpleIoc.Default.GetInstance<IModel>();
            SomeText = model.SomeText;
        }

        public string SomeText
        {
            get { return someText; }
            set 
            {
                Set(() => SomeText, ref someText, value);
            }
        }
    }
}