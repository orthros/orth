using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using orth.core.Utils;
using orth.tests.Stubs;
using Xunit;

namespace orth.tests
{
    public class EnumTests
    {
        [Fact]
        void TestTriState()
        {
            var expected = new HashSet<TriStateEnum>() { TriStateEnum.Item1, TriStateEnum.Item2, TriStateEnum.Item3 };
            var vals = EnumUtils.GetValues<TriStateEnum>();
            Assert.Equal(vals.Count(), expected.Count);
            
            var valsSet = new HashSet<TriStateEnum>(vals);
            Assert.Subset(expected, valsSet);
            Assert.Subset(valsSet, expected);
        }
    }
}
