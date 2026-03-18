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
			vector<int> vec = { -1,0,3,5,9,12 };
			arrayAlgorithm.search(vec, 9);
		}
	};
}
