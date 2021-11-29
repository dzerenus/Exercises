#include <iostream>

#include "Book.h"

int main()
{
    auto a = Book("War and Peace", "L.I. Tolstoy", 1865, 5000, 7.83);
    string info = a.to_string();
    cout << info << endl;

    a.Year(1963);
    a.Title("NoName");
    a.Author("Mr. Krutoy");
    a.Count(230);
    a.Rating(2.3);
    info = a.to_string();
    cout << info << endl;
}