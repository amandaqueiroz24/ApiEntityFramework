﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiEntityFramework.Domain.Models
{
	public class Role
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }
	}
}
