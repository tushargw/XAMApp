﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XAMApp.Models
{
	public class Login
	{
		[PrimaryKey]
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
