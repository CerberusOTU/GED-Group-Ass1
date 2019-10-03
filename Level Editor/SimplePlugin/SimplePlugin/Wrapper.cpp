#include "Wrapper.h"


SimpleClass simpleClass;

int SimpleFunction()
{
	return simpleClass.SimpleFunction();
}

void SaveFunction(Vec3 objects[], int size)
{
	return simpleClass.SaveFunction(objects, size);
}

Vec3 LoadFunction()
{
	return simpleClass.LoadFunction();
}
