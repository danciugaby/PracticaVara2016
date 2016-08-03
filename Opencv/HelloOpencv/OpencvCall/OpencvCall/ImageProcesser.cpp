#include "ImageProcesser.h"



ImageProcesser::ImageProcesser(char* path)
{
	
	_img = cv::imread(path);
}


ImageProcesser::~ImageProcesser()
{
}

void ImageProcesser::GrayImage()
{
	
	cv::imshow("img", _img);
	cv::waitKey();
	cv::Mat gray(_img.rows, _img.cols,CV_8UC1) ;
	cv::Mat grayfalse(_img.rows, _img.cols, CV_8UC1);
	cv::Scalar s;

	for (int i = 0; i < _img.cols;i++)
		for (size_t j = 0; j < _img.rows; j++)
		{
			gray.at<uchar>(cv::Point(i, j)) =
				_img.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[0] * 0.11 +
				_img.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[1] * 0.59 +
				_img.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[2] * 0.3;

			grayfalse.at<uchar>(cv::Point(i, j)) =
				(_img.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[0] +
					_img.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[1] +
					_img.at<cv::Vec<uchar, 3>>(cv::Point(i, j)).val[2]) /3.0;
		}
	cv::imshow("gray", gray);
	cv::imshow("grayf", grayfalse);
	cv::waitKey();

}

void ImageProcesser::InvertImage()
{

	int nRows = _img.rows;
	int nCols = _img.cols * _img.channels();

	uchar* p = _img.data;

	for (int i = 0; i < nRows; ++i)
	{
		p = _img.ptr<uchar>(i);

		for (int j = 0; j < nCols; j=j+3)
		{
			p[j] = 255-p[j];
		}
	}
	cv::imshow("img", _img);

	cv::waitKey();
}

void ImageProcesser::PlayWithImages()
{
	ColorProcessing cp;
	
	Filtering f;
	cv::Mat gray = cp.Hsv(_img);
	//cv::cvtColor(_img, gray, cv::COLOR_BGR2GRAY);
	f.EdgeFilter(f.KernelFilter(gray));
}
