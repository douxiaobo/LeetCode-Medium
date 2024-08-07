public class Solution {
    public boolean isStrictlyPalindromic(int n) {
        for (int baseNum = 2; baseNum <= n - 2; baseNum++) {
            if (!isPalindromeInBase(n, baseNum)) {
                return false;
            }
        }
        return true;
    }

    private boolean isPalindromeInBase(int num, int baseNum) {
        String numStr = convertToBase(num, baseNum);
        int left = 0, right = numStr.length() - 1;
        while (left < right) {
            if (numStr.charAt(left) != numStr.charAt(right)) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    private String convertToBase(int num, int baseNum) {
        if (num == 0) return "0";
        StringBuilder result = new StringBuilder();
        while (num > 0) {
            int remainder = num % baseNum;
            result.insert(0, remainder);
            num /= baseNum;
        }
        return result.toString();
    }

    public static void main(String[] args) {
        Solution solution = new Solution();
        System.out.println(solution.isStrictlyPalindromic(9)); // 示例测试
    }
}