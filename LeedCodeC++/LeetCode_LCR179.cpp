#include "LeetCode_LCR179.h"


LeetCode_LCR179::LeetCode_LCR179() {

}
LeetCode_LCR179::~LeetCode_LCR179() {

}

vector<int> LeetCode_LCR179::twoSum(vector<int>& price, int target)
{
	int left = 0, right = price.size() - 1;
	int count = price.size();
	
	while (left < right) {

		int sum = price[left] + price[right];
		if (sum > target) {
			right--;
		}
		else if(sum < target)
		{
			left++;
		}
		else
		{
			return { price[left],price[right] };
		}
	}

	return {};
}

