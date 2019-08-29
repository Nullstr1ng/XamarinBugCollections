using GalaSoft.MvvmLight.Ioc;

namespace XamarinBugCollections.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            Reg<ViewModel_Onboarding>();
        }

        void Reg<T>() where T : class
        {
            SimpleIoc.Default.Register<T>();
        }
        public static T Iof<T>() where T : class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }

        public ViewModel_Onboarding Onboarding
        {
            get { return Iof<ViewModel_Onboarding>(); }
        }
    }
}
