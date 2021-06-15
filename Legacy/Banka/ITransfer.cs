using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Banka
{
    public interface ITransfer:IBankaHesap
    {
        bool TransferYap(IBankaHesap aliciHesap,decimal miktar);
    }
}
