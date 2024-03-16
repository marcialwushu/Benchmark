# Benchmark 

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22000.2295/21H2/SunValley)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.200
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2


```
| Method     | Mean       | Error     | StdDev     | Median     |
|----------- |-----------:|----------:|-----------:|-----------:|
| PBKDF2     |   2.370 ms | 0.0456 ms |  0.0507 ms |   2.365 ms |
| BCryptHash | 169.585 ms | 3.2822 ms |  3.2235 ms | 169.673 ms |
| Argon2Hash | 240.639 ms | 7.0957 ms | 20.8106 ms | 246.382 ms |


```
// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 3 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// start dotnet  restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true in C:\Users\marci\source\repos\service\Benchmark\Benchmark\bin\Release\net6.0\2842ed10-6d66-42ba-a564-6161057e15a1
// command took 1.38 sec and exited with 0
// start dotnet  build -c Release --no-restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true in C:\Users\marci\source\repos\service\Benchmark\Benchmark\bin\Release\net6.0\2842ed10-6d66-42ba-a564-6161057e15a1
// command took 2.85 sec and exited with 0
// ***** Done, took 00:00:04 (4.34 sec)   *****
// Found 3 benchmarks:
//   HashingBenchmark.PBKDF2: DefaultJob
//   HashingBenchmark.BCryptHash: DefaultJob
//   HashingBenchmark.Argon2Hash: DefaultJob

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Alto desempenho)
// **************************
// Benchmark: HashingBenchmark.PBKDF2: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 2842ed10-6d66-42ba-a564-6161057e15a1.dll --anonymousPipes 1256 1272 --benchmarkName HashingBenchmark.PBKDF2 --job Default --benchmarkId 0 in C:\Users\marci\source\repos\service\Benchmark\Benchmark\bin\Release\net6.0\2842ed10-6d66-42ba-a564-6161057e15a1\bin\Release\net6.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 328800.00 ns, 328.8000 us/op
WorkloadJitting  1: 1 op, 9286000.00 ns, 9.2860 ms/op

OverheadJitting  2: 16 op, 692000.00 ns, 43.2500 us/op
WorkloadJitting  2: 16 op, 46523100.00 ns, 2.9077 ms/op

WorkloadPilot    1: 16 op, 45638100.00 ns, 2.8524 ms/op
WorkloadPilot    2: 32 op, 91933000.00 ns, 2.8729 ms/op
WorkloadPilot    3: 64 op, 162037600.00 ns, 2.5318 ms/op
WorkloadPilot    4: 128 op, 308323100.00 ns, 2.4088 ms/op
WorkloadPilot    5: 256 op, 596572600.00 ns, 2.3304 ms/op

OverheadWarmup   1: 256 op, 2000.00 ns, 7.8125 ns/op
OverheadWarmup   2: 256 op, 1300.00 ns, 5.0781 ns/op
OverheadWarmup   3: 256 op, 1400.00 ns, 5.4688 ns/op
OverheadWarmup   4: 256 op, 1300.00 ns, 5.0781 ns/op
OverheadWarmup   5: 256 op, 1400.00 ns, 5.4688 ns/op
OverheadWarmup   6: 256 op, 1300.00 ns, 5.0781 ns/op

OverheadActual   1: 256 op, 1400.00 ns, 5.4688 ns/op
OverheadActual   2: 256 op, 1400.00 ns, 5.4688 ns/op
OverheadActual   3: 256 op, 1700.00 ns, 6.6406 ns/op
OverheadActual   4: 256 op, 1600.00 ns, 6.2500 ns/op
OverheadActual   5: 256 op, 1600.00 ns, 6.2500 ns/op
OverheadActual   6: 256 op, 1300.00 ns, 5.0781 ns/op
OverheadActual   7: 256 op, 2100.00 ns, 8.2031 ns/op
OverheadActual   8: 256 op, 2400.00 ns, 9.3750 ns/op
OverheadActual   9: 256 op, 3000.00 ns, 11.7188 ns/op
OverheadActual  10: 256 op, 2400.00 ns, 9.3750 ns/op
OverheadActual  11: 256 op, 1300.00 ns, 5.0781 ns/op
OverheadActual  12: 256 op, 10100.00 ns, 39.4531 ns/op
OverheadActual  13: 256 op, 1300.00 ns, 5.0781 ns/op
OverheadActual  14: 256 op, 1400.00 ns, 5.4688 ns/op
OverheadActual  15: 256 op, 1200.00 ns, 4.6875 ns/op
OverheadActual  16: 256 op, 1200.00 ns, 4.6875 ns/op
OverheadActual  17: 256 op, 1800.00 ns, 7.0312 ns/op
OverheadActual  18: 256 op, 1700.00 ns, 6.6406 ns/op
OverheadActual  19: 256 op, 1300.00 ns, 5.0781 ns/op
OverheadActual  20: 256 op, 1300.00 ns, 5.0781 ns/op

