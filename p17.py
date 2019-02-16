hundreds = [0,13,13,15,14,14,13,15,15,14]

tens = [0,0,6,6,5,5,5,7,6,6]

units = [0,3,3,5,4,4,3,5,5,4,3,6,6,8,8,7,7,9,8,8]

total = 11

for i in range(1, 1000):
    if i % 100 == 0:
        total += hundreds[i//100] - 3
        continue;
    if i % 100 < 20:
        total += (hundreds[i//100] + units[i%100])
    else:
        total += (hundreds[i // 100] + tens[(i % 100)//10] + units[i % 10])

print(total)
