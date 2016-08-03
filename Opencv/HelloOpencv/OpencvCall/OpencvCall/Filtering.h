#pragma once
#include "stdafx.h"
class Filtering
{
public:
	Filtering();
	~Filtering();

	cv::Mat KernelFilter(cv::Mat & img);

	void EdgeFilter(cv::Mat & img);
};

