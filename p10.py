from euler import primes

s = primes(2000000)
primeList = s.basicSieve()
total = sum([i for i in range(0,2000000) if primeList[i]])
print(total)
