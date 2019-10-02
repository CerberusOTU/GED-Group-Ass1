#include "Wrapper.h"


SimpleClass simpleClass;

int SimpleFunction()
{
	return simpleClass.SimpleFunction();
}

void SaveFunction(float PosX, float PosY, float PosZ)
{
	return simpleClass.SaveFunction(PosX, PosY, PosZ);
}

Vec3 LoadFunction()
{
	return simpleClass.LoadFunction();
}
