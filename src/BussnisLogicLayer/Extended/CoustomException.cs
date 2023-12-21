namespace BussnisLogicLayer.Extended;

public class CustomException(string message) : Exception
{
    private string ErrorMessage { get; } = message;
}