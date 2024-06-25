def generate_hashtag(s):

    if len(s) < 1:
        return False
    
    words = s.strip().split(" ")
    result = "#"
    for word in words:
        if len(word) > 0:
            capitalized = word[0].upper() + word[1:].lower()
            result = result + capitalized

    if len(result) > 140:
        return False
    
    return result