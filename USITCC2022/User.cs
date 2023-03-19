using System;

public class User
{
	public string Username { get; set; }
	public string Password { get; set; }
	public bool IsAdmin { get; set; }

	public User()
	{
		this.Username = null;
		this.Password = null;
		this.IsAdmin = false;
	}


	public bool authenticate(string username, string password)
	{
		if (this.Username == username && this.Password == password) return true; 
		else return false;
	}


}

