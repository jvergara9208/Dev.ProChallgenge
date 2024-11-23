using System;
using System.IO;

/// <summary>
/// Task 1: Logger
/// Simple logging function that writes messages to a text file with a timestamp.
/// Example usage:
/// Logger.LogMessage("Logs/application.log", "User logged in", "INFO")
/// Expected Output in application.log:
/// [2023-04-24 12:34:56] [INFO] User logged in
/// </summary>
public static class Logger
{
    public static void LogMessage(string filePath, string message, string severity)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{severity}] {message}";

        string? directoryPath = Path.GetDirectoryName(filePath);
        if (!string.IsNullOrEmpty(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        File.AppendAllText(filePath, logEntry + Environment.NewLine);
    }
}
