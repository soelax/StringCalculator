namespace StringCalculator
{
    public class StringAdder
    {
        public StringAdder()
        {
        }

        public string add(string first, string second)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            if(first.Length > second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            } else if(second.Length > first.Length)
            {
                first = first.PadLeft(second.Length, '0');
            }

            var firstChars = first.ToCharArray();
            var secondChars = second.ToCharArray();
            int carryOver = 0;
            for(int i = firstChars.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(firstChars[i].ToString()) + int.Parse(secondChars[i].ToString()) + carryOver;
                if(sum >= 10)
                {
                    carryOver = 1;
                    sum = sum - 10;
                }
                else
                {
                    carryOver = 0;
                }
                result.Append(sum.ToString());
            }
            if (carryOver > 0) result.Append(carryOver);
            
            return Tools.reverse(result.ToString());
        }

        
    }
}