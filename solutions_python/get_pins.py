def get_pins(observed):
    result = ['11', '12', '14', '21', '22', '24', '41', '42', '44']
    print(len(result))
    temp = []
    for num in observed:
        match num:
            case "0":
                digits = ["8","0"]
            case "1":
                digits = ["1","2","4"]
            case "2":
                digits = ["1","2","3","5"]
            case "3":
                digits = ["2","3","6"]
            case "4":
                digits = ["1","4","5","7"]
            case "5":
                digits = ["2","4","5","6","8"]
            case "6":
                digits = ["3","5","6","9"]
            case "7":
                digits = ["4","7","8"]
            case "8":
                digits = ["5","7","8","9","0"]
            case "9":
                digits = ["6","8","9"]

        print(digits)
        for digit in digits:
            for num in result:
                combination = digit + num
                temp.append(combination)
                print(combination)
                print(temp)
                # print(f"{digit} : {num}")
        # result = temp
        print(result)
        # for digit in digits:
        #     for num in result:
        #         combination = digit + num
        #         temp.append(combination)
        #         print(temp)
        # result = temp
    print(result)

get_pins("1")