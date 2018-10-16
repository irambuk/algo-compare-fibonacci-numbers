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

|Index|Recursive Result|Recursive Time(ms)|Recursive Time(ms) - Log|Non-Recursive Result|Non-Recursive Time (ms)|
|-----------|-----------|-----------|-----------|-----------|-----------|
|1|1|0.0008|-3.09691001300806|1|0.0001|
|2|1|0.0011|-2.95860731484178|1|0.0004|
|3|2|0.001|-3|2|0.0002|
|4|3|0.0017|-2.76955107862173|3|0.0002|
|5|5|0.0013|-2.88605664769316|5|0.0003|
|6|8|0.0028|-2.55284196865778|8|0.0006|
|7|13|0.0017|-2.76955107862173|13|0.0002|
|8|21|0.0021|-2.67778070526608|21|0.0002|
|9|34|0.0029|-2.53760200210104|34|0.0002|
|10|55|0.0116|-1.93554201077308|55|0.0003|
|11|89|0.0098|-2.00877392430751|89|0.0003|
|12|144|0.0119|-1.92445303860747|144|0.0003|
|13|233|0.0145|-1.83863199776503|233|0.0003|
|14|377|0.0226|-1.6458915608526|377|0.0002|
|15|610|0.0475|-1.32330639037513|610|0.0003|
|16|987|0.1142|-0.942333896090171|987|0.0004|
|17|1597|0.2504|-0.601365675461608|1597|0.0003|
|18|2584|0.1521|-0.817870785947002|2584|0.0002|
|19|4181|0.2588|-0.587035728003337|4181|0.0003|
|20|6765|0.409|-0.388276691992658|6765|0.0002|
|21|10946|0.8623|-0.0643416138993658|10946|0.0004|
|22|17711|1.1|0.0413926851582251|17711|0.0003|
|23|28657|3.0435|0.483373306089027|28657|0.0006|
|24|46368|3.3529|0.525420600820462|46368|0.0009|
|25|75025|6.4829|0.811769322577276|75025|0.0006|
|26|121393|12.5782|1.09961849595826|121393|0.0008|
|27|196418|18.2542|1.26136280451671|196418|0.0007|
|28|317811|45.4416|1.65745361449296|317811|0.0013|
|29|514229|52.4545|1.71978275165897|514229|0.0006|
|30|832040|128.0492|2.10737686951534|832040|0.001|
|31|1346269|139.3665|2.14415839346369|1346269|0.0009|
|32|2178309|220.4585|2.34332684814728|2178309|0.0009|
|33|3524578|352.4828|2.54713792970376|3524578|0.0007|
|34|5702887|479.5021|2.68079051352215|5702887|0.0008|
|35|9227465|682.5002|2.83410278297856|9227465|0.0006|
|36|14930352|973.4179|2.98829932814105|14930352|0.0009|
|37|24157817|1629.5839|3.21207672526082|24157817|0.0006|
|38|39088169|2709.6336|3.43291056900863|39088169|0.011|
|39|63245986|4160.437|3.61913895003081|63245986|0.0006|

### Time Comparison - Chart
![image Performance comparison](https://github.com/irambuk/fibonacci-series-algos/blob/master/Images/performance-compare.png)

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