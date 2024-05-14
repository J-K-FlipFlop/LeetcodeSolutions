def till_addition(dict):
    total = 0
    for key in dict:
        if key[0] == "£":
            multiplier = int(key[1]) * (10 ** (len(key)-2))
        else:
            multiplier = int(key[0]) * (10 ** (len(key)-4))
        total += dict[key] * multiplier
    
    return total