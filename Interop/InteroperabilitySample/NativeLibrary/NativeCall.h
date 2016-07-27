#pragma once
#include "stdafx.h"
#include "Processer.h"
#ifndef MYAPI
#define MYAPI
#endif

#ifdef __cplusplus 
#endif MYAPI 
 extern "C" {
	 MYAPI int print_line(const char* str, int);
}
#ifdef __cplusplus
#endif