WorkloadWarmup   1: 256 op, 606145300.00 ns, 2.3678 ms/op
WorkloadWarmup   2: 256 op, 596691500.00 ns, 2.3308 ms/op
WorkloadWarmup   3: 256 op, 621093600.00 ns, 2.4261 ms/op
WorkloadWarmup   4: 256 op, 601495100.00 ns, 2.3496 ms/op
WorkloadWarmup   5: 256 op, 616559100.00 ns, 2.4084 ms/op
WorkloadWarmup   6: 256 op, 631361800.00 ns, 2.4663 ms/op
WorkloadWarmup   7: 256 op, 593112300.00 ns, 2.3168 ms/op

// BeforeActualRun
WorkloadActual   1: 256 op, 611985300.00 ns, 2.3906 ms/op
WorkloadActual   2: 256 op, 602563100.00 ns, 2.3538 ms/op
WorkloadActual   3: 256 op, 631163700.00 ns, 2.4655 ms/op
WorkloadActual   4: 256 op, 614677800.00 ns, 2.4011 ms/op
WorkloadActual   5: 256 op, 631280900.00 ns, 2.4659 ms/op
WorkloadActual   6: 256 op, 612818500.00 ns, 2.3938 ms/op
WorkloadActual   7: 256 op, 597574200.00 ns, 2.3343 ms/op
WorkloadActual   8: 256 op, 611629600.00 ns, 2.3892 ms/op
WorkloadActual   9: 256 op, 614945400.00 ns, 2.4021 ms/op
WorkloadActual  10: 256 op, 605485500.00 ns, 2.3652 ms/op
WorkloadActual  11: 256 op, 597096400.00 ns, 2.3324 ms/op
WorkloadActual  12: 256 op, 599131800.00 ns, 2.3404 ms/op
WorkloadActual  13: 256 op, 598329700.00 ns, 2.3372 ms/op
WorkloadActual  14: 256 op, 594531700.00 ns, 2.3224 ms/op
WorkloadActual  15: 256 op, 608664100.00 ns, 2.3776 ms/op
WorkloadActual  16: 256 op, 584756100.00 ns, 2.2842 ms/op
WorkloadActual  17: 256 op, 590629600.00 ns, 2.3071 ms/op
WorkloadActual  18: 256 op, 623976700.00 ns, 2.4374 ms/op
WorkloadActual  19: 256 op, 596652300.00 ns, 2.3307 ms/op

// AfterActualRun
WorkloadResult   1: 256 op, 611983800.00 ns, 2.3906 ms/op
WorkloadResult   2: 256 op, 602561600.00 ns, 2.3538 ms/op
WorkloadResult   3: 256 op, 631162200.00 ns, 2.4655 ms/op
WorkloadResult   4: 256 op, 614676300.00 ns, 2.4011 ms/op
WorkloadResult   5: 256 op, 631279400.00 ns, 2.4659 ms/op
WorkloadResult   6: 256 op, 612817000.00 ns, 2.3938 ms/op
WorkloadResult   7: 256 op, 597572700.00 ns, 2.3343 ms/op
WorkloadResult   8: 256 op, 611628100.00 ns, 2.3892 ms/op
WorkloadResult   9: 256 op, 614943900.00 ns, 2.4021 ms/op
WorkloadResult  10: 256 op, 605484000.00 ns, 2.3652 ms/op
WorkloadResult  11: 256 op, 597094900.00 ns, 2.3324 ms/op
WorkloadResult  12: 256 op, 599130300.00 ns, 2.3404 ms/op
WorkloadResult  13: 256 op, 598328200.00 ns, 2.3372 ms/op
WorkloadResult  14: 256 op, 594530200.00 ns, 2.3224 ms/op
WorkloadResult  15: 256 op, 608662600.00 ns, 2.3776 ms/op
WorkloadResult  16: 256 op, 584754600.00 ns, 2.2842 ms/op
WorkloadResult  17: 256 op, 590628100.00 ns, 2.3071 ms/op
WorkloadResult  18: 256 op, 623975200.00 ns, 2.4374 ms/op
WorkloadResult  19: 256 op, 596650800.00 ns, 2.3307 ms/op

// AfterAll
// Benchmark Process 71764 has exited with code 0.

Mean = 2.370 ms, StdErr = 0.012 ms (0.49%), N = 19, StdDev = 0.051 ms
Min = 2.284 ms, Q1 = 2.333 ms, Median = 2.365 ms, Q3 = 2.397 ms, Max = 2.466 ms
IQR = 0.064 ms, LowerFence = 2.237 ms, UpperFence = 2.494 ms
ConfidenceInterval = [2.324 ms; 2.416 ms] (CI 99.9%), Margin = 0.046 ms (1.93% of Mean)
Skewness = 0.38, Kurtosis = 2.18, MValue = 2

