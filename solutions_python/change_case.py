def to_underscore(string):
    string = str(string)

    if len(string) < 2:
        return string
    
    str_list = list(string)
    str_list[0] = str_list[0].lower()
    i = 0
    
    while i < len(str_list):
        if str_list[i].isupper():
           str_list[i] = str_list[i].lower()
           str_list.insert(i, "_")
        i += 1

    result = ''.join(str_list)
    return result