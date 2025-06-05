public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum = 0;
        
        string nums = x.ToString();
        for (int i = 0; i < nums.Length; i++)
        {
            sum += int.Parse(nums[i].ToString());
        }
        
        return x % sum == 0 ? answer : !answer;
    }
}