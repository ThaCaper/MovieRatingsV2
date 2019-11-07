using System;
using System.Diagnostics;
using MovieRatingsV2;
using Xunit;

namespace XUnitPerformanceTest
{
    public class XUnitPTest
    {
        private readonly int movieId = 1488844;
        private readonly int MAXTIME = 4;
        readonly MovieRating mr = new MovieRating(@"C:\Users\andre\Documents\GitHub\MovieRatingsV2\ratings.json");
        [Fact]
        public void Test1()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                mr.AverageGrade(1);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.True(time <= MAXTIME);
            }
        }


        [Fact]
        public void Test2()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                mr.AverageOfGradeOfSpecificMovie(movieId);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.True(time <= MAXTIME);
            }
        }

        [Fact]
        public void Test3()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                mr.GivenReviewBySpecificGrade(10, 3);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.True(time <= MAXTIME);
            }
        }

        [Fact]
        public void Test4()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                mr.ListOfReviewedMovies(movieId);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.True(time <= MAXTIME);
            }
        }

        [Fact]
        public void Test5()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                mr.AverageOfGradeOfSpecificMovie(movieId);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.True(time <= MAXTIME);
            }
        }
    }
}
