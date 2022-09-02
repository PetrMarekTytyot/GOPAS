using System.ComponentModel;

namespace MVVMCalc
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ICalc model;

        private int result;

        public int Result
        {
            get { return result; }
            set { 
                result = value;
                OnPropertyChanged(new PropertyChangedEventArgs(
                    nameof(Result)
                ));
            }
        }


        public MainViewModel(ICalc model)
        {
            this.model = model;
            PlusCommand = new PlusCommand(model);
            model.PropertyChanged += Model_PropertyChanged;
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        private void Model_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Result") Result = model.Result;
        }

        public PlusCommand PlusCommand { get; private set; }
            
    }
}
