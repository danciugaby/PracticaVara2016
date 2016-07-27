#include "NativeCall.h"

int print_line(const char * str, int a)
{
	printf("%s \n", str);
	Processer p;
	int i = p.ProcessAnInt(a);
	return i;
}
