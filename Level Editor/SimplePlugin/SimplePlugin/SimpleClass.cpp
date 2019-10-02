#include "SimpleClass.h"
#include <iostream>
#include <fstream>



int SimpleClass::SimpleFunction()
{
	return 1;
}

void SimpleClass::SaveFunction(float PosX, float PosY, float PosZ)
{
	std::ofstream text;
	text.open("SavedData.txt");

	if (text.is_open())
	{
		text << PosX << std::endl;
		text << PosY << std::endl;
		text << PosZ << std::endl;
	}

	text.close();
}

Vec3 SimpleClass::LoadFunction()
{
	std::ifstream text;
	text.open("SavedData.txt");

	if (text.is_open())
	{
		text >> location.x;
		text >> location.y;
		text >> location.z;
	}

	text.close();

	return location;
}
