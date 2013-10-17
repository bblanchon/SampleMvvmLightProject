using GalaSoft.MvvmLight;
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
            if (IsInDesignMode)
            {
                // code runs in blend --> create design time data.
                model = new DesignTimeModel();
            }
            else
            {
                // code runs "for real"
                model = new RunTimeModel();
            }

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