// ** Remained 2 (66,7%) benchmark(s) to run. Estimated finish 2024-03-16 18:38 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Alto desempenho)
// **************************
// Benchmark: HashingBenchmark.BCryptHash: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 2842ed10-6d66-42ba-a564-6161057e15a1.dll --anonymousPipes 1516 1512 --benchmarkName HashingBenchmark.BCryptHash --job Default --benchmarkId 1 in C:\Users\marci\source\repos\service\Benchmark\Benchmark\bin\Release\net6.0\2842ed10-6d66-42ba-a564-6161057e15a1\bin\Release\net6.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 293100.00 ns, 293.1000 us/op
WorkloadJitting  1: 1 op, 199080900.00 ns, 199.0809 ms/op

WorkloadPilot    1: 2 op, 332682000.00 ns, 166.3410 ms/op
WorkloadPilot    2: 3 op, 514089000.00 ns, 171.3630 ms/op

WorkloadWarmup   1: 3 op, 518897300.00 ns, 172.9658 ms/op
WorkloadWarmup   2: 3 op, 511085000.00 ns, 170.3617 ms/op
WorkloadWarmup   3: 3 op, 496321300.00 ns, 165.4404 ms/op
WorkloadWarmup   4: 3 op, 509510800.00 ns, 169.8369 ms/op
WorkloadWarmup   5: 3 op, 507699400.00 ns, 169.2331 ms/op
WorkloadWarmup   6: 3 op, 489407800.00 ns, 163.1359 ms/op
WorkloadWarmup   7: 3 op, 518162100.00 ns, 172.7207 ms/op
WorkloadWarmup   8: 3 op, 510547000.00 ns, 170.1823 ms/op

// BeforeActualRun
WorkloadActual   1: 3 op, 505395800.00 ns, 168.4653 ms/op
WorkloadActual   2: 3 op, 516208400.00 ns, 172.0695 ms/op
WorkloadActual   3: 3 op, 504455200.00 ns, 168.1517 ms/op
WorkloadActual   4: 3 op, 505859800.00 ns, 168.6199 ms/op
WorkloadActual   5: 3 op, 523632300.00 ns, 174.5441 ms/op
WorkloadActual   6: 3 op, 490933600.00 ns, 163.6445 ms/op
WorkloadActual   7: 3 op, 518781400.00 ns, 172.9271 ms/op
WorkloadActual   8: 3 op, 519071200.00 ns, 173.0237 ms/op
WorkloadActual   9: 3 op, 516107700.00 ns, 172.0359 ms/op
WorkloadActual  10: 3 op, 506790900.00 ns, 168.9303 ms/op
WorkloadActual  11: 3 op, 517775400.00 ns, 172.5918 ms/op
WorkloadActual  12: 3 op, 495429400.00 ns, 165.1431 ms/op
WorkloadActual  13: 3 op, 511388100.00 ns, 170.4627 ms/op
WorkloadActual  14: 3 op, 495105100.00 ns, 165.0350 ms/op
WorkloadActual  15: 3 op, 511246800.00 ns, 170.4156 ms/op
WorkloadActual  16: 3 op, 501907800.00 ns, 167.3026 ms/op

// AfterActualRun
WorkloadResult   1: 3 op, 505395800.00 ns, 168.4653 ms/op
WorkloadResult   2: 3 op, 516208400.00 ns, 172.0695 ms/op
WorkloadResult   3: 3 op, 504455200.00 ns, 168.1517 ms/op
WorkloadResult   4: 3 op, 505859800.00 ns, 168.6199 ms/op
WorkloadResult   5: 3 op, 523632300.00 ns, 174.5441 ms/op
WorkloadResult   6: 3 op, 490933600.00 ns, 163.6445 ms/op
WorkloadResult   7: 3 op, 518781400.00 ns, 172.9271 ms/op
WorkloadResult   8: 3 op, 519071200.00 ns, 173.0237 ms/op
WorkloadResult   9: 3 op, 516107700.00 ns, 172.0359 ms/op
WorkloadResult  10: 3 op, 506790900.00 ns, 168.9303 ms/op
WorkloadResult  11: 3 op, 517775400.00 ns, 172.5918 ms/op
WorkloadResult  12: 3 op, 495429400.00 ns, 165.1431 ms/op
WorkloadResult  13: 3 op, 511388100.00 ns, 170.4627 ms/op
WorkloadResult  14: 3 op, 495105100.00 ns, 165.0350 ms/op
WorkloadResult  15: 3 op, 511246800.00 ns, 170.4156 ms/op
WorkloadResult  16: 3 op, 501907800.00 ns, 167.3026 ms/op

// AfterAll
// Benchmark Process 62864 has exited with code 0.

Mean = 169.585 ms, StdErr = 0.806 ms (0.48%), N = 16, StdDev = 3.224 ms
Min = 163.645 ms, Q1 = 167.939 ms, Median = 169.673 ms, Q3 = 172.200 ms, Max = 174.544 ms
IQR = 4.261 ms, LowerFence = 161.549 ms, UpperFence = 178.591 ms
ConfidenceInterval = [166.303 ms; 172.867 ms] (CI 99.9%), Margin = 3.282 ms (1.94% of Mean)
Skewness = -0.28, Kurtosis = 1.81, MValue = 2

