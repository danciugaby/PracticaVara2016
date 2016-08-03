#pragma once

#include "stdafx.h"

class ColorProcessing
{
public:
	ColorProcessing();
	~ColorProcessing();
	
	cv::Mat Hsv(const cv::Mat & image);
	

};

