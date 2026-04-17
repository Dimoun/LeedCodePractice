#include "HashTableAlgorithm.h"
#include <unordered_map>
#include <unordered_set>
#include <string.h>

bool HashTableAlgorithm::leetcode242_isAnagram(string s, string t) {
	
	unordered_map<char, int> dic;
	int sLen = s.length();
	int tLen = t.length();
	if(sLen != tLen) {
		return false;
	}

	for (int i = 0; i < sLen; i++)
	{
		dic[s[i]]++;
	}
	for (int i = 0; i < tLen; i++)
	{
		dic[t[i]]--;
		if(dic[t[i]] < 0) {
			return false;
		}
	}
	
	return true;
}

vector<int> HashTableAlgorithm::leetcode349_intersection(vector<int>& nums1, vector<int>& nums2) {
	
	unordered_set<int> set;
	vector<int> res;

	for(int num : nums1) {
		set.insert(num);
	}
	for (int num : nums2) {
		if(set.count(num) > 0) {
			res.push_back(num);
			set.erase(num);
		}
	}
	return res;
}

bool HashTableAlgorithm::leetcode202_isHappy(int n) {
	int temp = n;
	unordered_set<int> set;

	while (true)
	{
		int sum = 0;
		while (temp != 0)
		{
			sum += (temp % 10) * (temp % 10);
			temp /= 10;
		}
		
		if(sum == 1) {
			return true;
		}
		
		if(set.find(sum) != set.end()) {
			return false;
		}
		else
		{
			set.insert(sum);
		}
		temp = sum;
	}

	return true;
}

vector<int> HashTableAlgorithm::leetcode1_twoSum(vector<int>& nums, int target) {
	
	vector<int> res;
	unordered_map<int, int> dic;
	for(int i=0; i< nums.size(); i++) {
		int temp = target - nums[i];
		if (dic.contains(temp)) {
			return res = { dic[temp], i };
		}
		else
		{
			dic[nums[i]] = i;
		}
	}
	return res;
}



