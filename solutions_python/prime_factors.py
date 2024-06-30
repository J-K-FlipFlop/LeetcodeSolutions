def prime_factors(n):
    i = 2
    factors = []
    while n > 1:
        if n % i == 0:
            n = n / i
            factors.append(i)
        else:
            i = i + 1

    my_dict = {i : factors.count(i) for i in factors}

    result_string = ""

    for key in my_dict:
        if my_dict[key] > 1:
            result_string = result_string + f"({key}**{my_dict[key]})"
        else:
            result_string = result_string + f"({key})"

    return result_string
