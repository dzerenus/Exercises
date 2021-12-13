#pragma once
#include <string>

/* >>> by ShpriZZ <<< */

class Coordinates
{
	/// <summary>
	/// Декартова система координат.
	/// </summary>

public:
	double X; // X-координата.
	double Y; // Y-координата.
	double Z; // Z-координата.
 	 
	const std::string to_string();

	Coordinates(double x, double y, double z);
	Coordinates() = default;
};

