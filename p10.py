#sieve of Eratosthenes lifted more or less from
#https://www.geeksforgeeks.org/python-program-for-sieve-of-eratosthenes/

def sieve(n):
    primes = [True for i in range(n+1)]
    primes[0] = False
    primes[1] = False
    p = 2
    while p * p <= n:
        if primes[p] == True:
            for i in range(p*2, n+1, p):
                primes[i] = False
        p += 1
    return primes

s = sieve(2000000)
total = 0
for i in range(2, len(s)):
    if s[i] == True:
        total += i
print(total)
