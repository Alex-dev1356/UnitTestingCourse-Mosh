using NUnit.Framework;
using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;
        [SetUp]
        public void SetUps()
        {
            _stack = new Stack<string>();
        }

        //For Push Method
        [Test]
        public void Push_ObjectIsNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ObjectIsValid_ReturnListCountIsNotZero()
        {
            _stack.Push("a");

            var result = _stack.Count;

            Assert.That(result, Is.EqualTo(1));
        }

        //For Count
        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        //For Pop Method
        [Test]
        public void Pop_ListCountIsZero_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_ListCountIsNotEqualToZero_RemoveTheObjectOnTopOfTheStack()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnsTheObjectAtTheTopOfTheStack()
        {
            _stack.Push("c");
            _stack.Push("b");
            _stack.Push("a");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("a"));
        }

        //For Peek Method
        [Test]
        public void Peek_ListIsEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_ListContainsValidArgs_ReturnsObjectAtTheTopOfTheStack()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_CountsTheNumberOfObject_DoesNotDeleteObjectOnTopOfTheStack()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}
