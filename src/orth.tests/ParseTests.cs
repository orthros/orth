using Orth.Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

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

        [Theory]
        [InlineData("true")]
        [InlineData("false")]
        public void TestUnknownRandomStringsRetval(bool expectedRetval)
        {            
            for(int i =0; i < 1000; i++)
            {
                var randomString = Utilities.RandomString(10);
                var retval = Utilities.ParseTrueFalse(randomString, expectedRetval);
                Assert.True(retval == expectedRetval);
            }            
        }


        public static IEnumerable<object[]> YesData
        {
            get
            {
                using (var yesD = new StreamReader(File.OpenRead(Path.Combine(Environment.CurrentDirectory, "Data", "YesData.txt"))))
                {
                    while (!yesD.EndOfStream)
                    {
                        yield return new object[] { yesD.ReadLine() };
                    }
                }                
            }
        }

        public static IEnumerable<object[]> NoData
        {
            get
            {
                using (var noD = new StreamReader(File.OpenRead(Path.Combine(Environment.CurrentDirectory, "Data", "NoData.txt"))))
                {
                    while (!noD.EndOfStream)
                    {
                        yield return new object[] { noD.ReadLine() };
                    }
                }
            }
        }

    }
}
