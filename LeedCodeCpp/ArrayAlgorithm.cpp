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

	//Method 1: 直接平方后排序
	//vector<int> result;
	//for (int num : nums)
	//{
	//	result.push_back(num * num);
	//}
	//sort(result.begin(), result.end());

	//Method 2: 双指针
	int len = nums.size();
	int left = 0;
	int right = len - 1;
	int pos = len - 1;
	vector<int> result(len);

	while (left <= right) {

		int leftSquare = nums[left] * nums[left];
		int rightSquare = nums[right] * nums[right];

		if (leftSquare > rightSquare) {
			result[pos--] = leftSquare;
			left++;
		}else {
			result[pos--] = rightSquare;
			right--;
		}
	}

	return result;
}

int ArrayAlgorithm::Leetcode209_minSubArrayLen(int target, vector<int>& nums) {
	
	// 滑动窗口
	int left = 0, right = 0;
	int minLength = INT_MAX;
	int sum = 0;
	int len = nums.size();
	while (right < len) {
		
		sum += nums[right];
		while(sum >= target) {
			minLength = min(minLength, right - left + 1);
			sum -= nums[left];
			left++;
		}
		right++;
	}
	
	return minLength == INT_MAX? 0 : minLength;
}

vector<vector<int>> ArrayAlgorithm::Leetcode59_generateMatrix(int n)
{
	vector<vector<int>> res(n,vector<int>(n,0));
	int top = 0, bottom = n - 1, left = 0, right = n - 1;
	int num = 1;
	while(num <= n*n) {
		
		for (int i = left;i <= right;i++) {
			res[top][i] = num++;
		}
		top++;
		for (int i = top; i <= bottom; i++)
		{
			res[i][right] = num++;
		}
		right--;
		for (int i = right; i >= left; i--)
		{
			res[bottom][i] = num++;
		}
		bottom--;
		for (int i = bottom; i >= top; i--)
		{
			res[i][left] = num++;
		}
		left++;
	}
	
	return res;
}

vector<int> ArrayAlgorithm::Leetcode54_spiralOrder(vector<vector<int>>& matrix)
{
	vector<int> res;
	int rows = matrix.size();
	int columns = matrix[0].size();
	int top = 0, bottom = matrix.size() - 1, left = 0, right = matrix[0].size() - 1;

	while (res.size() < rows*columns) {
		
		for (int i = left; i <= right && res.size() < rows * columns; i++) {

			res.push_back(matrix[top][i]);
		}
		top++;
		for (int i = top; i <=bottom && res.size() < rows * columns; i++)
		{
			res.push_back(matrix[i][right]);
		}
		right--;
		for (int i = right; i >= left && res.size() < rows * columns; i--)
		{
			res.push_back(matrix[bottom][i]);
		}
		bottom--;
		for (int i = bottom; i >= top && res.size() < rows * columns; i--)
		{
			res.push_back(matrix[i][left]);
		}
		left++;
	}

	return res;
}