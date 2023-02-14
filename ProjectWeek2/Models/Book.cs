using System;
using System.Collections.Generic;

namespace ProjectWeek2.Models.ViewModel {
    public class Book {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicYear { get; set; }
        public double Price { get; set; }
        public string Cover { get; set; }

        public List<Book> GetListbooks() {
            List<Book> listBooks = new List<Book>();
            
            for (int i = 0; i < 10; i++) {

                Book newBook = new Book() {
                    Id = Guid.NewGuid(),
                    Title = "This is a book",
                    Author = "Anonymus",
                    Cover = "image",
                    Price = 29000000,
                    PublicYear = 2023
                };

                listBooks.Add(newBook);
            }
            return listBooks;
        }
    }
}