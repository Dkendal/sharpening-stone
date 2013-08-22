using System;
using NUnit.Framework;
using FluentAssertions;
using CSharpLanguageExtensions;

namespace Specs {
  [TestFixture()]
  public class StringDecoratorSpec {
    [TestCase("foo", Result=false)]
    [TestCase("", Result=true)]
    [TestCase(null, Result=true)]
    public bool is_empty_spec(String subject) {
      return subject.IsEmpty();
    }
  }
}
