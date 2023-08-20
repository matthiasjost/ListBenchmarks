using System.Collections.Generic;

namespace ListBenchmarks.Tests;

public class FindListItemBenchmarkTest
{
  private FindListItemBenchmark _benchmark = new FindListItemBenchmark();

  public FindListItemBenchmarkTest()
  {
    _benchmark = new FindListItemBenchmark();
    _benchmark.GlobalSetup();
  }

  [Fact]
  public void TestAll()
  {
    Assert.True(_benchmark.EnumerableAny());
    Assert.True(_benchmark.ListExists());
    Assert.Equal(FindListItemBenchmark.MaxNumber - 1, _benchmark.ListBinarySearch());
    Assert.Equal(FindListItemBenchmark.MaxNumber - 1, _benchmark.ListIndexOf());
    Assert.True(_benchmark.ListContains());
  }
}