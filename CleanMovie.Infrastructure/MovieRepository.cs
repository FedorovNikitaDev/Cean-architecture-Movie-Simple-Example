using CleanMovie.Application;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure;

public class MovieRepository : IMovieRepository
{
    private readonly MovieDbContext _movieDbContext;
    
    public MovieRepository(MovieDbContext movieDbContext)
    {
        _movieDbContext = movieDbContext;
    }
        
    public List<Movie> GetAllMovies()
    {
        var movies = _movieDbContext.Movies.ToList();
        return movies;
    }

    public Movie CreateMovie(Movie movie)
    {
        _movieDbContext.Movies.Add(movie);
        _movieDbContext.SaveChanges();

        return movie;
    }
}