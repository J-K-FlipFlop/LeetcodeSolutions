def letter_combinations(digits):
    nested_list = []

    if len(digits) < 1:
        return digits

    for digit in digits:
        if digit == "2":
            nested_list.append(["a", "b", "c"])
        elif digit == "3":
            nested_list.append(["d", "e", "f"])
        elif digit == "4":
            nested_list.append(["g", "h", "i"])
        elif digit == "5":
            nested_list.append(["j", "k", "l"])
        elif digit == "6":
            nested_list.append(["m", "n", "o"])
        elif digit == "7":
            nested_list.append(["p", "q", "r", "s"])
        elif digit == "8":
            nested_list.append(["t", "u", "v"])
        elif digit == "9":
            nested_list.append(["w", "x", "y", "z"])
        else:
            return "invalid number"
            

    result_list = nested_list[0]
    temp_list = []
    for k in range(1, len(nested_list)):
        for i in range(len(result_list)):
            for j in range(len(nested_list[k])):
                concat = result_list[i] + nested_list[k][j]
                temp_list.append(concat)
        result_list = temp_list
        temp_list = []
        
    return result_list
            

digits= "2"
letter_combinations(digits)
    

