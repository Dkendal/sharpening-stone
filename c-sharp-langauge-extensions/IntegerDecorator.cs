using System;
using System.Collections.Generic;

namespace CSharpLanguageExtensions {
  public static class IntegerDecorator {
    public static int Times(this int caller, Action<int> block) {
      for(int i = 0; i <= caller; i++) {
        block(i);
      }
      return caller;
    }

    public static IEnumerable<int> To(this int caller, int end) {
      for(; caller < end; caller++) {
        yield return caller;
      }
    }
  }
}
