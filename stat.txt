using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionFormsC_
{
    class LZW
    {
        private Dictionary<string, int> compressDict;
        private Dictionary<int, string> decompressDict;
        private int dictSize;

        public LZW()
        {
            compressDict = new Dictionary<string, int>();
            decompressDict = new Dictionary<int, string>();
            ResetDictionaries();
        }

        // Reset dictionaries
        private void ResetDictionaries()
        {
            compressDict.Clear();
            decompressDict.Clear();
            dictSize = 256;

            for (int i = 0; i < 256; i++)
            {
                string ch = ((char)i).ToString();
                compressDict[ch] = i;
                decompressDict[i] = ch;
            }
        }

        // Compress string
        public List<int> Compress(string input)
        {
            ResetDictionaries();

            string currentStr = "";
            List<int> compressed = new List<int>();

            foreach (char c in input)
            {
                string newStr = currentStr + c;

                if (compressDict.ContainsKey(newStr))
                {
                    currentStr = newStr;
                }
                else
                {
                    compressed.Add(compressDict[currentStr]);
                    compressDict[newStr] = dictSize++;
                    currentStr = c.ToString();
                }
            }

            if (!string.IsNullOrEmpty(currentStr))
            {
                compressed.Add(compressDict[currentStr]);
            }

            return compressed;
        }

        // Decompress
        public string Decompress(List<int> compressed)
        {
            ResetDictionaries();

            string currentStr = decompressDict[compressed[0]];
            string decompressed = currentStr;

            for (int i = 1; i < compressed.Count; i++)
            {
                int code = compressed[i];
                string newStr;

                if (decompressDict.ContainsKey(code))
                {
                    newStr = decompressDict[code];
                }
                else if (code == dictSize)
                {
                    newStr = currentStr + currentStr[0];
                }
                else
                {
                    throw new InvalidOperationException("Invalid compressed code");
                }

                decompressed += newStr;
                decompressDict[dictSize++] = currentStr + newStr[0];
                currentStr = newStr;
            }

            return decompressed;
        }

        // Calculate bit size
        public int CalculateBitSize(List<int> compressed)
        {
            int maxCode = compressed.Max();
            int bitsPerCode = (int)Math.Ceiling(Math.Log(maxCode + 1) / Math.Log(2));
            return compressed.Count * bitsPerCode;
        }
    }
}
