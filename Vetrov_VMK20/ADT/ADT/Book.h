#include <string>

using namespace std;

/*
	======================
	РАЗРАБОТАЛ ШАРИН РОМАН
	======================
*/

class Book
{
	// Карточка книги.

public:
	// GET и SET названия книги.
	const string& Title() const;
	void Title(const string& title);

	// GET и SET автора книги.
	const string& Author() const;
	void Author(const string& author);

	// GET и SET год выхода книги.
	const int Year() const;
	void Year(int year);

	// GET и SET тираж книги.
	const int Count() const;
	void Count(int count);
	
	// GET и SET рейтинг книги.
	const double Rating() const;
	void Rating(double rating);

	// Конструктор класса.
	Book(const string& title, const string& author, int year, int count, double rating);

	// Конструктор по умолчанию.
	Book();

	// Получение информации о классе в формате строки.
	const string to_string() const;

	friend std::ostream& operator<<(std::ostream& os, const Book& object);


private:
	string title;   // Название книги.
	string author;  // Автор книги.
	int year;       // Год выхода книги. 
	int count;      // Тираж книги.
	double rating;  // Рейтинг книги.

	// Безопасное изменнеие рейтинга книги.
	void set_rating(double rating);

	// Безопасное изменение года выхода книги.
	void set_year(int year);

	// Безопасное измененеие тиража книги.
	void set_count(int count);
};