def plus_one(digits):
    for i in range(len(digits) - 1, -1, -1):
        if digits[i] == 9:
            digits[i] = 0
        else:
            digits[i] += 1
            return digits
        if i == 0:
            digits.insert(0,1)
            return digits