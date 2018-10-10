## Fibonacci Series Algorithm Compare
Using recursive and non-recursive algorithms, compare the performance of each algorithm
### Objective
Highlight the risk of using recursive algorithms

### Recursive Algorithm to Implement Fibonacci Series
With recursion, fibonacci(n)=fibonacci(n-1)+fibonacci(n-2)
```
public long CalculateFibonacciNumber(int number)
{
    if (number < 0)
    {
        throw new NotSupportedException($"Invalid input {number} given");
    }
    if (number == 0)
    {
        return 0;
    }
    if (number == 1)
    {
        return 1;
    }
    return CalculateFibonacciNumber(number-1) + CalculateFibonacciNumber(number - 2);
}
```
### Non Recursive Algorithm to Implement Fibonacci Series
There are multiple ways to implement the non-recursive Fibonacci series, below is one such appraoch:
```
public long CalculateFibonacciNumber(int number)
{
    if (number < 0)
    {
        throw new NotSupportedException($"Invalid input {number} given");
    }
    if (number == 0)
    {
        return 0;
    }
    if (number == 1)
    {
        return 1;
    }
    long fibonnaciNMinus1 = 0;
    long fibonnaciNMinus2 = 1;
    for (int i = 2; i <= number; i++)
    {
        var temp = fibonnaciNMinus1 + fibonnaciNMinus2;
        fibonnaciNMinus2 = fibonnaciNMinus1;
        fibonnaciNMinus1 = temp;
    }
    return fibonnaciNMinus2 + fibonnaciNMinus1;
}
```
### Time Comparison - Data Table

|Index|Recursive Result|Recursive Time(ms)|Non-Recursive Result|Non-Recursive Time (ms)|
|-----------|-----------|-----------|-----------|-----------|
|1|1|0.0017|1|0.0003|
|2|1|0.002|1|0.0002|
|3|2|0.0023|2|0.0004|
|4|3|0.0018|3|0.0003|
|5|5|0.0011|5|0.0003|
|6|8|0.0013|8|0.0002|
|7|13|0.0017|13|0.0003|
|8|21|0.0038|21|0.0005|
|9|34|0.0044|34|0.0004|
|10|55|0.0061|55|0.0004|
|11|89|0.0091|89|0.0004|
|12|144|0.0159|144|0.0004|
|13|233|0.0193|233|0.0003|
|14|377|0.1508|377|0.0004|
|15|610|0.0553|610|0.0003|
|16|987|0.0859|987|0.0003|
|17|1597|0.1391|1597|0.0003|
|18|2584|0.2459|2584|0.0006|
|19|4181|0.3348|4181|0.0005|
|20|6765|0.5619|6765|0.0006|
|21|10946|1.1415|10946|0.0007|
|22|17711|1.5252|17711|0.0005|
|23|28657|3.6439|28657|0.001|
|24|46368|4.3966|46368|0.0007|
|25|75025|11.2265|75025|0.0008|
|26|121393|10.9638|121393|0.0008|
|27|196418|17.7121|196418|0.0009|
|28|317811|30.8077|317811|0.001|
|29|514229|48.1433|514229|0.0011|
|30|832040|90.1476|832040|0.0008|
|31|1346269|140.1047|1346269|0.0006|
|32|2178309|203.3559|2178309|0.0008|
|33|3524578|297.0507|3524578|0.0007|
|34|5702887|411.6255|5702887|0.0006|

### Time Comparison - Chart
![image Performance comparison](./images/performance-compare.png)

### Notes
#### Recursion Benefits
- Few lines to implement the algorithm
- Easy to read
#### Recursion Disadvantages
- Slower execution, especially when the no of recursions increase
- Higher memory usage, possibility for memory stack over flow error

### Conclusion
Never use recursion based algorithms for larger no. of recrusions. Try to find an appraoch to remove the recursion.

### Feedback
Let me know your thoughts on the appraoch.