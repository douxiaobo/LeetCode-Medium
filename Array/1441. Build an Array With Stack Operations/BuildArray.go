package main

import "fmt"

func buildArray(target []int, n int) []string {
	result := []string{}
	index := 1
	for i := 0; i < len(target); i++ {
		for target[i] > index {
			result = append(result, "Push")
			result = append(result, "Pop")
			index++
		}
		result = append(result, "Push")
		index++
	}
	return result
}

func main() {
	target := []int{1, 3}
	n := 3
	result := buildArray(target, n)
	fmt.Println(result)
}
