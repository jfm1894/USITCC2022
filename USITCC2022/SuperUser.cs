using System;

public class SuperUser : User
{
    public string AdminPassword{ get; set; }

    public SuperUser()
	{
        this.Username = null;
        this.AdminPassword = null;
        this.IsAdmin = true;
        this.AdminPassword = null;
	}
}
