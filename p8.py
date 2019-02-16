import csv
matrix = []
with open('8.csv', newline='') as csvfile:
    itemReader = csv.reader(csvfile, delimiter=',')
    for row in itemReader:
        for item in row:
            matrix.append(int(item))

def product(a):
    total = 1
    for i in range(a, a+13):
        total *= matrix[i]
    return total

highest = 0
for i in range(0, 985):
    currentProduct = product(i)
    if currentProduct > highest:
        highest = currentProduct

print(highest)
