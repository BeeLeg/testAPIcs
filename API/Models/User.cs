﻿using System;
namespace API.Models
{
	public class User
	{
		public int Id { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string role { get; set; }
		public string email { get; set; }
		public string adresse { get; set; }
	}
}

