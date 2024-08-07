package main

import (
	"fmt"
	"strconv"
)

func isStrictlyPalindromic(n int) bool {
	for baseNum := 2; baseNum <= n-2; baseNum++ {
		if !isPalindromeInBase(n, baseNum) {
			return false
		}
	}
	return true
}

func isPalindromeInBase(num int, baseNum int) bool {
	numStr := convertToBase(num, baseNum)
	left, right := 0, len(numStr)-1
	for left < right {
		if numStr[left] != numStr[right] {
			return false
		}
		left++
		right--
	}
	return true
}

func convertToBase(num int, baseNum int) string {
	if num == 0 {
		return "0"
	}
	var result string
	for num > 0 {
		remainder := num % baseNum
		result = strconv.Itoa(remainder) + result
		num /= baseNum
	}
	return result
}

func main() {
	fmt.Println(isStrictlyPalindromic(9)) // 示例测试
}
