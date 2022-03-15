using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiEntityFramework.Domain.Service;
using ApiEntityFramework.Domain.Models;

namespace EntityFrameworkCore.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TagController : ControllerBase
	{
	
		ITagService _tagService;


		public TagController(ITagService tagService)
		{
			_tagService = tagService;
		}

		[HttpPost]
		public async Task<ActionResult> Post(Tag tag)
		{
			var tags = await _tagService.Create(tag);

			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult> Put(Tag tag)
		{
			var tags = await _tagService.Update(tag);

			return Ok();
		}

		[HttpDelete]
		public async Task<ActionResult> Delete(Tag tag)
		{
			var tags = await _tagService.Delete(tag);

			return Ok();
		}

		[HttpGet]
		public async Task<IEnumerable<Tag>> Get()
		{
			var tags = await _tagService.List();

			return tags;
		}
	}
}
