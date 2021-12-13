#pragma once
#include "Cargo.h"
#include <string>

/* >>> by ShpriZZ <<< */

class Bulk: public Cargo
{
	/// <summary>
	/// Сыпучий/газообразный/наливной груз.
	/// </summary>

	double volume;

public:
	// GET SET объема газа/жидкости.
	const double Volume();
	void Volume(double v);

	// Перегрузка родительного to_string.
	const std::string to_string();

	// Конструктор класса.
	Bulk(double v, double m, int p, short d);
};

