using Caliburn.Micro;
using Notifications.Wpf;

namespace WpfToastersTest.ViewModels
{
    public class ToasterTestMainViewModel : Screen
    {
        private readonly NotificationManager _notificationManager;

        public ToasterTestMainViewModel()
        {
            _notificationManager = new NotificationManager();
        }

        public void RaiseInformationToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Information Title",
                Message = "Sample Information Message",
                Type = NotificationType.Information
            }, "WindowArea");
        }

        public void RaiseSuccessToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Success Title",
                Message = "Sample Success Message",
                Type = NotificationType.Success
            }, "WindowArea");
        }

        public void RaiseWarningToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Warning Title",
                Message = "Sample Warning Message",
                Type = NotificationType.Warning
            }, "WindowArea");
        }

        public void RaiseErrorToast()
        {
            _notificationManager.Show(new NotificationContent
            {
                Title = "Sample Error Title",
                Message = "Sample Error Message",
                Type = NotificationType.Error
            }, "WindowArea");
        }
    }
}
