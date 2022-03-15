using ApiEntityFramework.Domain;
using ApiEntityFramework.Domain.Models;
using ApiEntityFramework.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEntityFramework.Application
{
	public class TagService : ITagService
	{
		TagWriteOnlyRepository _tagWriteOnlyRepository;
		public TagService(TagWriteOnlyRepository tagWriteOnlyRepository)
		{
			_tagWriteOnlyRepository = tagWriteOnlyRepository;
		}

		public async Task<bool> Create(Tag tag)
		{
			var tags = await _tagWriteOnlyRepository.Create(tag);

			return true;
		}

		public async Task<bool> Update(Tag tag)
		{
			var tags = await _tagWriteOnlyRepository.Update(tag);

			return true;
		}

		public async Task<bool> Delete(Tag tag)
		{
			var tags = await _tagWriteOnlyRepository.Delete(tag);

			return true;
		}

		public async Task<IEnumerable<Tag>> List()
		{
			var tags = await _tagWriteOnlyRepository.List();

			return tags;
		}
	}
}
