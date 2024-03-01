namespace PhoneBook.Brokers;
   public interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(Exception exception);
    }