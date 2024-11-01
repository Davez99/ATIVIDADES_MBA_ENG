using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Identifier
    {
        public bool ValidateIdentifier(string s)
        {
            char achar;
            bool validId = false;
            if(string.IsNullOrEmpty(s)) return false; // Correção CT6

            achar = s[0];
            validId = ValidStartChar(achar);

            if (s.Length > 1)
            {
                int i = 1;
                while (i < s.Length - 1)
                {
                    achar = s[i];
                    if (!ValidFollowingChar(achar))
                        validId = false;
                    i++;
                }
            }

            if (validId && s.Length >= 1 && s.Length <= 6)  //Correção CT7
                return true;
            else
                return false;
        }

        public bool ValidStartChar(char ch)
        {
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                return true;
            else
                return false;
        }

        public bool ValidFollowingChar(char ch)
        {
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9'))
                return true;
            else
                return false;
        }
    }

}