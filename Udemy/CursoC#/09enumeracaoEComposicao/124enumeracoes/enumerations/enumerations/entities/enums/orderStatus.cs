using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerations.entities.enums
{
    enum orderStatus : int
    {
        pendingPayment = 0,
        processing = 1,
        shipped = 2,
        delivered = 3,

    }
}
