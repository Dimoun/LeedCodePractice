#include "ArrayAlgorithm.h"
#include <algorithm>

int ArrayAlgorithm::LeetCode704_search(vector<int>& nums, int target) {

	int i=0,j = nums.size()-1;
	while (i<=j)
	{
		int mid = i + (j - i) / 2;

		if (nums[mid] == target) {
			return mid;
		}
		else if (nums[mid] > target) {
			j = mid - 1;
		}
		else if (nums[mid] < target) {
			i = mid + 1;
		}
	}
	
	return -1;
}

int ArrayAlgorithm::Leetcode27_removeElement(vector<int>& nums, int val) {

	int left = 0, right = nums.size()- 1;
	
	while (left <= right) {
		if (nums[left] == val) {
			nums[left] = nums[right];
			right--;
		}
		else
		{
			left++;
		}
	}
	return left;

}

vector<int> ArrayAlgorithm::LeetCode_977_sortedSquares(vector<int>& nums) {

	vector<int> result;
	for (int num : nums)
	{
		result.push_back(num * num);
	}
	sort(result.begin(), result.end());



	return result;
}