// ** Remained 1 (33,3%) benchmark(s) to run. Estimated finish 2024-03-16 18:38 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Alto desempenho)
// **************************
// Benchmark: HashingBenchmark.Argon2Hash: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 2842ed10-6d66-42ba-a564-6161057e15a1.dll --anonymousPipes 1528 1520 --benchmarkName HashingBenchmark.Argon2Hash --job Default --benchmarkId 2 in C:\Users\marci\source\repos\service\Benchmark\Benchmark\bin\Release\net6.0\2842ed10-6d66-42ba-a564-6161057e15a1\bin\Release\net6.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 415800.00 ns, 415.8000 us/op
WorkloadJitting  1: 1 op, 393434100.00 ns, 393.4341 ms/op

OverheadJitting  2: 1 op, 400.00 ns, 400.0000 ns/op
WorkloadJitting  2: 1 op, 197489400.00 ns, 197.4894 ms/op

WorkloadPilot    1: 2 op, 460886300.00 ns, 230.4432 ms/op
WorkloadPilot    2: 3 op, 720020900.00 ns, 240.0070 ms/op

WorkloadWarmup   1: 3 op, 637122300.00 ns, 212.3741 ms/op
WorkloadWarmup   2: 3 op, 658222100.00 ns, 219.4074 ms/op
WorkloadWarmup   3: 3 op, 588864900.00 ns, 196.2883 ms/op
WorkloadWarmup   4: 3 op, 590963800.00 ns, 196.9879 ms/op
WorkloadWarmup   5: 3 op, 586490000.00 ns, 195.4967 ms/op
WorkloadWarmup   6: 3 op, 630348700.00 ns, 210.1162 ms/op

