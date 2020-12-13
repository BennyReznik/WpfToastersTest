using Caliburn.Micro;
using Notifications.Wpf;
using System;
using System.Windows;
using ToastNotifications;
using ToastNotifications.Core;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace WpfToastersTest.ViewModels
{
    public class ToasterTestMainViewModel : Screen
    {
        private readonly NotificationManager _notificationManager;
        private readonly Notifier _notifier;

        public ToasterTestMainViewModel()
        {
            _notificationManager = new NotificationManager();
            _notifier = new Notifier(c =>
            {
                c.PositionProvider = new WindowPositionProvider(
                    parentWindow: Application.Current.MainWindow,
                    corner: Corner.BottomRight,
                    offsetX: 10,
                    offsetY: 10);
                c.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(TimeSpan.FromMilliseconds(3000), MaximumNotificationCount.FromCount(4));
            });
        }

        #region Notifications.WPF

        public void RaiseInformationToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Information Title",
                Message = "Sample Information Message",
                Type = NotificationType.Information
            }, "WindowArea", TimeSpan.FromMilliseconds(3000));
        }

        public void RaiseSuccessToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Success Title",
                Message = "Sample Success Message",
                Type = NotificationType.Success
            }, "WindowArea", TimeSpan.FromMilliseconds(3000));
        }

        public void RaiseWarningToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Warning Title",
                Message = "Sample Warning Message",
                Type = NotificationType.Warning
            }, "WindowArea", TimeSpan.FromMilliseconds(3000));
        }

        public void RaiseErrorToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Error Title",
                Message = "Sample Error Message",
                Type = NotificationType.Error
            }, "WindowArea", TimeSpan.FromMilliseconds(3000));
        }

        #endregion

        #region ToastNotifications

        public void RaiseInformationToast1()
        {
            var options = new MessageOptions()
            {
                FontSize = 20,
                ShowCloseButton = false,
                Tag = "Some Tag",
                FreezeOnMouseEnter = true,
                NotificationClickAction = n =>
                {
                    n.Close();
                }
            };

            _notifier.ShowInformation("Information Message", options);
        }

        public void RaiseSuccessToast1()
        {
            var options = new MessageOptions()
            {
                FontSize = 20,
                ShowCloseButton = false,
                Tag = "Some Tag",
                FreezeOnMouseEnter = true,
                NotificationClickAction = n =>
                {
                    n.Close();
                }
            };

            _notifier.ShowSuccess("Success Message", options);
        }

        public void RaiseWarningToast1()
        {
            var options = new MessageOptions()
            {
                FontSize = 20,
                ShowCloseButton = false,
                Tag = "Some Tag",
                FreezeOnMouseEnter = true,
                NotificationClickAction = n =>
                {
                    n.Close();
                }
            };

            _notifier.ShowWarning("Warning Message", options);
        }

        public void RaiseErrorToast1()
        {
            var options = new MessageOptions()
            {
                FontSize = 20,
                ShowCloseButton = true,
                Tag = "Some Tag",
                FreezeOnMouseEnter = true,
                NotificationClickAction = n =>
                {
                    n.Close();
                }
            };

            _notifier.ShowError("Error Message", options);
        }

        #endregion
    }
}
