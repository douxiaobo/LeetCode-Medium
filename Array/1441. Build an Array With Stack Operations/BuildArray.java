import java.util.ArrayList;
import java.util.List;

class Solution {
    public List<String> buildArray(int[] target, int n) {
        List<String> result = new ArrayList<>();
        int index = 1;
        for (int i = 0; i < target.length; i++) {
            while (target[i] > index) {
                result.add("Push");
                result.add("Pop");
                index++;
            }
            result.add("Push");
            index++;
        }
        return result;
    }
}