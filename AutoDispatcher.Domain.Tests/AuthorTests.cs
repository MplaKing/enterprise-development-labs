using AutoDispatcher.Domain.Services.InMemory;

namespace AutoDispatcher.Domain.Tests;

/// <summary>
///  Класс с юнит-тестами репозитория с авторами
/// </summary>
public class AuthorRepositoryTests 
{
    /// <summary>
    /// Параметризованный тест метода, возвращающего последние 5 книг автора
    /// </summary>
    /// <param name="authorId"></param>
    /// <param name="expectedCount"></param>
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 3)]
    [InlineData(3, 0)]
    public async Task GetLast5AuthorsBook_Success(int authorId, int expectedCount)
    {
        var repo = new DriverInMemoryRepository();
        var books = await repo.GetLast5AuthorsBook(authorId);
        Assert.Equal(expectedCount, books.Count);
    }
    /// <summary>
    /// Непараметрический тест метода, выводящего топ 5 авторов по числу страниц
    /// </summary>
    [Fact]
    public async Task GetTop5AuthorsByPageCount_Success()
    {
        var repo = new DriverInMemoryRepository();
        var authors = await repo.GetTop5AuthorsByPageCount();
        Assert.Equal(3, authors.Count);
    }
}
