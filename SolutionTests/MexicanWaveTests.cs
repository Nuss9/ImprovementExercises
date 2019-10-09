using System;
using Solution;
using Xunit;
using System.Collections.Generic;

namespace SolutionTests
{
    public class MexicanWaveTests
    {
        [Fact]
        public void BasicTest1()
        {
            MexicanWave MexicanWave = new MexicanWave();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.Equal(result, MexicanWave.wave("hello"));
        }

        [Fact]
        public void BasicTest2()
        {
            MexicanWave MexicanWave = new MexicanWave();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.Equal(result, MexicanWave.wave("codewars"));
        }

        [Fact]
        public void BasicTest3()
        {
            MexicanWave MexicanWave = new MexicanWave();
            List<string> result = new List<string> { };
            Assert.Equal(result, MexicanWave.wave(""));
        }

        [Fact]
        public void BasicTest4()
        {
            MexicanWave MexicanWave = new MexicanWave();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.Equal(result, MexicanWave.wave("two words"));
        }

        [Fact]
        public void BasicTest5()
        {
            MexicanWave MexicanWave = new MexicanWave();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.Equal(result, MexicanWave.wave(" gap "));
        }

    }
}