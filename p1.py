import time
s = time.time()
total = 0
for i in range(1, 1000):
    if i % 3 == 0 or i % 5 == 0:
        total += i
t = time.time()
print(total, t-s)



