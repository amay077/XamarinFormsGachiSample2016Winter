using Prism.Mvvm;

namespace XamarinFormsGachiSample2016Winter.ViewModels
{
    public class FirstPageViewModel : BindableBase
    {
        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        public FirstPageViewModel()
        {
            Address = "hoge";
        }
    }
}