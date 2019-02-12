import time
s = time.time()
f = [0,1]
total = 0
while f[-1] < 4000000:
    f2 = f[0] + f[1]
    f[0] = f[1]
    f[1] = f2
    if f[1] % 2 == 0: total += f[1]

print(total, time.time() - s)
