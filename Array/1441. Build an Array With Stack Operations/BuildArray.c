#include <stdio.h>
#include <stdlib.h>

char** buildArray(int* target, int targetSize, int n, int* returnSize) {
    // 计算结果数组的最大可能大小
    int maxSize = 2 * n; // 每个数字最多可能有两个操作（Push和Pop）
    char** result = (char**)malloc(maxSize * sizeof(char*));
    int index = 1;
    int resultIndex = 0;

    for (int i = 0; i < targetSize; i++) {
        while (target[i] > index) {
            result[resultIndex++] = "Push";
            result[resultIndex++] = "Pop";
            index++;
        }
        result[resultIndex++] = "Push";
        index++;
    }

    // 设置返回数组的大小
    *returnSize = resultIndex;
    return result;
}

int main() {
    int target[] = {1, 3};
    int targetSize = sizeof(target) / sizeof(target[0]);
    int n = 3;
    int returnSize;
    char** result = buildArray(target, targetSize, n, &returnSize);

    for (int i = 0; i < returnSize; i++) {
        printf("%s\n", result[i]);
    }

    // 释放内存
    for (int i = 0; i < returnSize; i++) {
        free(result[i]);
    }
    free(result);

    return 0;
}