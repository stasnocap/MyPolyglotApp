using MyPolyglotCore.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyPolyglotCoreTests.Helpers.ShufflerHelperTests
{
    public class ShuffleShould
    {
        [Fact]
        public void MixElementsInRandomPosition()
        {
            var collection = new List<string>()
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
            };

            var shuffled = collection.Shuffle().ToList();

            var atLeastOneElementNotInTheSamePosition = false;
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] != shuffled[i])
                {
                    atLeastOneElementNotInTheSamePosition = true;
                }
            }

            Assert.True(atLeastOneElementNotInTheSamePosition);
        }
    }
}
