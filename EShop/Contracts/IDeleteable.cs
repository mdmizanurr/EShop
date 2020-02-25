using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Contracts
{
    public interface IDeleteable
    {
        bool IsDeleted { get; set; }
        int? DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }

        string   DeleteRemarks { get; set; }

    }
}
