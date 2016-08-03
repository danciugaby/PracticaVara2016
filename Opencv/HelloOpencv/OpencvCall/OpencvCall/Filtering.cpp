#include "Filtering.h"



Filtering::Filtering()
{
}


Filtering::~Filtering()
{
}

cv::Mat Filtering::KernelFilter(cv::Mat & img)
{
	cv::Mat result = img.clone();

	for (size_t i = 2; i < img.cols-2; i++)
	{
		for (size_t j= 2; j < img.rows-2; j++)
		{
			double sum = 0;
			for (int k = -2; k < 3; k++)
			{
				for (int v = -2; v < 3; v++)
				{
					sum += img.at<uchar>(j + v, i + k);
					
				}
			}
			sum /= 25.;
			
			result.at<uchar>(j, i) = (uchar)sum;
		}
	
	}
	
	return result;
}

void Filtering::EdgeFilter(cv::Mat & img)
{
	cv::Mat dstx,dsty, dst;
	cv::Sobel(img, dstx, 0, 0, 1);
	cv::Sobel(img, dsty, 0, 1, 0);
	dst = dstx.mul( dstx) + dsty.mul(dsty);
	cv::Mat kernel = (cv::Mat_<double>(3, 3) << -1, 0, 1, -2, 0, 2, -1, 0, 1);
	
	cv::Mat result = img.clone();

	for (size_t i = 1; i < img.cols - 1; i++)
	{
		for (size_t j = 1; j < img.rows - 1; j++)
		{
			double sum = 0;
			for (int k = -1; k < 2; k++)
			{
				for (int v = -1; v < 2; v++)
				{
					sum += img.at<uchar>(j + v, i + k) * kernel.at<double>(k+1, v+1);
				}
			}
			
			result.at<uchar>(j, i) = (uchar)sum+127;
		}

	}
	cv::threshold(result, result, 160, 255, cv::THRESH_BINARY);
	cv::imshow("dst", dst);
	cv::imshow("gray", img);
	cv::imshow("result", result);
	cv::Mat roi = result(cv::Rect(100, 100, 200, 200));
	cv::imshow("roi", roi);
	cv::waitKey(0);

}
