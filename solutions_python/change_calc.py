def change_calculator(num):
    result_dict = {}
    counter50 = 1
    counter20 = 1
    counter10 = 1
    counter5 = 1
    counter2 = 1
    counter1 = 1
    while(True):
        if num / 50 >= 1:
            num -= 50
            result_dict["50"] = counter50
            counter50 +=1
            continue
        if num / 20 >= 1:
            num -= 20
            result_dict["20"] = counter20
            counter20 +=1
            continue
        if num / 10 >= 1:
            num -= 10
            result_dict["10"] = counter10
            counter10 +=1
            continue
        if num / 5 >= 1:
            num -= 5
            result_dict["5"] = counter5
            counter5 +=1
            continue
        if num / 2 >= 1:
            num -= 2
            result_dict["2"] = counter2
            counter2 +=1
            continue
        if num / 1 >= 1:
            num -= 1
            result_dict["1"] = counter1
            counter1 +=1
            continue
        break

    return result_dict