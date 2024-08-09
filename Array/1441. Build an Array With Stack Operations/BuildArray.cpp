#include <vector>
#include <string>

using namespace std;

class Solution {
public:
    vector<string> buildArray(vector<int>& target, int n) {
        vector<string> result;
        int index = 1;
        for (int i = 0; i < target.size(); i++) {
            while (target[i] > index) {
                result.push_back("Push");
                result.push_back("Pop");
                index++;
            }
            result.push_back("Push");
            index++;
        }
        return result;
    }
};