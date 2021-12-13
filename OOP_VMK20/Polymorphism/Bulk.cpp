#include <stdexcept>
#include <string>

#include "Bulk.h"
#include "Cargo.h"

/* >>> by ShpriZZ <<< */

using namespace std;

const double Bulk::Volume() { return this->volume; }
void Bulk::Volume(double v)
{
	if (v <= 0) throw invalid_argument("Invalud Volume!");
	this->volume = v;
}

const string Bulk::to_string()
{
	string res = this->Cargo::to_string();
	res = "Bulk. " + res + " ";
	res += "Volume: " + std::to_string(volume);
	return res;
}

Bulk::Bulk(double v, double m, int p, short d) : Cargo(m, p, d) { Volume(v); }