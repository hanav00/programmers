using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++) {
            if (my_string[i] != 'a' && my_string[i] != 'e' && my_string[i] != 'i' && my_string[i] != 'o' && my_string[i] != 'u') {
                result.Append(my_string[i]);
            }
        }

        return result.ToString();
    }
}
