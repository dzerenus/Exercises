#include "Thing.h"

void Thing::Volume(double v) { this->volume = v; }
const double Thing::Volume() const { return this->volume; }

void Thing::Mass(double m) { this->mass = m; }
const double Thing::Mass() const { return this->mass; }