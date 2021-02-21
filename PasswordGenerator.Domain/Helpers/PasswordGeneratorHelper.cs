using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Domain.Helpers
{
    public class PasswordGeneratorHelper
    {



        static Random random = new Random();


        /// <summary>
        /// パスワードの生成
        /// </summary>
        /// <param name="length"></param>
        /// <param name="types"></param>
        /// <returns></returns>
        public static string Create(int length, int[] types)
        {


            var useTypes = new int[length];
            var useTypesLength = types.Length;


            for (var i = 0; i < useTypesLength; i++)
            {
                useTypes[i] = types[i];
            }

            for (var i = useTypesLength; i < length; i++)
            {
                useTypes[i] = types[random.Next(0, types.Length)];
            }


            List<char> chars = new List<char>();


            foreach (int useType in useTypes)
            {

                chars.Add(getAllowedChar( useType ));
            }


            string password = new String(chars.ToArray());


            return password;
        }




        public static char getAllowedChar(int type)
        {
            if (type == 1)
            {
                return AlphabetRandom();

            }
            else if (type == 2)
            {

                return NumberRandom();
            }
            return ' ';
        }



        /// <summary>
        /// アルファベットの文字を一つ返す
        /// </summary>
        /// <returns></returns>
        public static char AlphabetRandom()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return GetRandomChar(chars);
        }


        /// <summary>
        /// 数値を一つ文字を返す
        /// </summary>
        /// <returns></returns>
        public static char NumberRandom()
        {
            string chars = "1234567890";
            return GetRandomChar(chars);
        }


        public static char GetRandomChar(string chars)
        {
            int num = random.Next(0, chars.Length - 1);
            return chars[num];
        }


    }
}
