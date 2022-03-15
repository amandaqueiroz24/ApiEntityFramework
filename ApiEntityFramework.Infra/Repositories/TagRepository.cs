using ApiEntityFramework.Domain;
using ApiEntityFramework.Domain.Models;
using ApiEntityFramework.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEntityFramework.Infra.Repositories
{
	public class TagRepository : TagWriteOnlyRepository
	{
		public async Task<bool> Create(Tag tag)
		{
			try
			{
				await using (var context = new BlogDataContext())
				{
					var tags = new Tag { Name = tag.Name, Slug = tag.Slug };
					context.Tags.Add(tags);
					context.SaveChanges();

				}

				return true;
			}catch(Exception ex)
			{
				return false;
			}
		}

		public async Task<bool> Update(Tag tag)
		{
			try
			{
				await using (var context = new BlogDataContext())
				{
					var tags = context.Tags.FirstOrDefault(x => x.Id == tag.Id);
					tags.Name = tag.Name;
					tags.Slug = tag.Slug;
					context.Tags.Update(tags);
					context.SaveChanges();

				}

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<bool> Delete(Tag tag)
		{
			try
			{
				await using (var context = new BlogDataContext())
				{
					var tags = context.Tags.FirstOrDefault(x => x.Id == tag.Id);
					context.Tags.Remove(tags);
					context.SaveChanges();

				}

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<IEnumerable<Tag>> List()
		{
			try
			{
				await using (var context = new BlogDataContext())
				{
					var tags = context
						.Tags
						.ToList();

					return tags;

				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
