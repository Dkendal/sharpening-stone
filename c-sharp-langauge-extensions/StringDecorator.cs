using System;
namespace CSharpLanguageExtensions {
  public static class StringDecorator {
    public static bool IsEmpty(this String caller) {
      return String.IsNullOrEmpty(caller);
    }
  }
}
