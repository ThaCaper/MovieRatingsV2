using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRatingsV2;
using Xunit;

namespace MSTest
{
    [TestClass]
    public class MSTestingMethods
    {

        readonly MovieRating mr = new MovieRating(@"..\..\..\..\ratings.json");

        //opgave 1
        [DataRow(1, 3)]
        [DataTestMethod]
        public void TestMethod1areequal(int revewier, int exp)
        {
            Assert.AreEqual(mr.ListOfReviewsByInput(revewier), exp);
        }


        [TestMethod]
        public void TestMethod1areNotequal()
        {
            var mr1 = mr.ListOfReviewsByInput(1);

            Assert.AreNotEqual(4, mr1);
        }

        //opgave 2
        [TestMethod]
        public void TestMethod2avg()
        {
            var avg = mr.AverageGrade(1);

            Assert.AreEqual(4.333333333333333, avg);
        }

        [TestMethod]
        public void TestMethod2avghastofail()
        {
            var avg = mr.AverageGrade(1);

            Assert.AreNotEqual(2, avg);
        }


        //opgave 3 GivenReviewBySpecificGrade
        [TestMethod]
        public void TestMethod_GivenReviewBySpecificGradel_fail()
        {
            var avg = mr.GivenReviewBySpecificGrade(10, 3);

            Assert.AreNotEqual(5, avg);
        }


        [TestMethod]
        public void TestMethod_GivenReviewBySpecificGradel()
        {
            var avg = mr.GivenReviewBySpecificGrade(10, 3);

            Assert.AreEqual(2, avg);
        }

        //opgave 4
        [DataRow(1488844, 2)]
        [DataTestMethod]
        public void TestMethodListOfReviewedMovies(int movieid, int exp)
        {
            Assert.AreEqual(mr.ListOfReviewedMovies(movieid), exp);
        }

        [DataRow(1488844, 88)]
        [DataTestMethod]
        public void TestMethodListOfReviewedMovies_fail(int movieid, int exp)
        {
            Assert.AreNotEqual(mr.ListOfReviewedMovies(movieid), exp);
        }


        //opgave 5 AverageOfGradeOfSpecificMovie

        [DataRow(1488844, 88)]

        [DataTestMethod]
        public void AverageOfGradeOfSpecificMovie_fail(int movieid, int exp)
        {
            Assert.AreNotEqual(mr.ListOfReviewedMovies(movieid), exp);
        }


        [DataRow(1488844, 3)]
        [DataTestMethod]
        public void AverageOfGradeOfSpecificMovie(int movieid, int exp)
        {
            Assert.AreNotEqual(mr.ListOfReviewedMovies(movieid), exp);
        }

    }

}
