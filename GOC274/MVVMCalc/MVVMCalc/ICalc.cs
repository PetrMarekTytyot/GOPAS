using System.ComponentModel;

namespace MVVMCalc
{
    public interface ICalc
    {
        int Result { get; }

        event PropertyChangedEventHandler? PropertyChanged;

        void Plus(int x);
    }
}