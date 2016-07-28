#pragma once
#include <memory>
#include <vector>
#include "stdafx.h"

class NativeClass
{
public:
	NativeClass();
	~NativeClass();
	int f(int a)
	{

		return 2 * a;
	}

	std::vector<Point> sir(std::vector<Point> arrays)
	{
		std::vector<Point> myarray;
		myarray.resize(arrays.size());
		int i = 0;
		for each (Point var in arrays)
		{
			myarray[i++] = Point(var.x*2, var.y * 2);
		}
		return myarray;
	}
};

