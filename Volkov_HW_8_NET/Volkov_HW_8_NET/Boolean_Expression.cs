using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Volkov_HW_8_NET
{
    internal class Boolean_Expression
    {
        private string expression;
        private string character;

        public Boolean_Expression()
        {
            expression = string.Empty;
        }

        public Boolean_Expression(string expression)
        {
            this.expression = expression;
        }

        public void Input()
        {
            Console.WriteLine("Enter expression");
            expression = Console.ReadLine();
            string[] symbols = { "<", ">", "==", "!=", "<=", ">="};
            for (int i = 0; i < symbols.Length; i++)
            {
                if (expression.IndexOf(symbols[i]) > 0)
                {
                    character += expression[expression.IndexOf(symbols[i])];
                    if (expression[expression.IndexOf(symbols[i]) + 1] == '=')
                        character += "=";
                    break;
                }
                if (i == symbols.Length - 1)
                {
                    throw new Exception("Symbol not found");
                }
            }
        }

        public bool Solution()
        {
            bool result = false;
            string[] str = expression.Split(' ');
            switch (character)
            {
                case ">":
                    result = (Convert.ToInt32(str[0]) > Convert.ToInt32(str[2])) ? true : false;
                    break;
                case "<":
                    result = (Convert.ToInt32(str[0]) < Convert.ToInt32(str[2])) ? true : false;
                    break;
                case "==":
                    result = (Convert.ToInt32(str[0]) == Convert.ToInt32(str[2])) ? true : false;
                    break;
                case "!=":
                    result = (Convert.ToInt32(str[0]) != Convert.ToInt32(str[2])) ? true : false;
                    break;
                case "<=":
                    result = (Convert.ToInt32(str[0]) <= Convert.ToInt32(str[2])) ? true : false;
                    break;
                case ">=":
                    result = (Convert.ToInt32(str[0]) >= Convert.ToInt32(str[2])) ? true : false;
                    break;
            }
            return result;
        }

        public override string ToString()
        {
            return $"Expression -> {expression}";
        }
    }
}
