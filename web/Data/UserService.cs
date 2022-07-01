using web.Model;

namespace web.Data;

public interface IUserService
{
	List<User> GetUsers();
}

public class UserService : IUserService
{
	public List<User> GetUsers()
	{
		return new List<User>
		{
			new User
			{
				Username = "hanluc",
				Firstname = "Hansemann",
				Lastname = "Luchter"
			},
			new User
			{
				Username = "wilhar",
				Firstname = "Wili",
				Lastname = "Hartmeyer"
			}

		};
	}
}