// BeforeActualRun
WorkloadActual   1: 3 op, 608205600.00 ns, 202.7352 ms/op
WorkloadActual   2: 3 op, 596471000.00 ns, 198.8237 ms/op
WorkloadActual   3: 3 op, 603039500.00 ns, 201.0132 ms/op
WorkloadActual   4: 3 op, 611182100.00 ns, 203.7274 ms/op
WorkloadActual   5: 3 op, 684734200.00 ns, 228.2447 ms/op
WorkloadActual   6: 3 op, 595687500.00 ns, 198.5625 ms/op
WorkloadActual   7: 3 op, 640490400.00 ns, 213.4968 ms/op
WorkloadActual   8: 3 op, 627362500.00 ns, 209.1208 ms/op
WorkloadActual   9: 3 op, 607241900.00 ns, 202.4140 ms/op
WorkloadActual  10: 3 op, 636628700.00 ns, 212.2096 ms/op
WorkloadActual  11: 3 op, 658337600.00 ns, 219.4459 ms/op
WorkloadActual  12: 3 op, 602911600.00 ns, 200.9705 ms/op
WorkloadActual  13: 3 op, 618206500.00 ns, 206.0688 ms/op
WorkloadActual  14: 3 op, 633229300.00 ns, 211.0764 ms/op
WorkloadActual  15: 3 op, 654542200.00 ns, 218.1807 ms/op
WorkloadActual  16: 3 op, 612577300.00 ns, 204.1924 ms/op
WorkloadActual  17: 3 op, 611718100.00 ns, 203.9060 ms/op
WorkloadActual  18: 3 op, 685160300.00 ns, 228.3868 ms/op
WorkloadActual  19: 3 op, 607893100.00 ns, 202.6310 ms/op
WorkloadActual  20: 3 op, 586399100.00 ns, 195.4664 ms/op
WorkloadActual  21: 3 op, 644555400.00 ns, 214.8518 ms/op
WorkloadActual  22: 3 op, 597700500.00 ns, 199.2335 ms/op
WorkloadActual  23: 3 op, 635297700.00 ns, 211.7659 ms/op
WorkloadActual  24: 3 op, 673715200.00 ns, 224.5717 ms/op
WorkloadActual  25: 3 op, 719678100.00 ns, 239.8927 ms/op
WorkloadActual  26: 3 op, 742815900.00 ns, 247.6053 ms/op
WorkloadActual  27: 3 op, 819285900.00 ns, 273.0953 ms/op
WorkloadActual  28: 3 op, 769221700.00 ns, 256.4072 ms/op
WorkloadActual  29: 3 op, 774887000.00 ns, 258.2957 ms/op
WorkloadActual  30: 3 op, 806144000.00 ns, 268.7147 ms/op
WorkloadActual  31: 3 op, 827951500.00 ns, 275.9838 ms/op
WorkloadActual  32: 3 op, 743708900.00 ns, 247.9030 ms/op
WorkloadActual  33: 3 op, 754282200.00 ns, 251.4274 ms/op
WorkloadActual  34: 3 op, 766792100.00 ns, 255.5974 ms/op
WorkloadActual  35: 3 op, 738452600.00 ns, 246.1509 ms/op
WorkloadActual  36: 3 op, 846980700.00 ns, 282.3269 ms/op
WorkloadActual  37: 3 op, 743558700.00 ns, 247.8529 ms/op
WorkloadActual  38: 3 op, 740534800.00 ns, 246.8449 ms/op
WorkloadActual  39: 3 op, 736102300.00 ns, 245.3674 ms/op
WorkloadActual  40: 3 op, 721247800.00 ns, 240.4159 ms/op
WorkloadActual  41: 3 op, 730907800.00 ns, 243.6359 ms/op
WorkloadActual  42: 3 op, 755464100.00 ns, 251.8214 ms/op
WorkloadActual  43: 3 op, 746213300.00 ns, 248.7378 ms/op
WorkloadActual  44: 3 op, 719715000.00 ns, 239.9050 ms/op
WorkloadActual  45: 3 op, 760857000.00 ns, 253.6190 ms/op
WorkloadActual  46: 3 op, 808720500.00 ns, 269.5735 ms/op
WorkloadActual  47: 3 op, 745272800.00 ns, 248.4243 ms/op
WorkloadActual  48: 3 op, 767977900.00 ns, 255.9926 ms/op
WorkloadActual  49: 3 op, 703029100.00 ns, 234.3430 ms/op
WorkloadActual  50: 3 op, 737390100.00 ns, 245.7967 ms/op
WorkloadActual  51: 3 op, 738214200.00 ns, 246.0714 ms/op
WorkloadActual  52: 3 op, 742022100.00 ns, 247.3407 ms/op
WorkloadActual  53: 3 op, 732045700.00 ns, 244.0152 ms/op
WorkloadActual  54: 3 op, 712196200.00 ns, 237.3987 ms/op
WorkloadActual  55: 3 op, 736666800.00 ns, 245.5556 ms/op
WorkloadActual  56: 3 op, 753390700.00 ns, 251.1302 ms/op
WorkloadActual  57: 3 op, 787599500.00 ns, 262.5332 ms/op
WorkloadActual  58: 3 op, 776929600.00 ns, 258.9765 ms/op
WorkloadActual  59: 3 op, 756880000.00 ns, 252.2933 ms/op
WorkloadActual  60: 3 op, 835804800.00 ns, 278.6016 ms/op
WorkloadActual  61: 3 op, 748419300.00 ns, 249.4731 ms/op
WorkloadActual  62: 3 op, 744747500.00 ns, 248.2492 ms/op
WorkloadActual  63: 3 op, 822729400.00 ns, 274.2431 ms/op
WorkloadActual  64: 3 op, 794569500.00 ns, 264.8565 ms/op
WorkloadActual  65: 3 op, 834451400.00 ns, 278.1505 ms/op
WorkloadActual  66: 3 op, 799203000.00 ns, 266.4010 ms/op
WorkloadActual  67: 3 op, 739145700.00 ns, 246.3819 ms/op
WorkloadActual  68: 3 op, 762527400.00 ns, 254.1758 ms/op
WorkloadActual  69: 3 op, 758152500.00 ns, 252.7175 ms/op
WorkloadActual  70: 3 op, 750598800.00 ns, 250.1996 ms/op
WorkloadActual  71: 3 op, 752047100.00 ns, 250.6824 ms/op
WorkloadActual  72: 3 op, 752941800.00 ns, 250.9806 ms/op
WorkloadActual  73: 3 op, 738411200.00 ns, 246.1371 ms/op
WorkloadActual  74: 3 op, 754768700.00 ns, 251.5896 ms/op
WorkloadActual  75: 3 op, 794324800.00 ns, 264.7749 ms/op
WorkloadActual  76: 3 op, 721206600.00 ns, 240.4022 ms/op
WorkloadActual  77: 3 op, 756846600.00 ns, 252.2822 ms/op
WorkloadActual  78: 3 op, 762855900.00 ns, 254.2853 ms/op
WorkloadActual  79: 3 op, 760783200.00 ns, 253.5944 ms/op
WorkloadActual  80: 3 op, 732776100.00 ns, 244.2587 ms/op
WorkloadActual  81: 3 op, 703254600.00 ns, 234.4182 ms/op
WorkloadActual  82: 3 op, 741918100.00 ns, 247.3060 ms/op
WorkloadActual  83: 3 op, 756426100.00 ns, 252.1420 ms/op
WorkloadActual  84: 3 op, 728751300.00 ns, 242.9171 ms/op
WorkloadActual  85: 3 op, 705731700.00 ns, 235.2439 ms/op
WorkloadActual  86: 3 op, 734056800.00 ns, 244.6856 ms/op
WorkloadActual  87: 3 op, 739406200.00 ns, 246.4687 ms/op
WorkloadActual  88: 3 op, 743256400.00 ns, 247.7521 ms/op
WorkloadActual  89: 3 op, 714829400.00 ns, 238.2765 ms/op
WorkloadActual  90: 3 op, 757953200.00 ns, 252.6511 ms/op
WorkloadActual  91: 3 op, 742721100.00 ns, 247.5737 ms/op
WorkloadActual  92: 3 op, 732679900.00 ns, 244.2266 ms/op
WorkloadActual  93: 3 op, 697060600.00 ns, 232.3535 ms/op
WorkloadActual  94: 3 op, 811382200.00 ns, 270.4607 ms/op
WorkloadActual  95: 3 op, 741882600.00 ns, 247.2942 ms/op
WorkloadActual  96: 3 op, 748912900.00 ns, 249.6376 ms/op
WorkloadActual  97: 3 op, 697916500.00 ns, 232.6388 ms/op
WorkloadActual  98: 3 op, 729043200.00 ns, 243.0144 ms/op
WorkloadActual  99: 3 op, 735578100.00 ns, 245.1927 ms/op
WorkloadActual  100: 3 op, 740278400.00 ns, 246.7595 ms/op

