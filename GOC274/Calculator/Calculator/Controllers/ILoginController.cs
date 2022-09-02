namespace Calculator.Controllers
{
    public interface ILoginController
    {
        bool LoggedIn { get; }
        IView LogInView { get; set; }

        void LogInAction(string user, string password);
    }
}