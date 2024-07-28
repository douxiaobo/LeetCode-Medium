package main

import "math"

// Definition for singly-linked list.
type ListNode struct {
	Val  int
	Next *ListNode
}

// GCD calculates the greatest common divisor of two integers.
func GCD(a, b int) int {
	for b != 0 {
		a, b = b, a%b
	}
	return int(math.Abs(float64(a)))
}

// insertGreatestCommonDivisors inserts nodes with the greatest common divisor values between each pair of adjacent nodes.
func insertGreatestCommonDivisors(head *ListNode) *ListNode {
	if head == nil || head.Next == nil {
		return head
	}

	current := head
	for current != nil && current.Next != nil {
		gcdVal := GCD(current.Val, current.Next.Val)
		newNode := &ListNode{Val: gcdVal, Next: current.Next}
		current.Next = newNode
		current = current.Next.Next
	}

	return head
}
