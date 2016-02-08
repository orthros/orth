using Orth.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace orth.tests
{
    public class ParseTests
    {
        [Theory, MemberData("YesData")]        
        public void TestTrue(string data)
        {
            Assert.True(Utilities.ParseTrueFalse(data));
        }

        [Theory, MemberData("NoData")]        
        public void TestFalse(string data)
        {
            Assert.False(Utilities.ParseTrueFalse(data));
        }

        [Fact]
        public void TestUnknown()
        {
            Assert.True(true);
        }


        public static IEnumerable<object[]> YesData
        {
            get
            {
                return new[]
                {
                    new object[] {"yes"},
                    new object[] {"Yes"},
                    new object[] {"YEs"},
                    new object[] {"YES"},
                    new object[] {"yES"},
                    new object[] {"yeS"},
                    new object[] {"yEs"},
                    new object[] {"YeS"},
                    new object[] {"y"  },
                    new object[] {"Y"  },
                    new object[] {"true"},
                    new object[] {"True"},
                    new object[] {"TRue"},
                    new object[] {"TRUe"},
                    new object[] {"TRUE"},
                    new object[] {"tRUE"},
                    new object[] {"trUE"},
                    new object[] {"truE"},
                    new object[] {"TruE"},
                    new object[] {"tRUe"},
                    new object[] {"TrUe"},
                    new object[] {"tRuE"},
                    new object[] {"t"  },
                    new object[] {"T"  },
                    new object[] {"on" },
                    new object[] {"On" },
                    new object[] {"ON" },
                    new object[] {"oN" },
                    new object[] { "1" }
                };
            }
        }

        public static IEnumerable<object[]> NoData
        {
            get
            {
                return new[]
                {
                    new object[] {"no" },
                    new object[] {"n" },
                    new object[] {"false" },
                    new object[] {"f" },
                    new object[] {"off" },
                    new object[] {"0" },
                    new object[] {"NO" },
                    new object[] {"N" },
                    new object[] {"FALSE" },
                    new object[] {"F" },
                    new object[] {"OFF" },
                    new object[] {"No" },
                    new object[] {"Off" },
                    new object[] {"False" },
                };
            }
        }

    }
}
