using TechnicalTestAPI.DataAccessLayer.Context;
using TechnicalTestAPI.DataAccessLayer.Interface;
using TechnicalTestAPI.DataAccessLayer.Models;
using TechnicalTestAPI.DataAccessLayer.Repository;
using TechnicalTestAPI.Test.DataAccessLayer.ContextMock;


namespace TechnicalTestAPI.Test.DataAccessLayer.Mocks
{
    public class IPersonRepositoryMock
    {
        public static IPersonRepository GetMock()
        {
            List<Person> listPerson = GenerateTestData();
            TechnicalTestDbContext dbContextMock = DbContextMock.GetMock<Person, TechnicalTestDbContext>(listPerson, x => x.People);
            return new PersonRepository(dbContextMock);
        }

        private static List<Person> GenerateTestData()
        {
            List<Person> lstPerson = [new Person( 1, "John Doe", DateTime.Parse("1980 -05-15"), DateTime.Parse("2005-07-10"), true ),
                new Person(2,"Jane Smith", DateTime.Parse("1990-02-25"), DateTime.Parse("2012-09-03"), true),
                new Person(3,"Michael Johnson", DateTime.Parse("1975-12-10"), DateTime.Parse("2002-04-20"), false),
                new Person(4,"Emily Brown", DateTime.Parse("1988-08-05"), DateTime.Parse("2010-11-15"), true),
                new Person(5,"David Wilson", DateTime.Parse("1995-03-22"), DateTime.Parse("2018-06-30"), false),
                new Person(6,"Sarah Taylor", DateTime.Parse("1983-07-18"), DateTime.Parse("2007-09-28"), true),
                new Person(7,"James Anderson", DateTime.Parse("1972-01-12"), DateTime.Parse("2000-03-05"), true),
                new Person(8,"Olivia Clark", DateTime.Parse("1992-11-30"), DateTime.Parse("2014-08-12"), false),
                new Person(9,"William Harris", DateTime.Parse("1986-04-03"), DateTime.Parse("2009-12-20"), true),
                new Person(10,"Ava Martinez", DateTime.Parse("1997-09-08"), DateTime.Parse("2021-02-17"), true),
                new Person(11,"Daniel Davis", DateTime.Parse("1981-06-14"), DateTime.Parse("2006-10-25"), false),
                new Person(12,"Mia Jackson", DateTime.Parse("1993-10-29"), DateTime.Parse("2016-03-08"), true),
                new Person(13,"Joseph White", DateTime.Parse("1978-04-17"), DateTime.Parse("2004-08-03"), true),
                new Person(14,"Sophia Miller", DateTime.Parse("1989-12-07"), DateTime.Parse("2011-07-22"), false),
                new Person(15,"Christopher Lee", DateTime.Parse("1984-03-01"), DateTime.Parse("2008-05-14"), true),
                new Person(16,"Emma Turner", DateTime.Parse("1998-05-20"), DateTime.Parse("2022-09-10"), true),
                new Person(17,"Matthew Baker", DateTime.Parse("1977-09-04"), DateTime.Parse("2003-11-29"), false),
                new Person(18,"Lily Garcia", DateTime.Parse("1991-02-11"), DateTime.Parse("2015-04-02"), true),
                new Person(19,"Andrew Sanchez", DateTime.Parse("1987-08-28"), DateTime.Parse("2019-01-09"), true),
                new Person(20,"Grace Taylor", DateTime.Parse("1994-01-03"), DateTime.Parse("2017-06-12"), false)
            ];
               
            return lstPerson;
        }

    }
}
