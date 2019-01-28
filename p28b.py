import time
start = time.time()
total = -3
for i in range(1, 502):
    total = total + ((((2*i)-1)**2))
    total = total + ((4 * (i**2)) - (10*i) + 7)
    total = total + ((4 * (i**2)) - (8*i) + 5)
    total = total + ((4 * (i**2)) - (6*i) + 3)
print(total)
print(time.time() - start)
