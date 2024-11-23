using System;
using System.IO;
using Xunit;

/// <summary>
/// Task 1.1: Tests
/// Test scenarios for the Logger class.
/// Expected Output: Entries in the log file with correct messages and timestamps.
/// </summary>
public class LoggerTests
{
    [Fact]
    public void LogMessage_WritesCorrectEntry()
    {
        string directoryPath = "Logs";
        string filePath = Path.Combine(directoryPath, "test.log");
        string message = "User logged in";
        string severity = "INFO";

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        Logger.LogMessage(filePath, message, severity);

        string lastLine = File.ReadAllLines(filePath)[^1];
        Assert.Contains(message, lastLine);
        Assert.Contains(severity, lastLine);
        Assert.True(File.Exists(filePath));
    }

    [Fact]
    public void LogMessage_WritesWithTimestamp()
    {
        string directoryPath = "Logs";
        string filePath = Path.Combine(directoryPath, "test.log");
        string message = "Test entry";
        string severity = "DEBUG";

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        Logger.LogMessage(filePath, message, severity);

        string lastLine = File.ReadAllLines(filePath)[^1];
        Assert.Contains(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), lastLine);
    }
}
