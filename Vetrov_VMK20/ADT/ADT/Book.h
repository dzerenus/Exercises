#include <string>
#include <stdexcept>

using namespace std;

class Book
{
public:
	const string& Title() const;
	void Title(const string& title);

	const string& Author() const;
	void Author(const string& author);

	const int& Year() const;
	void Year(const int& year);

	const int& Count() const;
	void Count(const int& count);

	const double& Rating() const;
	void Rating(const double& rating);

	// Конструктор класса.
	Book(const string& title, const string& author, const int& year, const int& count, const double& rating);

	// Получение информации о классе в формате строки.
	const string to_string() const;

private:
	string title;   // Название книги.
	string author;  // Автор книги.
	int year;       // Год выхода книги. 
	int count;      // Тираж книги.
	double rating;  // Рейтинг книги.

	// Безопасное изменнеие рейтинга книги.
	void SetRating(const double& rating);

	// Безопасное изменение года выхода книги.
	void SetYear(const int& year);

	// Безопасное измененеие тиража книги.
	void SetCount(const int& count);
};