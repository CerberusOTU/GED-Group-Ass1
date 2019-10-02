#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"
#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API int SimpleFunction();
	PLUGIN_API void SaveFunction(float PosX, float PosY, float PosZ);
	PLUGIN_API Vec3 LoadFunction();
#ifdef __cplusplus
}
#endif