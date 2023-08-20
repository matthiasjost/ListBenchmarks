using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBenchmarks;


[SimpleJob(RuntimeMoniker.Net70)]
public class FindListItemBenchmark
{
  private List<int> _list = new List<int>();
  public const int MaxNumber = 99_9999;

  [GlobalSetup]
  public void GlobalSetup()
  {
    _list = Enumerable.Range(1, MaxNumber).ToList();
  }

  [Benchmark(Baseline = true)]
  public bool EnumerableAny()
  {
    return _list.Any(x => x == MaxNumber);
  }

  [Benchmark]
  public bool ListExists()
  {
    return _list.Exists(x => x == MaxNumber);
  }

  [Benchmark]
  public int ListIndexOf()
  {
    var item = _list.IndexOf(MaxNumber);
    return item;
  }

  [Benchmark]
  public int ListBinarySearch()
  {
    return _list.BinarySearch(MaxNumber);
  }

  [Benchmark]
  public bool ListContains()
  {
    return _list.Contains(MaxNumber);
  }
}