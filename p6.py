'''sum of squares can be found using Gauss' formula n(n+1)(2n+1)/6
   sum of naturals is just n(n+1)/2, a triangular number'''

sumOfSquares = (100*101*201) / 6
sumOfNums = int(((100*101)/2)**2)
print(sumOfNums-sumOfSquares)
