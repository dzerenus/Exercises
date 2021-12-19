#pragma once
#include <string>

/* >>> by ShpriZZ <<< */

class Coordinates
{
	/// <summary>
	/// Декартова система координат.
	/// </summary>

	double x; // X-координата.
	double y; // Y-координата.
	double z; // Z-координата.

public:
	const double X();
	void X(double x);

	const double Y();
	void Y(double y);

	const double Z();
	void Z(double z);

	const std::string to_string();

	Coordinates(double x, double y, double z);
	Coordinates() = default;
};

