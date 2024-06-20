def parts_sums(ls):
    sum = 0
    for num in ls:
        sum = sum + num

    result = [sum]

    for num in ls:
        sum = sum - num
        result.append(sum)
    
    return result

ls = [0,1,3,6,10]
parts_sums(ls)
