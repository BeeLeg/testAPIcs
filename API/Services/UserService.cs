using System;
using System.Collections;
using System.Collections.Generic;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Services

{ 
	public interface IUserService
	{
		IList GetAll();
		IList GetUserById(int Id);
		IList GetAllRestricted();
	}

	public class UserService : IUserService
	{
        private const string V = "toto";
        private MyDBContext _context;

		public UserService(MyDBContext context)
		{
			_context = context;
		}

		public IList GetAll()
		{
			return _context.User.ToList();
		}

		public IList GetAllRestricted()
		{
			return _context.User.Select(u => new { u.username, u.adresse, u.email, V }).ToList();
		}

		public IList GetUserById(int Id)
		{
			return _context.User.Where(u => u.Id == Id).Select(u => new { u.username, u.adresse }).ToList();
        }
	}
}

