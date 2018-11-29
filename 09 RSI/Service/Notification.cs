using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.Service {
    public static class Notification {
        public static readonly string ConfirmShutdown = Guid.NewGuid().ToString();

        public static readonly string NotifyShutdown = Guid.NewGuid().ToString();
    }
}
