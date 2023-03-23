using System;

public class SuperUser : User
{
    public string AdminPassword{ get; set; }

    public SuperUser()
	{
        this.Username = null;
        this.Password = null;
        this.IsAdmin = true;
        this.AdminPassword = null;
	}

    public SuperUser(string user, string pass, string apass)
    {
        this.Username=user;
        this.AdminPassword=apass;
        this.IsAdmin = true;
        this.Password = pass;
    }
}
