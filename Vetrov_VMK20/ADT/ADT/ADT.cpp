#include <iostream>

#include "Book.h"

/*
    ======================
    РАЗРАБОТАЛ ШАРИН РОМАН
    ======================
*/

int main()
{
    // Создаём новую книгу.
    // Выводим информацию о ней.
    auto a = Book("War and Peace", "L.I. Tolstoy", 1865, 5000, 7.83);
    string info = a.to_string();
    cout << info << endl;

    // Изменяем все параметры книги.
    // Снова выводим информацию.
    a.Year(1963);
    a.Title("NoName");
    a.Author("Mr. Krutoy");
    a.Count(230);
    a.Rating(2.3);
    cout << a << endl;

    // Массив из книг.
    Book arr[5] = {
        Book("Book_1", "Author_1", 1991, 23000, 6.43),
        Book("Book_2", "Author_2", 1993, 64834, 2.00),
        Book("Book_3", "Author_3", 1999, 32132, 8.63),
        Book("Book_4", "Author_4", 1921, 11111, 9.43),
        Book("Book_5", "Author_5", 1900, 12300, 1.23)
    };

    // Массив указателей.
    Book* darr[5] = {
        &arr[0],
        &arr[1],
        &arr[2],
        &arr[3],
        &arr[4]
    };

    // Выделение памяти под массив.
    auto dyrr = new Book[3];
    delete[] dyrr;
}