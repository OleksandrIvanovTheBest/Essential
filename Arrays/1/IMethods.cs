using System.Collections.Generic;

namespace Arrays
{
    interface IMethods
    {
        void Show();
        int Max { get; }
        int Min { get; }
        int Sum { get; }
        int Average { get; }
        List<int> OddElements { get; }
    }
}
