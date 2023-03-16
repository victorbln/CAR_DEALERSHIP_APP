using System;

public class Vehicle
{
	public int? Id { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public string? Year { get; set; }
	public string? Producer { get; set; }
	public int? Amount { get; set; } = 0;

	public Vehicle()
	{
	}

}
