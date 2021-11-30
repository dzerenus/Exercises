#include <string>
#include <stdexcept>

#include "book.h"

using namespace std;

/*
	======================
	РАЗРАБОТАЛ ШАРИН РОМАН
	======================
*/

const string& Book::Title() const { return title; }                // GET Название.
void Book::Title(const string& title) { this->title = title; }     // SET Название.

const string& Book::Author() const { return author; }              // GET Автор.
void Book::Author(const string& author) { this->author = author; } // SET Автор.

const int Book::Year() const { return year; }                     // GET Год выхода.
void Book::Year(int year) { set_year(year); }                     // SET Год выхода.

const int Book::Count() const { return count; }                   // GET Тираж.
void Book::Count(int count) { set_count(count); }                 // SET Тираж.

const double Book::Rating() const { return rating; }              // GET Рейтинг.
void Book::Rating(double rating) { set_rating(rating); }          // SET Рейтинг.

Book::Book(const string& title, const string& author, int year, int count, double rating)
{
	this->title = title;   // Название.
	this->author = author; // Автор.
	set_year(year);         // Год выхода.
	set_count(count);       // Тираж.
	set_rating(rating);     // Рейтинг.
}

Book::Book()
{
	title = "NO_NAME";    // Название.
	author = "NO_AUTHOR"; // Автор.
	year = 0;             // Год выхода.
	count = 0;            // Тираж.
	rating = 0;           // Рейтинг.
}

void Book::set_rating(double rating)
{
	// Рейтинг может варьироваться от 0 до 10.
	if (rating < 0 || rating > 10) throw invalid_argument("Rating value error!");
	else this->rating = rating;
}

void Book::set_year(int year)
{
	// Год должен быть меньше или равно 2021.
	if (year > 2021 || year < -2000) throw invalid_argument("Year value error!");
	else this->year = year;
}

void Book::set_count(int count)
{
	// Тираж не может быть больше нуля.
	if (count < 0) throw invalid_argument("Count value error!");
	else this->count = count;
}

const string Book::to_string() const
{
	// Формирование строки информации о книги.
	string info;
	info = "\"" + title + "\" by " + author + " at " + std::to_string(year);
	info += " - Count:" + std::to_string(count) + " Rating:" + std::to_string(rating);
	return info;
}

ostream& operator<<(ostream& os, const Book& object)
{
	os << object.to_string();
	return os;
}