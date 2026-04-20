#include "LinkedListAlgorithm.h"

ListNode* LinkedListAlgorithm::leetcode203_removeElements(ListNode* head, int val) {;
	ListNode* dummyHead = new ListNode(0);
	dummyHead->next = head;
	ListNode* temp = dummyHead;

	while(temp->next != nullptr) {
		
		if (temp->next->val == val) {

			temp->next = temp->next->next;
		}
		else
		{
			temp = temp->next;
		}
	}
	return dummyHead->next;
}

ListNode* LinkedListAlgorithm::leetcode206_reverseList(ListNode* head) {
	ListNode* prev = nullptr;
	ListNode* curr = head;
	while (curr != nullptr) {
		ListNode* nextTemp = curr->next;
		curr->next = prev;
		prev = curr;
		curr = nextTemp;
	}
	return prev;
}

ListNode* LinkedListAlgorithm::leetcode24_swapPairs(ListNode* head) {

	ListNode* dummyHead = new ListNode(0);
	dummyHead->next = head;
	ListNode* cur = dummyHead;
	while (cur->next!=nullptr && cur->next->next != nullptr)
	{
		ListNode* temp1 = cur->next;
		ListNode* temp2 = cur->next->next->next;

		cur->next = temp1->next;
		cur->next->next = temp1;
		cur->next->next->next = temp2;

		cur = cur->next->next;
	}
	return dummyHead->next;
}

ListNode* LinkedListAlgorithm::leetcode19_removeNthFromEnd(ListNode* head, int n) {
	
	//Method 1 : 计算链表长度再删除
	//ListNode* dummyHead = new ListNode(0);
	//dummyHead->next = head;
	//int count = 0;
	//ListNode* temp = head;

	//while (temp != nullptr)
	//{
	//	count++;
	//	temp = temp->next;
	//}
	//if (count == 0)
	//	return nullptr;

	//int tar = count - n;
	//temp = dummyHead;
	//for (int i = 0; i < tar; i++)
	//{
	//	temp = temp->next;
	//}
	//temp->next = temp->next->next;

	//return dummyHead->next;

	//Method 2: 双指针：

	ListNode* dummyHead = new ListNode(0);
	dummyHead->next = head;
	ListNode* slow = dummyHead;
	ListNode* fast = dummyHead->next;
	
	while (n > 0 && fast != nullptr)
	{
		n--;
		fast = fast->next;
	}

	while (fast != nullptr)
	{
		slow = slow->next;
		fast = fast->next;
	}
	slow->next = slow->next->next;

	return dummyHead->next;
}