// AfterActualRun
WorkloadResult   1: 3 op, 608205600.00 ns, 202.7352 ms/op
WorkloadResult   2: 3 op, 596471000.00 ns, 198.8237 ms/op
WorkloadResult   3: 3 op, 603039500.00 ns, 201.0132 ms/op
WorkloadResult   4: 3 op, 611182100.00 ns, 203.7274 ms/op
WorkloadResult   5: 3 op, 684734200.00 ns, 228.2447 ms/op
WorkloadResult   6: 3 op, 595687500.00 ns, 198.5625 ms/op
WorkloadResult   7: 3 op, 640490400.00 ns, 213.4968 ms/op
WorkloadResult   8: 3 op, 627362500.00 ns, 209.1208 ms/op
WorkloadResult   9: 3 op, 607241900.00 ns, 202.4140 ms/op
WorkloadResult  10: 3 op, 636628700.00 ns, 212.2096 ms/op
WorkloadResult  11: 3 op, 658337600.00 ns, 219.4459 ms/op
WorkloadResult  12: 3 op, 602911600.00 ns, 200.9705 ms/op
WorkloadResult  13: 3 op, 618206500.00 ns, 206.0688 ms/op
WorkloadResult  14: 3 op, 633229300.00 ns, 211.0764 ms/op
WorkloadResult  15: 3 op, 654542200.00 ns, 218.1807 ms/op
WorkloadResult  16: 3 op, 612577300.00 ns, 204.1924 ms/op
WorkloadResult  17: 3 op, 611718100.00 ns, 203.9060 ms/op
WorkloadResult  18: 3 op, 685160300.00 ns, 228.3868 ms/op
WorkloadResult  19: 3 op, 607893100.00 ns, 202.6310 ms/op
WorkloadResult  20: 3 op, 586399100.00 ns, 195.4664 ms/op
WorkloadResult  21: 3 op, 644555400.00 ns, 214.8518 ms/op
WorkloadResult  22: 3 op, 597700500.00 ns, 199.2335 ms/op
WorkloadResult  23: 3 op, 635297700.00 ns, 211.7659 ms/op
WorkloadResult  24: 3 op, 673715200.00 ns, 224.5717 ms/op
WorkloadResult  25: 3 op, 719678100.00 ns, 239.8927 ms/op
WorkloadResult  26: 3 op, 742815900.00 ns, 247.6053 ms/op
WorkloadResult  27: 3 op, 819285900.00 ns, 273.0953 ms/op
WorkloadResult  28: 3 op, 769221700.00 ns, 256.4072 ms/op
WorkloadResult  29: 3 op, 774887000.00 ns, 258.2957 ms/op
WorkloadResult  30: 3 op, 806144000.00 ns, 268.7147 ms/op
WorkloadResult  31: 3 op, 827951500.00 ns, 275.9838 ms/op
WorkloadResult  32: 3 op, 743708900.00 ns, 247.9030 ms/op
WorkloadResult  33: 3 op, 754282200.00 ns, 251.4274 ms/op
WorkloadResult  34: 3 op, 766792100.00 ns, 255.5974 ms/op
WorkloadResult  35: 3 op, 738452600.00 ns, 246.1509 ms/op
WorkloadResult  36: 3 op, 743558700.00 ns, 247.8529 ms/op
WorkloadResult  37: 3 op, 740534800.00 ns, 246.8449 ms/op
WorkloadResult  38: 3 op, 736102300.00 ns, 245.3674 ms/op
WorkloadResult  39: 3 op, 721247800.00 ns, 240.4159 ms/op
WorkloadResult  40: 3 op, 730907800.00 ns, 243.6359 ms/op
WorkloadResult  41: 3 op, 755464100.00 ns, 251.8214 ms/op
WorkloadResult  42: 3 op, 746213300.00 ns, 248.7378 ms/op
WorkloadResult  43: 3 op, 719715000.00 ns, 239.9050 ms/op
WorkloadResult  44: 3 op, 760857000.00 ns, 253.6190 ms/op
WorkloadResult  45: 3 op, 808720500.00 ns, 269.5735 ms/op
WorkloadResult  46: 3 op, 745272800.00 ns, 248.4243 ms/op
WorkloadResult  47: 3 op, 767977900.00 ns, 255.9926 ms/op
WorkloadResult  48: 3 op, 703029100.00 ns, 234.3430 ms/op
WorkloadResult  49: 3 op, 737390100.00 ns, 245.7967 ms/op
WorkloadResult  50: 3 op, 738214200.00 ns, 246.0714 ms/op
WorkloadResult  51: 3 op, 742022100.00 ns, 247.3407 ms/op
WorkloadResult  52: 3 op, 732045700.00 ns, 244.0152 ms/op
WorkloadResult  53: 3 op, 712196200.00 ns, 237.3987 ms/op
WorkloadResult  54: 3 op, 736666800.00 ns, 245.5556 ms/op
WorkloadResult  55: 3 op, 753390700.00 ns, 251.1302 ms/op
WorkloadResult  56: 3 op, 787599500.00 ns, 262.5332 ms/op
WorkloadResult  57: 3 op, 776929600.00 ns, 258.9765 ms/op
WorkloadResult  58: 3 op, 756880000.00 ns, 252.2933 ms/op
WorkloadResult  59: 3 op, 835804800.00 ns, 278.6016 ms/op
WorkloadResult  60: 3 op, 748419300.00 ns, 249.4731 ms/op
WorkloadResult  61: 3 op, 744747500.00 ns, 248.2492 ms/op
WorkloadResult  62: 3 op, 822729400.00 ns, 274.2431 ms/op
WorkloadResult  63: 3 op, 794569500.00 ns, 264.8565 ms/op
WorkloadResult  64: 3 op, 834451400.00 ns, 278.1505 ms/op
WorkloadResult  65: 3 op, 799203000.00 ns, 266.4010 ms/op
WorkloadResult  66: 3 op, 739145700.00 ns, 246.3819 ms/op
WorkloadResult  67: 3 op, 762527400.00 ns, 254.1758 ms/op
WorkloadResult  68: 3 op, 758152500.00 ns, 252.7175 ms/op
WorkloadResult  69: 3 op, 750598800.00 ns, 250.1996 ms/op
WorkloadResult  70: 3 op, 752047100.00 ns, 250.6824 ms/op
WorkloadResult  71: 3 op, 752941800.00 ns, 250.9806 ms/op
WorkloadResult  72: 3 op, 738411200.00 ns, 246.1371 ms/op
WorkloadResult  73: 3 op, 754768700.00 ns, 251.5896 ms/op
WorkloadResult  74: 3 op, 794324800.00 ns, 264.7749 ms/op
WorkloadResult  75: 3 op, 721206600.00 ns, 240.4022 ms/op
WorkloadResult  76: 3 op, 756846600.00 ns, 252.2822 ms/op
WorkloadResult  77: 3 op, 762855900.00 ns, 254.2853 ms/op
WorkloadResult  78: 3 op, 760783200.00 ns, 253.5944 ms/op
WorkloadResult  79: 3 op, 732776100.00 ns, 244.2587 ms/op
WorkloadResult  80: 3 op, 703254600.00 ns, 234.4182 ms/op
WorkloadResult  81: 3 op, 741918100.00 ns, 247.3060 ms/op
WorkloadResult  82: 3 op, 756426100.00 ns, 252.1420 ms/op
WorkloadResult  83: 3 op, 728751300.00 ns, 242.9171 ms/op
WorkloadResult  84: 3 op, 705731700.00 ns, 235.2439 ms/op
WorkloadResult  85: 3 op, 734056800.00 ns, 244.6856 ms/op
WorkloadResult  86: 3 op, 739406200.00 ns, 246.4687 ms/op
WorkloadResult  87: 3 op, 743256400.00 ns, 247.7521 ms/op
WorkloadResult  88: 3 op, 714829400.00 ns, 238.2765 ms/op
WorkloadResult  89: 3 op, 757953200.00 ns, 252.6511 ms/op
WorkloadResult  90: 3 op, 742721100.00 ns, 247.5737 ms/op
WorkloadResult  91: 3 op, 732679900.00 ns, 244.2266 ms/op
WorkloadResult  92: 3 op, 697060600.00 ns, 232.3535 ms/op
WorkloadResult  93: 3 op, 811382200.00 ns, 270.4607 ms/op
WorkloadResult  94: 3 op, 741882600.00 ns, 247.2942 ms/op
WorkloadResult  95: 3 op, 748912900.00 ns, 249.6376 ms/op
WorkloadResult  96: 3 op, 697916500.00 ns, 232.6388 ms/op
WorkloadResult  97: 3 op, 729043200.00 ns, 243.0144 ms/op
WorkloadResult  98: 3 op, 735578100.00 ns, 245.1927 ms/op
WorkloadResult  99: 3 op, 740278400.00 ns, 246.7595 ms/op

