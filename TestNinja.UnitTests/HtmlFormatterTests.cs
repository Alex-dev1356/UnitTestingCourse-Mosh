using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Sample of Specific Assertion - this assestion is very specific because we're verifying the exact string that we should 
            //get from the method.
            //Assert.That(result, Is.EqualTo("<strong>abc</strong>")); 

            //Sample of Too General Assertion
            Assert.That(result, Does.StartWith("<strong>"));
            //We can make more specific by adding this one:
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

            //Key Takeaway: When Testing strings it's better if YOUR ASSERTIONS ARE A LITTLE BIT MORE GENERAL, BECAUSE IF THEY ARE TOO
            //SPECIFIC, YOUR TESTS CAN BREAK EASILY. However in this particular case it is better to use the First Solution so we make
            //sure that the return value is exactly what we get from the method, otherwise we may end up on a bad HTML Document. But
            //if the method RETURNING SOME KIND OF ERROR MESSAGES IT IS BETTER TO USE THE SECOND SOLUTION.

            //NOTE: When writing assertions against strings, BY DEFAULT THEY ARE CASE SENSITIVE, TO DISABLE THAT WE CAN USE THE IGNORE
            //CASE PROPERTY
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
        }

    }
}
