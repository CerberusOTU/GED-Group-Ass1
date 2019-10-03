#include "SimpleClass.h"
#include <iostream>
#include <fstream>



int SimpleClass::SimpleFunction()
{
	return 1;
}

void SimpleClass::SaveFunction(Vec3 objects[], int size)
{
	std::ofstream text;
	text.open("SavedData.txt");

	if (text.is_open())
	{
		text << size << std::endl;
		for (int i = 0; i < size; i++)
		{
			text << objects[i].x << std::endl;
			text << objects[i].y << std::endl;
			text << objects[i].z << std::endl;
		}
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
