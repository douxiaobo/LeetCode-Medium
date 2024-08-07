class Solution:
    def isStrictlyPalindromic(self, n: int) -> bool:
        for baseNum in range(2, n - 1):
            if not self.isPalindromeInBase(n, baseNum):
                return False
        return True

    def isPalindromeInBase(self, num: int, baseNum: int) -> bool:
        numStr = self.convertToBase(num, baseNum)
        left, right = 0, len(numStr) - 1
        while left < right:
            if numStr[left] != numStr[right]:
                return False
            left += 1
            right -= 1
        return True

    def convertToBase(self, num: int, baseNum: int) -> str:
        if num == 0:
            return "0"
        result = ""
        while num > 0:
            remainder = num % baseNum
            result = str(remainder) + result
            num //= baseNum
        return result

# 示例测试
solution = Solution()
print(solution.isStrictlyPalindromic(9))  # 输出: False