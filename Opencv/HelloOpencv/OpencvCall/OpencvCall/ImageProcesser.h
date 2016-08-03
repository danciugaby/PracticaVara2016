
#include "stdafx.h"
#include "ColorProcessing.h"
#include "Filtering.h"

class ImageProcesser
{

public:
	ImageProcesser(char * path);
	 ~ImageProcesser();

	 void GrayImage();

	 void InvertImage();

	 void PlayWithImages();


private :
	cv::Mat _img;
};

