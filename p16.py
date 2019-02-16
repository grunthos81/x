import math

def digitSum(n):
    total = 0
    while n != 0:
        total += n % 10
        n //= 10
    return total

a = digitSum(int(math.pow(2,1000)))
print(a)

