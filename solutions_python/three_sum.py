import copy

def three_sum(nums):
    my_dict = {}
    result_set = set()
    result = []

    for i in range(len(nums)):
        for j in range(i + 1, len(nums) - 1):
            sum = nums[i] + nums[j]
            neg = 0 - sum
            my_dict[neg] = [nums[i], nums[j]]
            if nums[j + 1] in my_dict:
                triplet = copy.deepcopy(my_dict[nums[j+1]])
                triplet.append(nums[j+1])
                triplet.sort()
                tup = tuple(triplet)
                result_set.add(tup)
        my_dict.clear()

    for val in result_set:
        result.append(list(val))
    return result