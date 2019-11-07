using System.Collections.Generic;

namespace MovieRatingsV2
{
    public interface IMovieRating
    {
        int ListOfReviewsByInput(int reviewId);

        double AverageGrade(int reviewId);

        int GivenReviewBySpecificGrade(int reviewId, int grade);

        int ListOfReviewedMovies(int givenMovie);

        double AverageOfGradeOfSpecificMovie(int givenMovie);

        int SpecificGradeGivenToMovieCount(int givenMovie, int grade);

        List<Reviewers> MovieIdWithHighestGrade();

        List<Reviewers> MovieWithMostReviews();

        //Method 9 later

        //Sorted by decreasing rate first, date second
        List<Reviewers> ListOfMoviesReviewed(int reviewId);

        List<Reviewers> ListOfReviewersOnMovie(int givenMovie);
    }
}