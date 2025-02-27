namespace Inheritance;

public class Except: Exception
{
public Except() : base("Invalid operationa has been dectected"){}

public Except(string message): base(message){}

public Except(string message, Exception innerException): base(message,innerException){}
}
