found = False
for i in range(1, 32):
    for j in range(1, 32):
        a = 2 * i * j
        b = i**2 - j**2
        c = i**2 + j**2
        if a + b + c == 1000 and a**2 + b**2 == c**2:
            print(a*b*c)
            found = True
            break;
    if found:
        break
