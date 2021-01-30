using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    interface ICompaniesService
    {
        void NewCompanyAdd(Companies companies);
        void OldCompanyDelete(Companies companies);
        void OldCompanyUpdate(Companies companies);
    }
}
