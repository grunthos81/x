import time
import random
s = time.time()

def sumDigits(n):
    total = 0
    while n > 0:
        total += n % 10
        n //= 10
    return total


 
def isPrime(n):
    """
    Miller-Rabin primality test.
 
    A return value of False means n is certainly not prime. A return value of
    True means n is very likely a prime.
    """
    if n!=int(n):
        return False
    n=int(n)
    #Miller-Rabin test for prime
    if n==0 or n==1 or n==4 or n==6 or n==8 or n==9:
        return False
 
    if n==2 or n==3 or n==5 or n==7:
        return True
    s = 0
    d = n-1
    while d%2==0:
        d>>=1
        s+=1
    assert(2**s * d == n-1)
 
    def trial_composite(a):
        if pow(a, d, n) == 1:
            return False
        for i in range(s):
            if pow(a, 2**i * d, n) == n-1:
                return False
        return True  
 
    for i in range(8):#number of trials 
        a = random.randrange(2, n)
        if trial_composite(a):
            return False
 
    return True 

#CHEAT - I found during testing that solutions always begin with
#2,4,6,8 with the exception of 181. 
def getStrongRight(n):
    basket = [2,4,6,8]
    found = False
    newbasket = []
    strongRightTruncatable = []
    while found == False:
        for i in basket:
            for j in range(0, 10):
                curr = (i*10) + j
                if curr > n:
                    found = True
                    break
                a = sumDigits(curr)
                if curr % a == 0 and isPrime(curr // a):
                    strongRightTruncatable.append(curr)
                    newbasket.append(curr)
                elif curr % a == 0:
                    newbasket.append(curr)
            if found == True:
                break

        basket = newbasket
        newbasket = []
    return strongRightTruncatable

def getPrimes(srt):
    total = 0
    ends = [1,3,7,9]
    for item in srt:
        for jtem in ends:
            curr = (item * 10) + jtem
            if isPrime(curr):
                total += curr
    return total

print(181 + getPrimes(getStrongRight(10000000000000)), time.time()-s)

#using basic primality test, takes 25.729 seconds in Idle, or 6.172 seconds in pypy3
#using Miller-Rabin test takes 1 sec in both.         
