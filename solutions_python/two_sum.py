def two_sum(nums, target):
    my_map = {}
    count = 0
    for num in nums:
        diff = target - num
        if num in my_map:
            index1 = my_map[num]
            index2 = count
        else:
            my_map[diff] = count
        count += 1
    result = [index1, index2]
    return result