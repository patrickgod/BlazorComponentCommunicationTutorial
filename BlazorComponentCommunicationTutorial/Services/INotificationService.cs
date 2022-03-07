namespace BlazorComponentCommunicationTutorial.Services
{
    public interface INotificationService
    {
        event Action OnChange;
        int Count { get; set; }
        void IncrementCounter();
        void ResetCount();
    }
}
