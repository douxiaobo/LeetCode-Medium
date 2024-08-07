#include <stdio.h>
#include <stdbool.h>
#include <string.h>
#include <stdlib.h>

bool isPalindromeInBase(int num, int baseNum);
char* convertToBase(int num, int baseNum);

bool isStrictlyPalindromic(int n) {
    for (int baseNum = 2; baseNum <= n - 2; baseNum++) {
        if (!isPalindromeInBase(n, baseNum)) {
            return false;
        }
    }
    return true;
}

bool isPalindromeInBase(int num, int baseNum) {
    char* numStr = convertToBase(num, baseNum);
    int left = 0, right = strlen(numStr) - 1;
    while (left < right) {
        if (numStr[left] != numStr[right]) {
            free(numStr);
            return false;
        }
        left++;
        right--;
    }
    free(numStr);
    return true;
}

char* convertToBase(int num, int baseNum) {
    if (num == 0) {
        char* result = (char*)malloc(2 * sizeof(char));
        result[0] = '0';
        result[1] = '\0';
        return result;
    }
    char buffer[32];
    int index = 0;
    while (num > 0) {
        int remainder = num % baseNum;
        buffer[index++] = '0' + remainder;
        num /= baseNum;
    }
    char* result = (char*)malloc((index + 1) * sizeof(char));
    for (int i = 0; i < index; i++) {
        result[i] = buffer[index - i - 1];
    }
    result[index] = '\0';
    return result;
}

int main() {
    printf("%s\n", isStrictlyPalindromic(9) ? "true" : "false"); // 示例测试
    return 0;
}
