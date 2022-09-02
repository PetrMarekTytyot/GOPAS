namespace Calculator.Models
{
    public interface IAuth
    {
        bool LogIn(string user, string password);
    }
}