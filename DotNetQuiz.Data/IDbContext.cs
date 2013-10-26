namespace DotNetQuiz.Data
{
    using System.Collections.Generic;

    public interface IDbContext
    {
        IEnumerable<T> SelectAll<T>();
    }
}