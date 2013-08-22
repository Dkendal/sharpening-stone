using System;
using NUnit.Framework;
using FluentAssertions;
using CSharpLanguageExtensions;

namespace Specs {
  [TestFixture]
  public class IntegerDecoratorSpec {
    [Test]
    public void times_spec() {
      int sum = 0;
      3.Times(x => sum += x).Should().Be(3);
      sum.Should().Be(6);
    }

    [Test]
    public static void to_spec() {
      1.To(4).Should().BeEquivalentTo(1, 2, 3);
    }
  }
}

