using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionFormsC_
{
    public class LZ78
    {
        // Структура для хранения пары кодов LZ78
        public struct LZ78Pair
        {
            public int Index;
            public char NextChar;

            public LZ78Pair(int idx, char ch)
            {
                Index = idx;
                NextChar = ch;
            }
        }

        // Сжатие строки с помощью LZ78
        public List<LZ78Pair> Compress(string input)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<LZ78Pair> compressedData = new List<LZ78Pair>();

            string currentString = "";
            int dictIndex = 1; // Индекс начинается с 1

            foreach (char c in input)
            {
                currentString += c;

                // Если строка отсутствует в словаре, добавляем её
                if (!dictionary.ContainsKey(currentString))
                {
                    int prefixIndex = currentString.Length > 1
                        ? dictionary[currentString.Substring(0, currentString.Length - 1)]
                        : 0;
                    compressedData.Add(new LZ78Pair(prefixIndex, c));

                    // Добавляем новую строку в словарь
                    dictionary[currentString] = dictIndex++;
                    currentString = "";
                }
            }

            // Обработка оставшейся строки
            if (!string.IsNullOrEmpty(currentString))
            {
                string prefix = currentString.Length > 1 ? currentString.Substring(0, currentString.Length - 1) : "";
                int prefixIndex = 0; // По умолчанию 0 для пустого префикса

                if (dictionary.ContainsKey(prefix))
                {
                    prefixIndex = dictionary[prefix];
                }
                compressedData.Add(new LZ78Pair(prefixIndex, currentString.Last()));
            }

            return compressedData;
        }

        // Декомпрессия данных LZ78
        public string Decompress(List<LZ78Pair> compressedData)
        {
            List<string> dictionary = new List<string> { "" }; // Нулевая строка
            string decompressedString = "";

            foreach (var pair in compressedData)
            {
                string prefix = dictionary[pair.Index];
                string entry = prefix + pair.NextChar;
                decompressedString += entry;

                // Добавляем запись в словарь
                dictionary.Add(entry);
            }

            return decompressedString;
        }

        public int CalculateLabelLength(List<LZ78Pair> compressedData)
        {
            int totalBits = 0;
            int dictionarySize = 0;

            foreach (var pair in compressedData)
            {
                int indexBits = dictionarySize > 0 ? (int)Math.Ceiling(Math.Log(dictionarySize) / Math.Log(2)) : 1;
                totalBits += indexBits;
                totalBits += 8;
                dictionarySize++; // Увеличиваем размер словаря
            }

            return totalBits;
        }
    }
}
