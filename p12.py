
def getFactors(n):
    factors = {}
    start = 2
    while n != 1:
        if n % start == 0:
            if start in factors:
                factors[start] += 1
            else:
                factors[start] = 1
                
            n /= start
        else:
            start += 1
    numFactors = 1
    for k, v in factors.items():
        numFactors *= (v+1)
    return numFactors

tNum = 28
add = 8
while getFactors(tNum) < 500:
    tNum += add
    add += 1

print(tNum)
    
            
