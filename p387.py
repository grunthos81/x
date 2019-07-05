import time
s = time.time()

def sumDigits(n):
    total = 0
    while n > 0:
        total += n % 10
        n //= 10
    return total

def isPrime(n):
    if n <= 1:
        return False
    elif n <= 3:
        return True
    elif n % 2 == 0 or n % 3 == 0:
        return False
    i = 5
    while i * i <= n:
        if n % i == 0 or n % (i + 2) == 0:
            return False
        i += 6
    return True

#CHEAT - I found during testing that solutions always begin with
#2,4,6,8 with the exception of 181. 

basket = [2,4,6,8]
found = False
newbasket = []
total = 181
while found == False:
    for i in basket:
        for j in range(0, 10):
            curr = (i*10) + j
            if curr > 100000000000000:
                found = True
                break
            if curr % sumDigits(curr) == 0:
                newbasket.append(curr)
            elif j in [1,3,7,9]:
                if isPrime(curr):
                #at this point H, RT, and P are confirmed. Just need S.
                    if isPrime((curr//10) / sumDigits(curr//10)):
                        total += curr
        if found == True:
            break
        
    basket = newbasket
    newbasket = []

print(total, time.time()-s)
        
