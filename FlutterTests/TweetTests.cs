using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SharpTwit;
using Flutter;
using Flutter.Controllers;

namespace FlutterTests
{
    [TestFixture]
    public class TweetTests
    {
        [Test]
        public void that_saving_a_tweet_over_140_chars_()
        {
            TweetController classUnderTest = new TweetController();
            Tweet tweet = new Tweet() { };
            classUnderTest.Tweet(tweet);
        }
    }
}
