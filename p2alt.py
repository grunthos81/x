import time
s = time.time()
total = 0
f = [0,1]
while f[-1] < 4000000:
    f.append(f[-1] + f[-2])
    if f[-1] % 2 == 0: total += f[-1]
print(total, time.time() - s)
