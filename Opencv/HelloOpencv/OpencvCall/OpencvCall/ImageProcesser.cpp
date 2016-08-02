#include "ImageProcesser.h"



ImageProcesser::ImageProcesser()
{
}


ImageProcesser::~ImageProcesser()
{
}

void ImageProcesser::GrayImage(char * path)
{
	cv::Mat image = cv::imread(path);
	cv::imshow("img", image);
	cv::waitKey();
	cv::Mat gray(image.rows,image.cols,CV_8UC1) ;
	cv::Mat grayfalse(image.rows, image.cols, CV_8UC1);
	cv::Scalar s;

	for (int i = 0; i < image.cols;i++)
		for (size_t j = 0; j < image.rows; j++)
		{
			gray.at<uchar>(cv::Point(i, j)) =
				image.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[0] * 0.11 +
				image.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[1] * 0.59 +
				image.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[2] * 0.3;

			grayfalse.at<uchar>(cv::Point(i, j)) =
				(image.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[0] +
				image.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[1] +
				image.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[2]) /3.0;
		}
	cv::imshow("gray", gray);
	cv::imshow("grayf", grayfalse);
	cv::waitKey();

}
