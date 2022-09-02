using Common;
using System.ComponentModel.Composition;

[Export(typeof(IOperation))]
[ExportMetadata("Symbol", '+')]
public class Add : IOperation
{
    public int Operate(int left, int right)
    {
        return left + right;
    }
}