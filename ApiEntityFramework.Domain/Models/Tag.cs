﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiEntityFramework.Domain.Models
{
	[Table("Tag")]
	public class Tag
	{
		//[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slug { get; set; }
	}
}
