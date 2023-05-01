using System;
namespace API.Services

{ 
	public interface IUserService
	{
		IEnumerable<Models.User> GetAll();
	}

	public class UserService : IUserService
	{
		private MyDBContext _context;

		public UserService(MyDBContext context)
		{
			_context = context;
		}

		public IEnumerable<Models.User> GetAll()
		{
			return _context.User;
		}
	}
}

