public class Solution {
    public bool IsValid(string s) {
        if (s.Length%2!=0) return false;
        var stack = new Stack<char>();

        for (int i=0; i<s.Length; i++)
        {
            var element = s[i];

            if(element == '(' || element == '{' || element == '[')
            {
                stack.Push(element);
            }

            else {
                if (stack.Count == 0) return false;

                if((element == ')' && stack.Peek() == '(') 
                || (element == '}' && stack.Peek() == '{') 
                || (element == ']' && stack.Peek() == '['))
                {
                    stack.Pop();
                }

                else return false;
            }
        }

        return stack.Count == 0;
    }
}
