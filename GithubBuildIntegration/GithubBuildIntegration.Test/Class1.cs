using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GithubBuildIntegration.Test
{
    public class MathStuffTests
    {
        [TestCase(-3, 3, 0)]
        [TestCase(2,3,5)]
        public void CheckThatAddWorks(int x, int y, int expected)
        {
            var sut = new MathStuff();
            var result = sut.Add(x, y);
            Assert.That(result,Is.EqualTo(expected));
        }
    }
}
