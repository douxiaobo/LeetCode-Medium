package main

import "fmt"

type ListNode struct {
	Val  int
	Next *ListNode
}

func mergeNodes(head *ListNode) *ListNode {
	dummyHead := &ListNode{Val: 0} // 直接初始化dummyHead
	current := dummyHead           // current指向dummyHead
	sum := 0

	for head != nil {
		if head.Val > 0 {
			sum += head.Val
		} else if sum != 0 {
			newNode := &ListNode{Val: sum} // 创建新节点
			current.Next = newNode         // 连接新节点
			current = current.Next         // 移动current到新节点
			sum = 0
		}
		head = head.Next
	}

	return dummyHead.Next
}

func mergeNodes1(head *ListNode) *ListNode {
	dummyHead := &ListNode{} // 创建一个哑节点作为头节点
	current := dummyHead     // current指向哑节点
	sum := 0                 // 初始化sum为0

	for head != nil {
		if head.Val == 0 && sum != 0 { // 如果遇到0且sum不为0，说明一个区间结束
			current.Next = &ListNode{Val: sum} // 创建新节点，值为sum，连接到current
			current = current.Next             // 更新current指向新节点
			sum = 0                            // 重置sum为0
		}
		if head.Val != 0 { // 如果不是0，累加到sum
			sum += head.Val
		}
		head = head.Next // 移动到下一个节点
	}

	return dummyHead.Next
}

// helper函数用于打印链表
func printList(head *ListNode) {
	for head != nil {
		fmt.Printf("%d ", head.Val)
		head = head.Next
	}
	fmt.Println()
}

func main() {
	// 创建链表 [0,3,1,0,4,5,2,0]
	head := &ListNode{Val: 0}
	current := head
	values := []int{3, 1, 0, 4, 5, 2, 0}
	for _, val := range values {
		current.Next = &ListNode{Val: val}
		current = current.Next
	}

	// 调用mergeNodes函数
	mergedHead := mergeNodes(head.Next)
	printList(mergedHead)

	// 创建链表 [0,1,0,3,0,2,2,0]
	head1 := &ListNode{Val: 0}
	current1 := head1
	values1 := []int{1, 0, 3, 0, 2, 2, 0}
	for _, val := range values1 {
		current1.Next = &ListNode{Val: val}
		current1 = current1.Next
	}

	// 调用mergeNodes1函数
	mergedHead1 := mergeNodes1(head1.Next)
	printList(mergedHead1)
}
