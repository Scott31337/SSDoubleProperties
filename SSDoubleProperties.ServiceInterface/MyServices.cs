using ServiceStack;
using SSDoubleProperties.ServiceModel;
using System.Collections.Generic;

namespace SSDoubleProperties.ServiceInterface
{
    public class MyServices : Service
    {
        public static Dictionary<string, SSDoubleProperties.ServiceModel.Movie> Movies { get; set; }

        public MyServices()
        {
            Movies = new Dictionary<string, SSDoubleProperties.ServiceModel.Movie>();

            var myMovie = new SSDoubleProperties.ServiceModel.Movie { MovieID = "DF77F8AD-CAFA-4470-94DC-D5FD2331515F", MovieNo = 1, Name = "Star Wars: Episode V", Description = "Talking frog convinces a boy to kill his dad." };
            Movies.Add(myMovie.MovieID, myMovie);

            myMovie = new SSDoubleProperties.ServiceModel.Movie { MovieID = "1173DAB3-0DC9-4D28-AC68-75AF6581B6ED", MovieNo = 2, Name = "Forrest Gump", Description = "Drug addicted girl takes advantage of a mentally challenged boy for 3 decades." };
            Movies.Add(myMovie.MovieID, myMovie);
        }


        public SSDoubleProperties.ServiceModel.Movie Get(SSDoubleProperties.ServiceModel.MovieGETRequest request)
        {
            return Movies[request.MovieID];
        }

        public SSDoubleProperties.ServiceModel.Movie Post(MoviePOSTRequest request)
        {
            string newID = System.Guid.NewGuid().ToString();
            var myMovie = new SSDoubleProperties.ServiceModel.Movie { MovieID = newID, MovieNo = Movies.Count + 1, Name = request.Name, Description = request.Description };
            Movies.Add(myMovie.MovieID, myMovie);

            return myMovie;
        }
    }
}
