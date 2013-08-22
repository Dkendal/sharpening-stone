using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpLanguageExtensions {
  public static class IEnumerableDecotrator {
    public static IEnumerable<T> Each<T>(this IEnumerable<T> caller, Action<T> block) {
      foreach(T item in caller) {
        block(item);
      }
      return caller;
    }
  }
}
