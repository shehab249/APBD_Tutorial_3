namespace Tutorial_3.Exceptions;

public class OverfillException(string message = "Maximum payload is exceeded") : Exception(message);