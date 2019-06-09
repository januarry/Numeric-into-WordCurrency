using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMoneyWord
{
    public class Program
    {
        private Dictionary<string, string> moneyWordDict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.InitializedValueMoneyDict();

            string num = Console.ReadLine();
            Console.WriteLine(p.PrintWordOfNum(num, num.Length));
            Console.Read();

        }

        // Convert amount numeric into words (in currency) with recursive
        public string PrintWordOfNum(string num, int len)
        {
            if (len == 1) return moneyWordDict[num];
            if (len == 2)
            {
                if (num[len - 2] == '0' && num[len - 1] == '0') return  moneyWordDict[num[len - 1].ToString()];
                else if (num[len - 2] == '0') return "AND" + " " + moneyWordDict[num[len - 1].ToString()];
                else
                    return moneyWordDict[num];
            }

            if (len == 3)
                if (num[len - 3] == '0') return PrintWordOfNum(num.Substring(len - 2, 2), len - 1);
                else
                return (moneyWordDict[num[len - 3].ToString()] +  " HUNDRED " + PrintWordOfNum(num.Substring(len - 2,2), len - 1)).TrimEnd();

            #region Thousand
            //Begin of thousand amount
            if (len == 4)
                if (num[len - 4] == '0') return PrintWordOfNum(num.Substring(len - 3, 3), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 4, 1), len - 3) + " THOUSAND " + PrintWordOfNum(num.Substring(len - 3, 3), len - 1)).TrimEnd();
            if (len == 5)
                if (num[len - 5] == '0') return PrintWordOfNum(num.Substring(len - 4, 4), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 5, 2), len - 3) + " THOUSAND " + PrintWordOfNum(num.Substring(len - 3, 3), len - 2)).TrimEnd();
            if (len == 6)
                if (num[len - 6] == '0') return PrintWordOfNum(num.Substring(len - 5, 5), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 6, 3), len - 3) + " THOUSAND " + PrintWordOfNum(num.Substring(len - 3, 3), len - 3)).TrimEnd();
            // End of thousand amount
            #endregion thousand

            #region Million
            //Begin of million amount
            if (len == 7)
                if (num[len - 7] == '0') return PrintWordOfNum(num.Substring(len - 6, 6), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 7, 1), len - 6) + " MILLION " + PrintWordOfNum(num.Substring(len - 6, 6), len - 1)).TrimEnd();
            if (len == 8)
                if (num[len - 8] == '0') return PrintWordOfNum(num.Substring(len - 7, 7), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 8, 2), len - 6) + " MILLION " + PrintWordOfNum(num.Substring(len - 6, 6), len - 2)).TrimEnd();
            if (len == 9)
                if (num[len - 9] == '0') return PrintWordOfNum(num.Substring(len - 8, 8), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 9, 3), len - 6) + " MILLION " + PrintWordOfNum(num.Substring(len - 6, 6), len - 3)).TrimEnd();
            // End of million amount
            #endregion Million

            #region Billion
            //Begin of billion amount
            if (len == 10)
                if (num[len - 10] == '0') return PrintWordOfNum(num.Substring(len - 9, 9), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 10, 1), len - 9) + " BILLION " + PrintWordOfNum(num.Substring(len - 9, 9), len - 1)).TrimEnd();
            if (len == 11)
                if (num[len - 11] == '0') return PrintWordOfNum(num.Substring(len - 10, 10), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 11, 2), len - 9) + " BILLION " + PrintWordOfNum(num.Substring(len - 9, 9), len - 2)).TrimEnd();
            if (len == 12)
                if (num[len - 12] == '0') return PrintWordOfNum(num.Substring(len - 11, 11), len - 1);
                else
                return (PrintWordOfNum(num.Substring(len - 12, 3), len - 9) + " BILLION " + PrintWordOfNum(num.Substring(len - 9, 9), len - 3)).TrimEnd();
            //End of billion amount
            #endregion Billion
            return "";
        }

        public void InitializedValueMoneyDict()
        {
            moneyWordDict.Add("0", "");
            moneyWordDict.Add("1", "ONE");
            moneyWordDict.Add("2", "TWO");
            moneyWordDict.Add("3", "THREE");
            moneyWordDict.Add("4", "FOUR");
            moneyWordDict.Add("5", "FIVE");
            moneyWordDict.Add("6", "SIX");
            moneyWordDict.Add("7", "SEVEN");
            moneyWordDict.Add("8", "EIGHT");
            moneyWordDict.Add("9", "NINE");
            moneyWordDict.Add("10", "TEN");
            moneyWordDict.Add("11", "ELEVEN");
            moneyWordDict.Add("12", "TWELVE");
            moneyWordDict.Add("13", "THIRTEEN");
            moneyWordDict.Add("14", "FOURTEEN");
            moneyWordDict.Add("15", "FIFTEEN");
            moneyWordDict.Add("16", "SIXTEEN");
            moneyWordDict.Add("17", "SEVENTEEN");
            moneyWordDict.Add("18", "EIGHTEEN");
            moneyWordDict.Add("19", "NINETEEN");
            moneyWordDict.Add("20", "TWENTY");
            moneyWordDict.Add("21", "TWENTY-ONE");
            moneyWordDict.Add("22", "TWENTY-TWO");
            moneyWordDict.Add("23", "TWENTY-THREE");
            moneyWordDict.Add("24", "TWENTY-FOUR");
            moneyWordDict.Add("25", "TWENTY-FIVE");
            moneyWordDict.Add("26", "TWENTY-SIX");
            moneyWordDict.Add("27", "TWENTY-SEVEN");
            moneyWordDict.Add("28", "TWENTY-EIGHT");
            moneyWordDict.Add("29", "TWENTY-NINE");
            moneyWordDict.Add("30", "THIRTY");
            moneyWordDict.Add("31", "THIRTY-ONE");
            moneyWordDict.Add("32", "THIRTY-TWO");
            moneyWordDict.Add("33", "THIRTY-THREE");
            moneyWordDict.Add("34", "THIRTY-FOUR");
            moneyWordDict.Add("35", "THIRTY-FIVE");
            moneyWordDict.Add("36", "THIRTY-SIX");
            moneyWordDict.Add("37", "THIRTY-SEVEN");
            moneyWordDict.Add("38", "THIRTY-EIGHT");
            moneyWordDict.Add("39", "THIRTY-NINE");
            moneyWordDict.Add("40", "FOURTY");
            moneyWordDict.Add("41", "FOURTY-ONE");
            moneyWordDict.Add("42", "FOURTY-TWO");
            moneyWordDict.Add("43", "FOURTY-THREE");
            moneyWordDict.Add("44", "FOURTY-FOUR");
            moneyWordDict.Add("45", "FOURTY-FIVE");
            moneyWordDict.Add("46", "FOURTY-SIX");
            moneyWordDict.Add("47", "FOURTY-SEVEN");
            moneyWordDict.Add("48", "FOURTY-EIGHT");
            moneyWordDict.Add("49", "FOURTY-NINE");
            moneyWordDict.Add("50", "FIFTY");
            moneyWordDict.Add("51", "FIFTY-ONE");
            moneyWordDict.Add("52", "FIFTY-TWO");
            moneyWordDict.Add("53", "FIFTY-THREE");
            moneyWordDict.Add("54", "FIFTY-FOUR");
            moneyWordDict.Add("55", "FIFTY-FIVE");
            moneyWordDict.Add("56", "FIFTY-SIX");
            moneyWordDict.Add("57", "FIFTY-SEVEN");
            moneyWordDict.Add("58", "FIFTY-EIGHT");
            moneyWordDict.Add("59", "FIFTY-NINE");
            moneyWordDict.Add("60", "SIXTY");
            moneyWordDict.Add("61", "SIXTY-ONE");
            moneyWordDict.Add("62", "SIXTY-TWO");
            moneyWordDict.Add("63", "SIXTY-THREE");
            moneyWordDict.Add("64", "SIXTY-FOUR");
            moneyWordDict.Add("65", "SIXTY-FIVE");
            moneyWordDict.Add("66", "SIXTY-SIX");
            moneyWordDict.Add("67", "SIXTY-SEVEN");
            moneyWordDict.Add("68", "SIXTY-EIGHT");
            moneyWordDict.Add("69", "SIXTY-NINE");
            moneyWordDict.Add("70", "SEVENTY");
            moneyWordDict.Add("71", "SEVENTY-ONE");
            moneyWordDict.Add("72", "SEVENTY-TWO");
            moneyWordDict.Add("73", "SEVENTY-THREE");
            moneyWordDict.Add("74", "SEVENTY-FOUR");
            moneyWordDict.Add("75", "SEVENTY-FIVE");
            moneyWordDict.Add("76", "SEVENTY-SIX");
            moneyWordDict.Add("77", "SEVENTY-SEVEN");
            moneyWordDict.Add("78", "SEVENTY-EIGHT");
            moneyWordDict.Add("79", "SEVENTY-NINE");
            moneyWordDict.Add("80", "EIGHTY");
            moneyWordDict.Add("81", "EIGHTY-ONE");
            moneyWordDict.Add("82", "EIGHTY-TWO");
            moneyWordDict.Add("83", "EIGHTY-THREE");
            moneyWordDict.Add("84", "EIGHTY-FOUR");
            moneyWordDict.Add("85", "EIGHTY-FIVE");
            moneyWordDict.Add("86", "EIGHTY-SIX");
            moneyWordDict.Add("87", "EIGHTY-SEVEN");
            moneyWordDict.Add("88", "EIGHTY-EIGHT");
            moneyWordDict.Add("89", "EIGHTY-NINE");
            moneyWordDict.Add("90", "NINETY");
            moneyWordDict.Add("91", "NINETY-ONE");
            moneyWordDict.Add("92", "NINETY-TWO");
            moneyWordDict.Add("93", "NINETY-THREE");
            moneyWordDict.Add("94", "NINETY-FOUR");
            moneyWordDict.Add("95", "NINETY-FIVE");
            moneyWordDict.Add("96", "NINETY-SIX");
            moneyWordDict.Add("97", "NINETY-SEVEN");
            moneyWordDict.Add("98", "NINETY-EIGHT");
            moneyWordDict.Add("99", "NINETY-NINE");
            //moneyWordDict.Add("100", "ONE HUNDRED");
            //moneyWordDict.Add("1000", "ONE THOUSAND");

        }

    }


}
