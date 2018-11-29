using MVVM;
using MVVM.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _09_RSI.Service {
    public static class ShutdownService {
        public static void RequestShutdown() {
            var shouldAbortShutdown = false;

            Messenger.Default.Send(new NotificationMessageAction<bool>(
                                       Notification.ConfirmShutdown,
                                       shouldAbort => shouldAbortShutdown |= shouldAbort));

            if (!shouldAbortShutdown) {
                // This time it is for real
                Messenger.Default.Send(new NotificationMessage(Notification.NotifyShutdown));

                Application.Current.Shutdown();
            }
        }
    }
}
