﻿using ApiEntityFramework.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEntityFramework.Domain.Service
{
	public interface ITagService
	{
		Task<bool> Create(Tag tag);
		Task<bool> Update(Tag tag);
		Task<bool> Delete(Tag tag);
		Task<IEnumerable<Tag>> List();

	}
}
