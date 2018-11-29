using MVVM;
using MVVM.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace _09_RSI.Service {
    public class ShutdownAnimationService {
        private bool _shutdownAnimationHasRun;
        private FrameworkElement myElement;

        public ShutdownAnimationService(FrameworkElement element) {
            myElement = element;
            Messenger.Default.Register<NotificationMessageAction<bool>>(this, Ciao);

            Messenger.Default.Register<NotificationMessageAction<bool>>(
                this,
                message => {
                    if (message.Notification == Notification.ConfirmShutdown) {
                        if (!_shutdownAnimationHasRun) {
                            var sbd =
                                element.Resources ["ShutdownStoryboard"] as Storyboard;
                            if (sbd != null) {
                                message.Execute(true);
                                // true == abort shutdown

                                sbd.Completed += ShutdownStoryboardCompleted;
                                sbd.Begin();
                            }
                        }

                        // If the animation ran already, no need to reply
                        // to the message, allow shutdown.
                    }
                });
        }

        private void Ciao(NotificationMessageAction<bool> obj) {
            var message = obj;
            if (message.Notification == Notification.ConfirmShutdown) {
                if (!_shutdownAnimationHasRun) {
                    var sbd = myElement.Resources ["ShutdownStoryboard"] as Storyboard;
                    if (sbd != null) {
                        message.Execute(true);
                        // true == abort shutdown

                        sbd.Completed += ShutdownStoryboardCompleted;
                        sbd.Begin();
                    }
                }

                // If the animation ran already, no need to reply
                // to the message, allow shutdown.
            }
        }

        private void ShutdownStoryboardCompleted(object sender, EventArgs e) {
            _shutdownAnimationHasRun = true;

            // Now that our pre-shutdown task is done, we can request shutdown again.
            ShutdownService.RequestShutdown();
        }
    }
}
