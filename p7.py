from euler import primes

s = primes(200000)
primeList = s.basicSieve()
count = 0
for i in range(0, 200000):
    if primeList[i] == True:
        count += 1
    if count == 10001:
        print(i)
        break
