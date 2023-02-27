using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Entities;
using TatBlog.Data.Contexts;

namespace TatBlog.Services.Blogs;

public class BlogRepository : IBlogRepository
{
	private readonly BlogRepository _context;
	public BlogRepository(BlogDbContext context)
	{
		_context = context;
	}
	//Tìm bài viết có tên định danh là 'slug' và được đăng vào month và year
	public Task<Post> GetPostAsync(int year, int month, string slug,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
	//Tìm top n bải viết phổ được nhiều người xem nhất
	public Task<IList<Post>> GetPopularArticlesAsync(int numPosts,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
	//Kiểm tra tên định danh của bài viết đã có hay chưa
	public Task<bool> IsPostSlugExistedAsync(int postId, string slug,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
	//Tăng số lượt xem của một bài viết
	public Task IncreaseViewCountAsync(int postId,
		CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	Task<List<Post>> IBlogRepository.GetPopularArticlesAsync(int numPosts, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public static implicit operator BlogRepository(BlogDbContext v)
	{
		throw new NotImplementedException();
	}
}
