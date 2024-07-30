func minPartitions(n string) int {
	maxDigit := 0
	for _, digit := range n {
		currentDigit := int(digit - '0')
		if currentDigit > maxDigit {
			maxDigit = currentDigit
		}
		if maxDigit == 9 {
			break
		}
	}
	return maxDigit
}