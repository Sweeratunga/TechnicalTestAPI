using Microsoft.EntityFrameworkCore;
using TechnicalTestAPI.DataAccessLayer.Models;

namespace TechnicalTestAPI.DataAccessLayer.Context
{
    public class TechnicalTestDbContext : DbContext
    {
        public TechnicalTestDbContext()
        {

        }
        public TechnicalTestDbContext(DbContextOptions<TechnicalTestDbContext> options) : base(options) { }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(GeneratePersonSeedData());
            modelBuilder.Entity<Shift>().HasData(GenerateShiftsSeedData());
        }

        private List<Person> GeneratePersonSeedData()
        {

            List<Person> listPerson = [
                new Person(1, "John Doe", DateTime.Parse("1980 -05-15"), DateTime.Parse("2005-07-10"), true),
                new Person(2, "Jane Smith", DateTime.Parse("1990-02-25"), DateTime.Parse("2012-09-03"), true),
                new Person(3, "Michael Johnson", DateTime.Parse("1975-12-10"), DateTime.Parse("2002-04-20"), false),
                new Person(4, "Emily Brown", DateTime.Parse("1988-08-05"), DateTime.Parse("2010-11-15"), true),
                new Person(5, "David Wilson", DateTime.Parse("1995-03-22"), DateTime.Parse("2018-06-30"), false),
                new Person(6, "Sarah Taylor", DateTime.Parse("1983-07-18"), DateTime.Parse("2007-09-28"), true),
                new Person(7, "James Anderson", DateTime.Parse("1972-01-12"), DateTime.Parse("2000-03-05"), true),
                new Person(8, "Olivia Clark", DateTime.Parse("1992-11-30"), DateTime.Parse("2014-08-12"), false),
                new Person(9, "William Harris", DateTime.Parse("1986-04-03"), DateTime.Parse("2009-12-20"), true),
                new Person(10, "Ava Martinez", DateTime.Parse("1997-09-08"), DateTime.Parse("2021-02-17"), true),
                new Person(11, "Daniel Davis", DateTime.Parse("1981-06-14"), DateTime.Parse("2006-10-25"), false),
                new Person(12, "Mia Jackson", DateTime.Parse("1993-10-29"), DateTime.Parse("2016-03-08"), true),
                new Person(13, "Joseph White", DateTime.Parse("1978-04-17"), DateTime.Parse("2004-08-03"), true),
                new Person(14, "Sophia Miller", DateTime.Parse("1989-12-07"), DateTime.Parse("2011-07-22"), false),
                new Person(15, "Christopher Lee", DateTime.Parse("1984-03-01"), DateTime.Parse("2008-05-14"), true),
                new Person(16, "Emma Turner", DateTime.Parse("1998-05-20"), DateTime.Parse("2022-09-10"), true),
                new Person(17, "Matthew Baker", DateTime.Parse("1977-09-04"), DateTime.Parse("2003-11-29"), false),
                new Person(18, "Lily Garcia", DateTime.Parse("1991-02-11"), DateTime.Parse("2015-04-02"), true),
                new Person(19, "Andrew Sanchez", DateTime.Parse("1987-08-28"), DateTime.Parse("2019-01-09"), true),
                new Person(20, "Grace Taylor", DateTime.Parse("1994-01-03"), DateTime.Parse("2017-06-12"), false)
                        ];

            return listPerson;
        }

