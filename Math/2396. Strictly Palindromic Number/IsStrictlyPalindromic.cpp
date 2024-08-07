#include <iostream>
#include <string>
#include <algorithm>

class Solution {
public:
    bool isStrictlyPalindromic(int n) {
        for (int baseNum = 2; baseNum <= n - 2; baseNum++) {
            if (!isPalindromeInBase(n, baseNum)) {
                return false;
            }
        }
        return true;
    }

private:
    bool isPalindromeInBase(int num, int baseNum) {
        std::string numStr = convertToBase(num, baseNum);
        int left = 0, right = numStr.length() - 1;
        while (left < right) {
            if (numStr[left] != numStr[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    std::string convertToBase(int num, int baseNum) {
        if (num == 0) return "0";
        std::string result;
        while (num > 0) {
            int remainder = num % baseNum;
            result.push_back('0' + remainder);
            num /= baseNum;
        }
        std::reverse(result.begin(), result.end());
        return result;
    }
};

int main() {
    Solution solution;
    std::cout << std::boolalpha << solution.isStrictlyPalindromic(9) << std::endl; // 示例测试
    return 0;
}