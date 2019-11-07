using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MovieRatingsV2
{
    public class MovieRating
    {
        List<Reviewers> _ReviewerList;

        public MovieRating(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                _ReviewerList = JsonConvert.DeserializeObject<List<Reviewers>>(json);


            }
        }
        æaefjiig


        public int ListOfReviewsByInput(int reviewId)
        {
            int count = 0;
            foreach (var movie in _ReviewerList)
            {

                if (movie.Reviewer.Equals(reviewId))
                {
                    count++;
                }

            }
            
            return count;


        }

        public double AverageGrade(int reviewId)
        {
            
            double sum =0.0;
            int count = 0;
            foreach (var rating in _ReviewerList)
            {
                if (rating.Reviewer == reviewId)
                {
                    count++;
                    sum += rating.Grade;
                }


            }

            return sum / count;
           

        }

        public int GivenReviewBySpecificGrade(int reviewId, int grade)
        {
            int counter = 0;

            foreach (var movie in _ReviewerList)
            {
                if (movie.Reviewer.Equals(reviewId)&& movie.Grade.Equals(grade))
                {
                    counter++;
                }
            }

            
            return counter;
        }

        public int ListOfReviewedMovies(int givenMovie)
        {
            int Counter = 0;
            foreach (var das_movie in _ReviewerList)
            {
                if (das_movie.Movie.Equals(givenMovie))
                {
                    Counter++;
                }
            }

            return Counter;
        }

        public double AverageOfGradeOfSpecificMovie(int givenMovie)
        {
            int counter = 0;
            int sum = 0;
            foreach (var thaMovie in _ReviewerList)
            {
                if (thaMovie.Movie.Equals(givenMovie))
                {
                    counter++;
                    sum += thaMovie.Grade;

                }
                
            }

            return sum / counter;
        }

        public int SpecificGradeGivenToMovieCount(int givenMovie, int grade)
        {
            throw new System.NotImplementedException();
        }

        public List<Reviewers> MovieIdWithHighestGrade()
        {
            throw new System.NotImplementedException();
        }

        public List<Reviewers> MovieWithMostReviews()
        {
            throw new System.NotImplementedException();
        }

        public List<Reviewers> ListOfMoviesReviewed(int reviewId)
        {
            throw new System.NotImplementedException();
        }

        public List<Reviewers> ListOfReviewersOnMovie(int givenMovie)
        {
            throw new System.NotImplementedException();
        }
    
    }
}