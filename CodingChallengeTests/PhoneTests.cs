using Xunit;
using CodingChallenge;

namespace CodingChallengeTests
{
    public class PhoneTests
    {
        [Fact]
        public void ReturnsHello()
        {
            Assert.Equal("HELLO ", Phone.OldPhonePad("4433555 5556660#"));
        }
        [Fact]
        public void ReturnsSeen()
        {
            Assert.Equal("SEE N", Phone.OldPhonePad("7777777733 33 0 66#"));
        }
        [Fact]
        public void ReturnsB()
        {
            Assert.Equal("B", Phone.OldPhonePad("2*22#"));
        }
        [Fact]
        public void ReturnsGIH()
        {
            Assert.Equal("GIH", Phone.OldPhonePad("**4 444 44#"));
        }
        [Fact]
        public void ReturnsYES()
        {
            Assert.Equal("YES", Phone.OldPhonePad("999337777#"));
        }
        [Fact]
        public void ReturnsTURING()
        {
            Assert.Equal("TURING", Phone.OldPhonePad("8 88777444666*664#"));
        }
        [Fact]
        public void ReturnsG()
        {
            Assert.Equal("G", Phone.OldPhonePad("4444#"));
        }
        [Fact]
        public void ReturnsADGJMPTW()
        {
            Assert.Equal("&ADGJMPTW ", Phone.OldPhonePad("1 2 3 4 5 6 7 8 9 0#"));
        }
        [Fact]
        public void ReturnsCCCA()
        {
            Assert.Equal("CCCA", Phone.OldPhonePad("222222 222 222 2#"));
        }
        [Fact]
        public void ReturnsSSS()
        {
            Assert.Equal("SSS", Phone.OldPhonePad("7777 7777 7777#"));
        }
    }
}