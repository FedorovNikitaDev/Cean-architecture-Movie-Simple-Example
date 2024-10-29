using CleanMovie.Domain;

namespace CleanMovie.Application;

//this is a use case
public interface IMovieService
{
    List<Movie> GetAllMovies();

    Movie CreateMovie(Movie movie);
}