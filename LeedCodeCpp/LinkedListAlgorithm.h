#pragma once

struct ListNode {
	int val;
	ListNode* next;
	ListNode() : val(0), next(nullptr) {}
	ListNode(int x) : val(x), next(nullptr) {}
	ListNode(int x, ListNode* next) : val(x), next(next) {}
};
class LinkedListAlgorithm
{
public:
	ListNode* leetcode203_removeElements(ListNode* head, int val);

	ListNode* leetcode206_reverseList(ListNode* head);
	ListNode* leetcode24_swapPairs(ListNode* head);
	ListNode* leetcode19_removeNthFromEnd(ListNode* head, int n);
};

