using Common;
using System.ComponentModel.Composition;
using System.Reflection;

[Export(typeof(IOperation))]
[ExportMetadata("Symbol", '-')]
class Subtract : IOperation
{
    public int Operate(int left, int right)
    {
        return left - right;
    }

    
}