        private static List<Shift> GenerateShiftsSeedData()
        {
            List<Shift> listShift = new();

            listShift.AddRange([new Shift(1, "Leeds", "Doctor", 7, DateTime.Parse("2023-11-09T08:00:00"), DateTime.Parse("2023-11-09T16:00:00")),
                new Shift(2, "Wakefield", "Nurse", 18, DateTime.Parse("2023-11-10T09:00:00"), DateTime.Parse("2023-11-10T17:00:00")),
                new Shift(3, "Bradford", "Receptionist", 10, DateTime.Parse("2023-11-11T10:00:00"), DateTime.Parse("2023-11-11T18:00:00")),
                new Shift(4, "Huddersfield", "Driver", 14, DateTime.Parse("2023-11-12T07:30:00"), DateTime.Parse("2023-11-12T15:30:00")),
                new Shift(5, "Leeds", "Doctor", 3, DateTime.Parse("2023-11-13T12:00:00"), DateTime.Parse("2023-11-13T20:00:00")),
                new Shift(6, "Wakefield", "Nurse", 12, DateTime.Parse("2023-11-14T08:30:00"), DateTime.Parse("2023-11-14T16:30:00")),
                new Shift(7, "Bradford", "Receptionist", 1, DateTime.Parse("2023-11-15T09:30:00"), DateTime.Parse("2023-11-15T17:30:00")),
                new Shift(8, "Huddersfield", "Driver", 15, DateTime.Parse("2023-11-16T11:00:00"), DateTime.Parse("2023-11-16T19:00:00")),
                new Shift(9, "Leeds", "Doctor", 11, DateTime.Parse("2023-11-17T07:00:00"), DateTime.Parse("2023-11-17T15:00:00")),
                new Shift(10, "Wakefield", "Nurse", 19, DateTime.Parse("2023-11-18T14:00:00"), DateTime.Parse("2023-11-18T22:00:00")),
                new Shift(11, "Bradford", "Doctor", 5, DateTime.Parse("2023-11-19T08:00:00"), DateTime.Parse("2023-11-19T16:00:00")),
                new Shift(12, "Huddersfield", "Driver", 16, DateTime.Parse("2023-11-15T09:30:00"), DateTime.Parse("2023-11-15T09:30:00")),
                new Shift(13, "Leeds", "Doctor", 2, DateTime.Parse("2023-11-15T09:30:00"), DateTime.Parse("2023-11-15T09:30:00")),
                new Shift(14, "Wakefield", "Nurse", 9, DateTime.Parse("2023-11-15T09:30:00"), DateTime.Parse("2023-11-15T09:30:00")),
                new Shift(15, "Bradford", "Receptionist", 20, DateTime.Parse("2023-11-23T12:00:00"), DateTime.Parse("2023-11-23T20:00:00")),
                new Shift(16, "Huddersfield", "Driver", 4, DateTime.Parse("2023-11-24T08:30:00"), DateTime.Parse("2023-11-24T16:30:00")),
                new Shift(17, "Leeds", "Doctor", 13, DateTime.Parse("2023-11-25T09:30:00"), DateTime.Parse("2023-11-25T17:30:00")),
                new Shift(18, "Wakefield", "Doctor", 17, DateTime.Parse("2023-11-26T11:00:00"), DateTime.Parse("2023-11-26T19:00:00")),
                new Shift(19, "Bradford", "Receptionist", 8, DateTime.Parse("2023-11-27T07:00:00"), DateTime.Parse("2023-11-27T15:00:00")),
                new Shift(20, "Huddersfield", "Driver", 6, DateTime.Parse("2023-11-28T12:00:00"), DateTime.Parse("2023-11-28T20:00:00")),
                new Shift(21, "Leeds", "Doctor", 2, DateTime.Parse("2023-11-29T08:00:00"), DateTime.Parse("2023-11-29T16:00:00")),
                new Shift(22, "Wakefield", "Nurse", 19, DateTime.Parse("2023-11-30T09:00:00"), DateTime.Parse("2023-11-30T17:00:00")),
                new Shift(23, "Castleford", "Receptionist", 15, DateTime.Parse("2023-11-30T10:00:00"), DateTime.Parse("2023-11-30T18:00:00")),
                new Shift(24, "Huddersfield", "Doctor", 8, DateTime.Parse("2023-11-01T07:30:00"), DateTime.Parse("2023-11-01T15:30:00")),
                new Shift(25, "Leeds", "Doctor", 10, DateTime.Parse("2023-11-02T12:00:00"), DateTime.Parse("2023-11-02T20:00:00")),
                new Shift(26, "Wakefield", "Nurse", 5, DateTime.Parse("2023-11-03T08:30:00"), DateTime.Parse("2023-11-03T16:30:00")),
                new Shift(27, "Bradford", "Receptionist", 12, DateTime.Parse("2023-11-04T09:30:00"), DateTime.Parse("2023-11-04T17:30:00")),
                new Shift(28, "London", "Driver", 16, DateTime.Parse("2023-11-05T11:00:00"), DateTime.Parse("2023-11-05T19:00:00")),
                new Shift(29, "Leeds", "Doctor", 13, DateTime.Parse("2023-11-06T07:00:00"), DateTime.Parse("2023-11-06T15:00:00")),
                new Shift(30, "Wakefield", "Doctor", 7, DateTime.Parse("2023-11-07T14:00:00"), DateTime.Parse("2023-11-07T22:00:00")),
                new Shift(31, "Manchester", "Receptionist", 9, DateTime.Parse("2023-11-08T08:00:00"), DateTime.Parse("2023-11-08T16:00:00")),
                new Shift(32, "Huddersfield", "Driver", 20, DateTime.Parse("2023-11-09T09:00:00"), DateTime.Parse("2023-11-09T17:00:00")),
                new Shift(33, "Leeds", "Doctor", 1, DateTime.Parse("2023-11-10T10:00:00"), DateTime.Parse("2023-11-10T18:00:00")),
                new Shift(34, "Wakefield", "Doctor", 3, DateTime.Parse("2023-11-11T07:30:00"), DateTime.Parse("2023-11-11T15:30:00")),
                new Shift(35, "Bradford", "Receptionist", 18, DateTime.Parse("2023-11-12T12:00:00"), DateTime.Parse("2023-11-12T20:00:00")),
                new Shift(36, "Huddersfield", "Driver", 6, DateTime.Parse("2023-11-13T08:30:00"), DateTime.Parse("2023-11-13T16:30:00")),
                new Shift(37, "Leeds", "Doctor", 17, DateTime.Parse("2023-11-14T09:30:00"), DateTime.Parse("2023-11-14T17:30:00")),
                new Shift(38, "Wakefield", "Nurse", 11, DateTime.Parse("2023-11-15T11:00:00"), DateTime.Parse("2023-11-15T19:00:00")),
                new Shift(39, "Bradford", "Doctor", 14, DateTime.Parse("2023-11-16T07:00:00"), DateTime.Parse("2023-11-16T15:00:00")),
                new Shift(40, "Huddersfield", "Driver", 4, DateTime.Parse("2023-11-17T14:00:00"), DateTime.Parse("2023-11-17T22:00:00")),
                new Shift(41, "Leeds", "Doctor", 10, DateTime.Parse("2023-11-18T08:00:00"), DateTime.Parse("2023-11-18T16:00:00")),
                new Shift(42, "Wakefield", "Nurse", 15, DateTime.Parse("2023-11-19T09:00:00"), DateTime.Parse("2023-11-19T17:00:00")),
                new Shift(43, "Bradford", "Doctor", 13, DateTime.Parse("2023-11-20T10:00:00"), DateTime.Parse("2023-11-20T18:00:00")),
                new Shift(44, "Huddersfield", "Driver", 19, DateTime.Parse("2023-11-21T07:30:00"), DateTime.Parse("2023-11-21T15:30:00")),
                new Shift(45, "Leeds", "Doctor", 7, DateTime.Parse("2023-11-22T12:00:00"), DateTime.Parse("2023-11-22T20:00:00")),
                new Shift(46, "Wakefield", "Nurse", 16, DateTime.Parse("2023-11-23T08:30:00"), DateTime.Parse("2023-11-23T16:30:00")),
                new Shift(47, "Bradford", "Receptionist", 2, DateTime.Parse("2023-11-24T09:30:00"), DateTime.Parse("2023-11-24T17:30:00")),
                new Shift(48, "Huddersfield", "Driver", 12, DateTime.Parse("2023-11-25T11:00:00"), DateTime.Parse("2023-11-25T19:00:00")),
                new Shift(49, "Leeds", "Doctor", 8, DateTime.Parse("2023-11-26T07:00:00"), DateTime.Parse("2023-11-26T15:00:00")),
                new Shift(50, "Wakefield", "Nurse", 14, DateTime.Parse("2023-11-27T14:00:00"), DateTime.Parse("2023-11-27T22:00:00"))]);
            return listShift;
        }
      
    }
}
