namespace BlazorComponentCommunicationTutorial.Services
{
    public class NotificationService : INotificationService
    {
        public int Count { get; set; } = 0;

        public event Action OnChange;

        public void IncrementCounter()
        {
            Count++;
            OnChange?.Invoke();
        }

        public void ResetCount()
        {
            Count = 0;
            OnChange?.Invoke();
        }
    }
}
