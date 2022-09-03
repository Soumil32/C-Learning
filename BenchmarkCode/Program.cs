﻿using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MoreTypeExtensions;

namespace BenchmarkCode
{
    [MemoryDiagnoser()]
    [RankColumn]
    public class CodeToBenchmark
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<CodeToBenchmark>();
        }

        [Benchmark]
        public string ReverseStringWithNewString()
        {
            string stringToReverse = "I am going to wake up tonight not tomorrow";
            char[] stringToReverseCharArray = stringToReverse.ToCharArray();
            Array.Reverse(stringToReverseCharArray);
            return new string(stringToReverseCharArray);
        }
        
        [Benchmark]
        public string ReverseStringWithStringFormat()
        {
            string stringToReverse = "I am going to wake up tonight not tomorrow";
            char[] stringToReverseCharArray = stringToReverse.ToCharArray();
            Array.Reverse(stringToReverseCharArray);
            return string.Format($"{stringToReverseCharArray}");
        }
        
        [Benchmark]
        public string ReverseStringWithStringCreate()
        {
            string stringToReverse = "I am going to wake up tonight not tomorrow";
            char[] stringToReverseCharArray = stringToReverse.ToCharArray();
            Array.Reverse(stringToReverseCharArray);
            return string.Create();
        }
    }
}