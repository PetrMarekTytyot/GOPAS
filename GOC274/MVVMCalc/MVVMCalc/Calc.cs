using System.ComponentModel;

namespace MVVMCalc
{
    public class Calc : INotifyPropertyChanged, ICalc
    {
        private int result;
        public int Result
        {
            get => result;
            private set
            {
                result = value;
                OnPropertyChanged(
                    new PropertyChangedEventArgs(nameof(Result))
                );
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged(this, e);
        }

        public void Plus(int x) => Result += x;
    }
}
