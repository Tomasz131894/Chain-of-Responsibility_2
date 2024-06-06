using Chain_of_Responsibility_2;

class Program
{
    static void Main(string[] args)
    {
        // Tworzymy łańcuch logowania
        var infoHandler = new InfoLogHandler();
        var warningHandler = new WarningLogHandler();
        var errorHandler = new ErrorLogHandler();

        // Konfigurujemy łańcuch logowania
        infoHandler.SetNextHandler(warningHandler);
        warningHandler.SetNextHandler(errorHandler);

        // Testujemy logowanie
        infoHandler.HandleLog("To jest komunikat INFO", LogLevel.INFO);
        infoHandler.HandleLog("To jest komunikat WARNING", LogLevel.WARNING);
        infoHandler.HandleLog("To jest komunikat ERROR", LogLevel.ERROR);
    }
}