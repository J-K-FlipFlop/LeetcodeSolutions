def first_non_repeating_letter(s):
    my_list = []
    dupes = []

    for letter in s:
        lower = letter.lower()
        if letter in my_list:
            dupes.append(lower)
            my_list.remove(letter)
        elif lower in my_list:
            dupes.append(lower)
            my_list.remove(lower)
        elif letter in dupes or lower in dupes:
            pass
        else:
            my_list.append(letter)
    
    if not my_list:
        return ""
    
    result = my_list[0]
    return result


            