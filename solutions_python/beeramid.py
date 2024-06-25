def beeramid(money, price):
    i = 0
    total_beers = 0

    if money <= 0:
        return 0

    while total_beers * price < money:
        i += 1
        total_beers += i**2
    
    return i - 1