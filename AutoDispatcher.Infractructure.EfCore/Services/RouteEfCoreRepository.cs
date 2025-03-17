using AutoDispatcher.Domain.Model;
using AutoDispatcher.Domain.Services;
using AutoDispatcher.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;

namespace AutoDispatcher.Infractructure.EfCore.Services;
public class RouteEfCoreRepository(AutoDispatcherDbContext context) : IRepository<Route, int>
{
    private readonly DbSet<Route> _routes = context.Routes;
    public async Task<Route> Add(Route entity)
    {
        var result = await _routes.AddAsync(entity);
        await context.SaveChangesAsync();
        return result.Entity;
    }
    
    public async Task<bool> Delete(int key)
    {
        var entity = await _routes.FirstOrDefaultAsync(e =>e.Id == key);
        if (entity == null)
            return false;
        _routes.Remove(entity);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<Route?> Get(int key) =>
        await _routes.FirstOrDefaultAsync(e => e.Id == key);
    

    public async Task<IList<Route>> GetAll() =>
        await _routes.ToListAsync();

    public async Task<Route> Update(Route entity)
    {
        _routes.Update(entity);
        await context.SaveChangesAsync();
        return (await Get(entity.Id))!;
    }

    //public async Task<IList<Tuple<string, int>>> GetLast5AuthorsBook(int key)
    //{
    //    var author = await context.Drivers.FirstOrDefaultAsync(e => e.Id == key);
    //    var books = new List<Book>();
    //    if (author != null && author.BookAuthors != null)
    //        foreach (var ba in author.BookAuthors)
    //            if (ba != null && ba.Book != null)
    //                books.Add(ba.Book);      
    //    return books.ToArray()
    //        .OrderByDescending(book => book.Year)
    //        .Take(5)
    //        .Select(book => new Tuple<string, int>(book.ToString(), book.Year ?? 0))
    //        .ToList();
    //}

    //public async Task<IList<Tuple<string, int>>> GetTop5AuthorsByPageCount() =>
    //    (await _drivers.ToArrayAsync())
    //        .OrderByDescending(author => author.GetPageCount())
    //        .Take(5)
    //        .Select(author => new Tuple<string, int>(author.ToString(), author.GetPageCount() ?? 0))
    //        .ToList();
            
    

}
