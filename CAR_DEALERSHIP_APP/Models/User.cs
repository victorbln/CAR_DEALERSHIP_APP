using System;

public class User
{
    public int Id { get; set; }
    private string? Role { get; set; }
    private string? Age { get; set; }
    private string? Name { get; set; }
    private string? Password { get; set; }
    private string? Email { get; set; }
    private string? PhoneNumber { get; set; } = string.Empty;
    private Address Address { get; set; }

    public User()
	{
		this.Address = new Address();
	}
}
