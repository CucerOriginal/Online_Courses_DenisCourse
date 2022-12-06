using Microsoft.EntityFrameworkCore;
using Online_Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.DbContextData
{
    public class ApplicationDbContextFilialOne : DbContext
    {
        public ApplicationDbContextFilialOne()
        {
            Database.EnsureCreated();
        }

        public DbSet<CoursesList>? CoursesLists { get; set; }

        public DbSet<PredmetLesson>? PredmetLessons { get; set; }

        public DbSet<Raspisanie>? Raspisanie { get; set; }

        public DbSet<GroupStudentConnection>? GroupStudentConnections { get; set; }

        public DbSet<Student>? Students { get; set; }

        public DbSet<Group>? StudentGroups { get; set; }

        public DbSet<Teacher>? Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OnlineCourseFilialOne;Username=postgres;Password=q1w2e3");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursesList>().HasData(
                new CoursesList { Id = 1, Cost = 1000, CourseName = "Матан", NumberClasses = 1 },
                new CoursesList { Id = 2, Cost = 1000, CourseName = "Рус-яз", NumberClasses = 2 },
                new CoursesList { Id = 3, Cost = 1000, CourseName = "Пинтос лангуге", NumberClasses = 3 });

            modelBuilder.Entity<PredmetLesson>().HasData(
                new PredmetLesson { Id = 1, PredmetName = "Первый пара", TeachedId = 2 },
                new PredmetLesson { Id = 2, PredmetName = "Вторая урок", TeachedId = 2 },
                new PredmetLesson { Id = 3, PredmetName = "Третья пара", TeachedId = 3 });

            modelBuilder.Entity<Raspisanie>().HasData(
                new Raspisanie { Id = 1, StartLesson = new DateTime(2022, 11, 24, 14, 0, 0, DateTimeKind.Utc), EndLesson = new DateTime(2022, 11, 24, 15, 0, 0, DateTimeKind.Utc), PredmetLessonId = 1, StudentGroupId = 1 },
                new Raspisanie { Id = 2, StartLesson = new DateTime(2022, 11, 24, 12, 0, 0, DateTimeKind.Utc), EndLesson = new DateTime(2022, 11, 24, 13, 0, 0, DateTimeKind.Utc), PredmetLessonId = 2, StudentGroupId = 3 },
                new Raspisanie { Id = 3, StartLesson = new DateTime(2022, 11, 24, 11, 0, 0, DateTimeKind.Utc), EndLesson = new DateTime(2022, 11, 24, 12, 0, 0, DateTimeKind.Utc), PredmetLessonId = 3, StudentGroupId = 3 });

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, SecondName = "Куликов2", FirstName = "Николай", MiddleName = "Алиевич", Address = "г.Казань, Домодедовская, 58", PhoneNumber = "89550367416", Birthday = new DateOnly(2000, 01, 21), CoursesListId = 1 },
                new Student { Id = 2, SecondName = "Кузнецов2", FirstName = "Николай", MiddleName = "Марсельевич", Address = "г.Казань, Ленина, 53", PhoneNumber = "89303347156", Birthday = new DateOnly(1999, 10, 23), CoursesListId = 2 },
                new Student { Id = 3, SecondName = "Петров2", FirstName = "Ярослав", MiddleName = "Львович", Address = "г.Казань, Ленина, 23", PhoneNumber = "89303767156", Birthday = new DateOnly(1996, 11, 11), CoursesListId = 3 });

            modelBuilder.Entity<GroupStudentConnection>().HasData(
              new GroupStudentConnection { Id = 1, GroupId = 1, StudentId = 1 },
              new GroupStudentConnection { Id = 2, GroupId = 2, StudentId = 2 },
              new GroupStudentConnection { Id = 3, GroupId = 3, StudentId = 3 });

            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, GroupNumber = "В-121", },
                new Group { Id = 2, GroupNumber = "Ф-011" },
                new Group { Id = 3, GroupNumber = "Г-111" });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, SecondName = "Семенова", FirstName = "Таисия", MiddleName = "Артёмовна", PhoneNumber = "89270382406", Address = "г.Казань, Домодедовская, 58", Birthday = new DateOnly(1994, 02, 21) },
                new Teacher { Id = 2, SecondName = "Куликов", FirstName = "Максим", MiddleName = "Игоревич", Address = "г.Казань, Молодежная, 12", PhoneNumber = "89567940024", Birthday = new DateOnly(1996, 03, 13) },
                new Teacher { Id = 3, SecondName = "Федотова", FirstName = "Мария", MiddleName = "Сергеевна", Address = "г.Казань, Ленина, 53", PhoneNumber = "89543067456", Birthday = new DateOnly(1994, 02, 21) });
        }
    }
}
