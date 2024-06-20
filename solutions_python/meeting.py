def meeting(s):
    names = s.split(";")
    name_list = []
    result = ""
    for name in names:
        split = name.split(":")
        first_name = split[0]
        last_name = split[1]

        name_string = f"({last_name}, {first_name})"
        upper = name_string.upper()
        name_list.append(upper)

    name_list = sorted(name_list)

    for name in name_list:
        result = result + name
    
    return result
    
s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill"
meeting(s)