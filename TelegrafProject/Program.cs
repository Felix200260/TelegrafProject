var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Путь к файлу лога
string logPath = Path.Combine(Directory.GetCurrentDirectory(), "logs", "reagent.log");
Directory.CreateDirectory(Path.GetDirectoryName(logPath)!);

// Эмуляция создания логов каждые 5 секунд
var timer = new Timer(WriteLog, logPath, TimeSpan.Zero, TimeSpan.FromSeconds(5));

app.MapGet("/", () => "Log Emulator работает! Проверь файл logs/reagent.log");

app.Run();

static void WriteLog(object? state)
{
    string logPath = (string)state!;
    string logEntry = GenerateRealisticLog();
    
    File.AppendAllText(logPath, logEntry + Environment.NewLine);
    Console.WriteLine($"Записан лог: {logEntry}");
}

static string GenerateRealisticLog()
{
    var random = Random.Shared;
    var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");
    
    var logTypes = new[] { "INFO", "DEBUG", "ERROR", "FATAL", "WARN" };
    var logType = logTypes[random.Next(logTypes.Length)];
    
    var components = new[] { 
        "Core.AnalysisResultReciever", 
        "Network.Tcp.TcpServer.Server", 
        "ReagentPDK.PluginAbstract.AnalyzerPlugin",
        "Topshelf.Hosts.ConsoleRunHost"
    };
    var component = components[random.Next(components.Length)];
    
    var messages = logType switch
    {
        "INFO" => new[] {
            "Reagent service start",
            "Service started",
            "Анализатор Maglumi800 (Maglumi800) готов к подключению",
            "Анализатор Lazurite (Lazurite) готов к подключению",
            "The LIS:Reagent service is now running",
            "Restarting reagent service"
        },
        "ERROR" or "FATAL" => new[] {
            "System.Net.Sockets.SocketException (0x80004005): Обычно разрешается только одно использование адреса сокета",
            "Connection timeout occurred",
            "Failed to bind to port 8080"
        },
        "DEBUG" => new[] {
            "Running as a console application",
            "Starting up as a console application",
            "Processing analyzer data"
        },
        _ => new[] { "System operation completed" }
    };
    
    var message = messages[random.Next(messages.Length)];
    
    return $"{timestamp}|{logType}|{component}|{message}";
}
