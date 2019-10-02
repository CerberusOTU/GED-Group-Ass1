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
	void SaveFunction(float PosX, float PosY, float PosZ);
	Vec3 LoadFunction();

	Vec3 location;
};