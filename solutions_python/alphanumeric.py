def alphanumeric(s):

    if len(password) < 1:
        return False

    for letter in s:
        asc = ord(letter)

        if asc < 48:
            return False
        elif asc > 57 and asc < 65:
            return False
        elif asc > 90 and asc < 97:
            return False
        elif asc > 122:
            return False
        
        return True

alphanumeric("hello")