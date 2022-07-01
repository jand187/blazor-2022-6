using System.ComponentModel.DataAnnotations;

namespace web.Model;

public class Person
{
	public string Firstname { get; set; }
	public string Lasstname { get; set; }
	public Email Email{ get; set; }
}

public class Email
{
	[EmailAddress]
	public string Address { get; set; }
}