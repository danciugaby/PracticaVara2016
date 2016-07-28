// Bridge.h

#pragma once

using namespace System;

using namespace System::Collections;

using namespace System::Collections::Generic;

#include <vector>
#include "../Native/NativeClass.h"
#include "../Native/stdafx.h"

namespace Bridge {


	public ref struct MyPoint
	{
	public:
		int x;
		int y;
		MyPoint()
		{
			this->x = 0;
			this->y = 0;
		}
		MyPoint(int x, int y)
		{
			this->x = x;
			this->y = y;
		}
	};

	public ref class ClassDotNet
	{
	private:
		NativeClass *ptr;

	public:
		ClassDotNet()
		{
			ptr = new NativeClass();
		}

		~ClassDotNet()
		{
			this->!ClassDotNet();
		}

		!ClassDotNet()
		{
			delete ptr;
			ptr = nullptr;
		}

		int ExposedMedthod(int i)
		{
			return ptr->f(i);
		}

		List<MyPoint^>^ DoubleArray(List<MyPoint^>^ param)
		{
			std::vector<Point> pts;
			for each (MyPoint^ var in param)
			{				
				pts.push_back(Point(var->x,var->y));
			}
			
			std::vector<Point> results = ptr->sir(pts);

			List<MyPoint^>^ tocsharplist = gcnew List<MyPoint^>();
			for each (Point var in results)
			{
				tocsharplist->Add(gcnew MyPoint(var.x, var.y));
			}
			return tocsharplist;
		}
	};
}
