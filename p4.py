
def isPalindrome(n):
    return str(n) == str(n)[::-1]

largest = 0
for i in range(100,1000):
    for j in range(100,1000):
        if isPalindrome(i*j) and i*j > largest:
            largest = i*j

print(largest)
