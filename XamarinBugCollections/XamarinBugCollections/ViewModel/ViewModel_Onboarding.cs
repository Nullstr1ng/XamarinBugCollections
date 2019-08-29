using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamarinBugCollections.Models;

namespace XamarinBugCollections.ViewModel
{
    public class ViewModel_Onboarding : ViewModelBase
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties

        #endregion

        #region commands
        public ObservableCollection<Model_OnboardingDetails> Onboarding { get; set; } = new ObservableCollection<Model_OnboardingDetails>();
        #endregion

        #region ctors
        public ViewModel_Onboarding()
        {
            InitCommands();
        }
        #endregion

        #region command methods

        #endregion

        #region methods
        void InitCommands()
        {

        }

        void DesignData()
        {

        }

        void RuntimeData()
        {

        }

        public async Task RefreshData()
        {
            this.Onboarding.Clear();

            this.Onboarding.Add(new Model_OnboardingDetails()
            {
                Title = "Lorem ipsum",
                Description = "Nulla at suscipit dolor. Ut et orci sed arcu accumsan pretium et nec tortor. Sed cursus enim et ex accumsan vulputate. Donec quis interdum nunc. Maecenas sit amet tortor vitae orci consequat euismod sed ac mauris. Nam bibendum varius augue, nec luctus leo consequat sed. Cras semper lacus a lacus mollis ullamcorper. Nam sit amet quam egestas, vestibulum lacus ut, cursus neque."
            });

            this.Onboarding.Add(new Model_OnboardingDetails()
            {
                Title = "In lacinia justo ut pharetra imperdiet",
                Description = "Pellentesque maximus ultricies tincidunt. Etiam malesuada vulputate egestas. Fusce vitae purus vitae urna finibus iaculis. Phasellus fringilla odio arcu, tincidunt mattis lorem ullamcorper sed. Phasellus consectetur tellus tellus, non congue turpis pellentesque sit amet. Mauris eu est vel sem euismod rhoncus ac quis lorem. Etiam a augue vel neque placerat porttitor ut quis leo."
            });

            this.Onboarding.Add(new Model_OnboardingDetails()
            {
                Title = "Praesent pharetra",
                Description = "Nullam sagittis at ante ultricies interdum. Nullam laoreet mauris neque, vel mattis felis gravida vel. Phasellus et risus tristique, rhoncus nulla vel, consectetur sapien. Pellentesque nec volutpat purus. Pellentesque sed ex tincidunt, iaculis turpis eu, pulvinar dolor. Nullam eleifend nulla vitae viverra fermentum. Suspendisse sed justo fermentum, interdum magna nec, interdum magna. Fusce eget efficitur velit. Aliquam massa lacus, varius quis tempor id, malesuada in eros. Sed tempor tincidunt elit eget bibendum. Quisque aliquet erat non arcu pretium, vitae pretium urna pharetra."
            });
        }
        #endregion
    }
}
