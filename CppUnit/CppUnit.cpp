#include "pch.h"
#include "CppUnitTest.h"
#include "../LeedCodeCpp/ArrayAlgorithm.h"
#include <vector>
using namespace Microsoft::VisualStudio::CppUnitTestFramework;
using namespace std;

namespace CppUnit
{
	TEST_CLASS(CppUnit)
	{
	public:
		
		TEST_METHOD(ArrayAlgorithmTest)
		{
			ArrayAlgorithm arrayAlgorithm;
			//vector<int> vec = { -1,0,3,5,9,12 };
			//int res = arrayAlgorithm.LeetCode704_search(vec, 9);

	/*		vector<int> vec = { 0,1,2,2,3,0,4,2 };
			int res = arrayAlgorithm.Leetcode27_removeElement(vec, 2);*/


			//vector<int> vec = { -4,-1,0,3,10 };
			//auto res = arrayAlgorithm.LeetCode_977_sortedSquares(vec);

			vector<int> vec = { 2,3,1,2,4,3 };
			auto res = arrayAlgorithm.Leetcode209_minSubArrayLen(7,vec);
		}
	};
}
