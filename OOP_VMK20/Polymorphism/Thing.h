#pragma once
class Thing
{
public:
	const double Mass();
	void Mass(double m);

	const double Volume();
	void Volume(double v);

private:
	double volume;
	double mass;
};

