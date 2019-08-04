using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static bool IsLegalVotingAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }

            return false;
        }
    }
}