// AfterAll
// Benchmark Process 76628 has exited with code 0.

Mean = 240.639 ms, StdErr = 2.092 ms (0.87%), N = 99, StdDev = 20.811 ms
Min = 195.466 ms, Q1 = 232.496 ms, Median = 246.382 ms, Q3 = 252.212 ms, Max = 278.602 ms
IQR = 19.716 ms, LowerFence = 202.922 ms, UpperFence = 281.786 ms
ConfidenceInterval = [233.543 ms; 247.735 ms] (CI 99.9%), Margin = 7.096 ms (2.95% of Mean)
Skewness = -0.62, Kurtosis = 2.6, MValue = 2.33

// ** Remained 0 (0,0%) benchmark(s) to run. Estimated finish 2024-03-16 18:39 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Equilibrado)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\HashingBenchmark-report.csv
  BenchmarkDotNet.Artifacts\results\HashingBenchmark-report-github.md
  BenchmarkDotNet.Artifacts\results\HashingBenchmark-report.html

// * Detailed results *
HashingBenchmark.PBKDF2: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 2.370 ms, StdErr = 0.012 ms (0.49%), N = 19, StdDev = 0.051 ms
Min = 2.284 ms, Q1 = 2.333 ms, Median = 2.365 ms, Q3 = 2.397 ms, Max = 2.466 ms
IQR = 0.064 ms, LowerFence = 2.237 ms, UpperFence = 2.494 ms
ConfidenceInterval = [2.324 ms; 2.416 ms] (CI 99.9%), Margin = 0.046 ms (1.93% of Mean)
Skewness = 0.38, Kurtosis = 2.18, MValue = 2
-------------------- Histogram --------------------
[2.259 ms ; 2.319 ms) | @@
[2.319 ms ; 2.369 ms) | @@@@@@@@
[2.369 ms ; 2.427 ms) | @@@@@@
[2.427 ms ; 2.477 ms) | @@@
---------------------------------------------------

