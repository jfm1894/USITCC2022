using Newtonsoft.Json;
using System;
using System.Collections.Generic;


public class Authenticator<T>
{
    public string PassedUserName { get; set; }
    public string PassedPassword { get; set; }
    public List<T> LoginData { get; set; }
    public  bool IsAdmin { get; set; }

    public Authenticator(string username, string password, List<T> data, bool accounttype)
	{
		this.PassedUserName = username;
        this.PassedPassword = password;
        this.LoginData = data;
        this.IsAdmin = accounttype;
	}

}
