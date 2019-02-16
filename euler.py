class primes:

    def __init__(self, limit):
        self.limit = limit

    def basicSieve(self):
        self.nums = [True] * self.limit
        self.nums[0] = self.nums[1] = False
        p = 2
        while p * p <= self.limit:
            if self.nums[p] == True:
                for i in range(p*2, self.limit, p):
                    self.nums[i] = False
            p+= 1
        return self.nums
    
