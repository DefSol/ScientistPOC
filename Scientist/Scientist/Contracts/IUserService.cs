namespace Scientist.Contracts
{
    public interface IUserService
    {
        User ProcessUser(int userID);

        User InitialiseUser(int userID);
    }
}
