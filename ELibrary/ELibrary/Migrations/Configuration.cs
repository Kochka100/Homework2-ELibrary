using ELibrary.Models;

namespace ELibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ELibrary.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ELibrary.Models.ApplicationDbContext";
        }

        protected override void Seed(ELibrary.Models.ApplicationDbContext context)
        {
            context.AllBooks.Add(
                new Book()
                {
                    Id = 0,
                    Author = "Suzanne Collins",
                    Description = "The nation of Panem, formed from a post-apocalyptic North America, is a country that consists of a wealthy Capitol region surrounded by 12 poorer districts. Early in its history, a rebellion led by a 13th district against the Capitol resulted in its destruction and the creation of an annual televised event known as the Hunger Games. In punishment, and as a reminder of the power and grace of the Capitol, each district must yield one boy and one girl between the ages of 12 and 18 through a lottery system to participate in the games.",
                    Title = "The Hunger Games"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 1,
                    Author = "J.K. Rowling",
                    Description = "Harry Potter is due to start his fifth year at Hogwarts School of Witchcraft and Wizardry. His best friends Ron and Hermione have been very secretive all summer and he is desperate to get back to school and find out what has been going on. However, what Harry discovers is far more devastating than he could ever have expected...",
                    Title = "Harry Potter and the Order of the Phoenix"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 2,
                    Author = "Harper Lee",
                    Description = "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.",
                    Title = "To Kill a Mockingbird"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 3,
                    Author = "Jane Austen",
                    Description = "So begins Pride and Prejudice, Jane Austen's witty comedy of manners--one of the most popular novels of all time--that features splendidly civilized sparring between the proud Mr. Darcy and the prejudiced Elizabeth Bennet as they play out their spirited courtship in a series of eighteenth-century drawing-room intrigues.",
                    Title = "Pride and Prejudice"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 4,
                    Author = "Stephenie Meyer",
                    Description = "In the first book of the Twilight Saga, internationally bestselling author Stephenie Meyer introduces Bella Swan and Edward Cullen, a pair of star-crossed lovers whose forbidden relationship ripens against the backdrop of small-town suspicion and a mysterious coven of vampires. This is a love story with bite.",
                    Title = "Twilight"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 5,
                    Author = "John Green",
                    Description = "Despite the tumor-shrinking medical miracle that has bought her a few years, Hazel has never been anything but terminal, her final chapter inscribed upon diagnosis. But when a gorgeous plot twist named Augustus Waters suddenly appears at Cancer Kid Support Group, Hazel's story is about to be completely rewritten.",
                    Title = "The Fault in Our Stars"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 6,
                    Author = "C.S. Lewis",
                    Description = "For the past fifty years, The Chronicles of Narnia have transcended the fantasy genre to become part of the canon of classic literature. Each of the seven books is a masterpiece, drawing the reader into a land where magic meets reality, and the result is a fictional world whose scope has fascinated generations.",
                    Title = "The Chronicles of Narnia"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 7,
                    Author = "Emily Brontë",
                    Description = "Wuthering Heights is a wild, passionate story of the intense and almost demonic love between Catherine Earnshaw and Heathcliff, a foundling adopted by Catherine's father. After Mr Earnshaw's death, Heathcliff is bullied and humiliated by Catherine's brother Hindley and wrongly believing that his love for Catherine is not reciprocated, leaves Wuthering Heights, only to return years later as a wealthy and polished man.",
                    Title = "Wuthering Heights"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 8,
                    Author = "Margaret Mitchell",
                    Description = "Many novels have been written about the Civil War and its aftermath. None take us into the burning fields and cities of the American South as Gone With the Wind does, creating haunting scenes and thrilling portraits of characters so vivid that we remember their words and feel their fear and hunger for the rest of our lives.",
                    Title = "Gone with the Wind"
                }
            );
            context.AllBooks.Add(
                new Book()
                {
                    Id = 9,
                    Author = "George Orwell",
                    Description = "Tired of their servitude to man, a group of farm animals revolt and establish their own society, only to be betrayed into worse servitude by their leaders, the pigs, whose slogan becomes: All animals are equal, but some animals are more equal than others. This 1945 satire addresses the socialist/communist philosophy of Stalin in the Soviet Union.",
                    Title = "Animal Farm"
                }
            );
    }
    }
}
