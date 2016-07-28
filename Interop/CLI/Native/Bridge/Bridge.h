// Bridge.h

#pragma once

using namespace System;
#include "../Native/NativeClass.h"

namespace Bridge {

	public ref class ClassDotNet
	{
	private:
		NativeClass* ptr;

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
	};
}
