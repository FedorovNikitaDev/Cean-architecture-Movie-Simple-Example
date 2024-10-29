using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public ActionResult<List<Movie>> GetAll()
    {
        return Ok(_movieService.GetAllMovies());
    }

    [HttpPost]
    public ActionResult<Movie> PostMovie(Movie movie)
    {
        var Movie = _movieService.CreateMovie(movie);
        return Ok(Movie);
    }
}