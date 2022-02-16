using ServiceStack;
using ServiceStack.DataAnnotations;

namespace SSDoubleProperties.ServiceModel
{
    public class Movie
    {
        virtual public string MovieID { get; set; }
        virtual public int MovieNo { get; set; }
        virtual public string Name { get; set; }
        virtual public string Description { get; set; }
    }

    public class MovieGETRequest : IReturn<Movie>
    {
        [Description("Unique Id of the movie"), ValidateNotEmpty]
        [Input(Required = true)]
        public string MovieID { get; set; }
    }

    public class MoviePOSTRequest : Movie, IReturn<Movie>
    {
        [Input(Disabled = true)]
        public override string MovieID { get; set; }

        [Input(Disabled = true)]
        public override int MovieNo { get; set; }
    }
}
