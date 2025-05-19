using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionFormsC_
{
    public struct LZ77Token
    {
        public int Offset;
        public int Length;
        public char NextChar;
    }

    public class LZ77
    {
        private readonly int windowSize;
        private readonly int lookaheadBufferSize;

        public LZ77(int windowSize, int lookaheadBufferSize)
        {
            this.windowSize = windowSize;
            this.lookaheadBufferSize = lookaheadBufferSize;
        }

        public List<LZ77Token> Compress(string input)
        {
            List<LZ77Token> compressedData = new List<LZ77Token>();
            int inputSize = input.Length;
            int pos = 0;

            while (pos < inputSize)
            {
                int matchOffset = 0, matchLength = 0;
                FindLongestMatch(input, pos, ref matchOffset, ref matchLength);

                char nextChar = pos + matchLength < inputSize ? input[pos + matchLength] : '\0';
                compressedData.Add(new LZ77Token { Offset = matchOffset, Length = matchLength, NextChar = nextChar });

                pos += matchLength + 1;
            }

            return compressedData;
        }

        public string Decompress(List<LZ77Token> compressedData)
        {
            string decompressedData = "";
            foreach (var token in compressedData)
            {
                if (token.Length > 0)
                {
                    int start = decompressedData.Length - token.Offset;
                    for (int i = 0; i < token.Length; i++)
                    {
                        decompressedData += decompressedData[start + i];
                    }
                }
                if (token.NextChar != '\0')
                {
                    decompressedData += token.NextChar;
                }
            }
            return decompressedData;
        }

        private void FindLongestMatch(string input, int pos, ref int matchOffset, ref int matchLength)
        {
            matchOffset = 0;
            matchLength = 0;

            int start = Math.Max(0, pos - windowSize);
            int end = Math.Min(pos + lookaheadBufferSize, input.Length);

            for (int i = start; i < pos; i++)
            {
                int length = 0;
                while (length < lookaheadBufferSize && pos + length < end && input[i + length] == input[pos + length])
                {
                    length++;
                }
                if (length > matchLength)
                {
                    matchLength = length;
                    matchOffset = pos - i;
                }
            }
        }

        public int CalculateCompressedSize(List<LZ77Token> compressedData)
        {
            int nextCharBits = 8;
            int bitsPerToken = 0;
            foreach (var token in compressedData)
            {
                int offsetBits = (int)Math.Ceiling(Math.Log(windowSize) / Math.Log(2));
                int lengthBits = (int)Math.Ceiling(Math.Log(lookaheadBufferSize) / Math.Log(2));
                bitsPerToken += offsetBits + lengthBits + nextCharBits;
            }
            return bitsPerToken;
        }
    }
}
