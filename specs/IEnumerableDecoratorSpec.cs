using System;
using System.Linq;
using NUnit.Framework;
using FluentAssertions;
using CSharpLanguageExtensions;

namespace Specs {
  [TestFixture]
  public class IEnumerableDecoratorSpecs {
    class Mock {
      public object foo;
      public Mock(object foo) {
        this.foo = foo;
      }
    }

    [Test]
    public void each_spec() {
      var subject = new Mock[] {
        new Mock("test")
      };
      subject.Each(x => x.foo = "changed");
      subject.First().foo.Should().Be("changed");
    }
  }
}
