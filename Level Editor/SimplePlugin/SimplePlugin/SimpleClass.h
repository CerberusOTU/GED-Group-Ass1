#pragma once

#include "PluginSettings.h"

struct Vec3
{
	float x;
	float y;
	float z;
};


class PLUGIN_API SimpleClass
{
public:

	int SimpleFunction();
	void SaveFunction(Vec3 objects[], int size);
	Vec3 LoadFunction();

	Vec3 location;
};