HashingBenchmark.BCryptHash: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 169.585 ms, StdErr = 0.806 ms (0.48%), N = 16, StdDev = 3.224 ms
Min = 163.645 ms, Q1 = 167.939 ms, Median = 169.673 ms, Q3 = 172.200 ms, Max = 174.544 ms
IQR = 4.261 ms, LowerFence = 161.549 ms, UpperFence = 178.591 ms
ConfidenceInterval = [166.303 ms; 172.867 ms] (CI 99.9%), Margin = 3.282 ms (1.94% of Mean)
Skewness = -0.28, Kurtosis = 1.81, MValue = 2
-------------------- Histogram --------------------
[162.715 ms ; 166.435 ms) | @@@
[166.435 ms ; 170.002 ms) | @@@@@
[170.002 ms ; 176.223 ms) | @@@@@@@@
---------------------------------------------------

HashingBenchmark.Argon2Hash: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 240.639 ms, StdErr = 2.092 ms (0.87%), N = 99, StdDev = 20.811 ms
Min = 195.466 ms, Q1 = 232.496 ms, Median = 246.382 ms, Q3 = 252.212 ms, Max = 278.602 ms
IQR = 19.716 ms, LowerFence = 202.922 ms, UpperFence = 281.786 ms
ConfidenceInterval = [233.543 ms; 247.735 ms] (CI 99.9%), Margin = 7.096 ms (2.95% of Mean)
Skewness = -0.62, Kurtosis = 2.6, MValue = 2.33
-------------------- Histogram --------------------
[189.562 ms ; 197.937 ms) | @
[197.937 ms ; 209.746 ms) | @@@@@@@@@@@@@
[209.746 ms ; 221.165 ms) | @@@@@@@
[221.165 ms ; 230.480 ms) | @@@
[230.480 ms ; 242.697 ms) | @@@@@@@@@@@
[242.697 ms ; 254.506 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[254.506 ms ; 266.904 ms) | @@@@@@@@@
[266.904 ms ; 279.562 ms) | @@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22000.2295/21H2/SunValley)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.200
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2


| Method     | Mean       | Error     | StdDev     | Median     |
|----------- |-----------:|----------:|-----------:|-----------:|
| PBKDF2     |   2.370 ms | 0.0456 ms |  0.0507 ms |   2.365 ms |
| BCryptHash | 169.585 ms | 3.2822 ms |  3.2235 ms | 169.673 ms |
| Argon2Hash | 240.639 ms | 7.0957 ms | 20.8106 ms | 246.382 ms |

// * Hints *
Outliers
  HashingBenchmark.Argon2Hash: Default -> 1 outlier  was  removed, 10 outliers were detected (195.47 ms..202.74 ms, 282.33 ms)

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  Median : Value separating the higher half of all measurements (50th percentile)
  1 ms   : 1 Millisecond (0.001 sec)

// ***** BenchmarkRunner: End *****
Run time: 00:01:52 (112.95 sec), executed benchmarks: 3

Global total time: 00:01:57 (117.81 sec), executed benchmarks: 3
// * Artifacts cleanup *
Artifacts cleanup is finished
```
