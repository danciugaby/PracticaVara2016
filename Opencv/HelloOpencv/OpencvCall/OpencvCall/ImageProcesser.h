#pragma once
#include <cv.h>

#include <opencv2/highgui.hpp>
#include <opencv2/imgcodecs.hpp>
#include <opencv2/imgproc.hpp>

class ImageProcesser
{
public:
	ImageProcesser();
	~ImageProcesser();

	void GrayImage(char * path);
};

