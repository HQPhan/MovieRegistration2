using Dapper;
using MovieRegistration.Models;
using MySqlConnector;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        string connectionPath = "";
        public IActionResult Index()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();
                Movie d = movies[0];
                return View(d);
            }
        }
    }
}
