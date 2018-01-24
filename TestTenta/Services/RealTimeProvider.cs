using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTenta.Interfaces;

namespace TestTenta.Services
{
    public class RealTimeProvider : ITimeProvider
    {
        public DateTime Now
        {
            get => DateTime.Now;
            set => throw new NotImplementedException();
        }
    }
}
