#include "ArrayAlgorithm.h"

int ArrayAlgorithm::search(vector<int>& nums, int target) {

	int i=0,j = nums.size();
	while (i<j)
	{
		int temp = nums[(i + j) / 2];

		if (temp == target) {
			return (i + j) / 2;
		}
		else if (temp > target) {
			j = j / 2;
		}
		else if (temp < target) {
			i = (i + j) / 2;
		}
	}
	
	return -1;
}