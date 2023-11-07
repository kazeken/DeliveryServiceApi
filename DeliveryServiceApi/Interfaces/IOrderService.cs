using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryServiceApi.Interfaces
{
    public interface IOrderService
    {
        public bool IsFreeCourierAvailable();
    }
}
