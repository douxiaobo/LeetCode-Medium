from typing import List

class Solution:
    def buildArray(self, target: List[int], n: int) -> List[str]:
        result = []
        index = 1
        for num in target:
            while num > index:
                result.append("Push")
                result.append("Pop")
                index += 1
            result.append("Push")
            index += 1
        return result

# 示例用法
solution = Solution()
target = [1, 3]
n = 3
print(solution.buildArray(target, n))