import csv
triangle = []
with open('18.csv', newline='') as csvfile:
    itemReader = csv.reader(csvfile, delimiter=' ')
    for row in itemReader:
        r = []
        for item in row:
            r.append(int(item))
        triangle.append(r)

for i in range(len(triangle) - 2, -1, -1):
    for j in range(0, len(triangle[i])):
        triangle[i][j] += max([triangle[i+1][j], triangle[i+1][j+1]])

print(triangle[0][0])
