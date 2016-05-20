namespace POC.Contracts
{
    public interface IUserService
    {
        User ProcessUserExperiment(int userID);

        User ProcessUser(int userID);

        User InitialiseUser(int userID);
    }
}
