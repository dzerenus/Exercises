#include <stdexcept>
#include <string>
#include "Cargo.h"

/* >>> by ShpriZZ <<< */

using namespace std;

const double Cargo::Mass() { return this->mass; }
void Cargo::Mass(double m)
{
	if (m <= 0) throw invalid_argument("Invalid Mass!");
	this->mass = m;
}

const int Cargo::Price() { return this->price; }
void Cargo::Price(int p)
{
	if (p < 0) throw invalid_argument("Invalid Price!");
	this->price = p;
}

const short Cargo::Dangerous() { return this->dangerous; }
void Cargo::Dangerous(short d)
{
	if (d < 0 || d > 9) throw invalid_argument("Invalid Dangerous!");
	this->dangerous = d;
}

const string Cargo::to_string()
{
	string res = "";
	res += "Mass: " + std::to_string(mass) + " ";
	res += "Price: " + std::to_string(price) + " ";
	res += "Dangerous: " + std::to_string(dangerous);
	return res;
}

Cargo::Cargo(double m, int p, short d)
{
	Mass(m);
	Price(p);
	Dangerous(d);
}