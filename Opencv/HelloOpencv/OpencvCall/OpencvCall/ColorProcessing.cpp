#include "ColorProcessing.h"



ColorProcessing::ColorProcessing()
{
}


ColorProcessing::~ColorProcessing()
{
}

cv::Mat ColorProcessing::Hsv(const cv::Mat & image)
{
	cv::Mat hsv;
	cv::Mat inrg;
	cv::cvtColor(image, hsv, cv::COLOR_BGR2Lab);
	std::vector<cv::Mat> channels;
	cv::split(hsv, channels);
	

	/*cv::imshow("img", image);
	cv::imshow("0", channels[0]);
	cv::imshow("1", channels[1]);
	cv::imshow("2", channels[2]);
	cv::imwrite("d:\\1.jpg", channels[2]);
	cv::inRange(channels[2], 20, 45, inrg);
	cv::imshow("g", inrg);*/
	return channels[2];
}
