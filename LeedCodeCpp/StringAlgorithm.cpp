#include "StringAlgorithm.h"

void StringAlgorithm::leetcode344_reverseString(vector<char>& s) {

	int len = s.size();
	for (int i = 0,j = len-1; i <len/2; i++,j--)
	{
		char temp = s[i];
		s[i] = s[j];
		s[j] = temp;
	}
}
