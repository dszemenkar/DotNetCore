using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class User
{
		public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
	
}
