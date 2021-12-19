#pragma once
#include <string>

/* >>> by ShpriZZ <<< */

class Cargo
{
	/// <summary>
	/// Информация о корабельном грузе.
	/// </summary>

	int price;       // Стоимость доставки.
	double mass;     // Общая маса груза.
	short dangerous; // Класс опасности.

public:
	// GET SET массы.
	void Mass(double m);
	const double Mass();
	
	// GET SET цены доставки.
	void Price(int p);
	const int Price();

	// GET SET класса опасности.
	void Dangerous(short d);
	const short Dangerous();

	// Информация о классе в STRING.
	virtual std::string to_string();

	// Конструктор.
	Cargo(double m, int p, short d);
	Cargo() = default;
};

