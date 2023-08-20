using BenchmarkDotNet.Running;
using ListBenchmarks;

var summary = BenchmarkRunner.Run<FindListItemBenchmark>();