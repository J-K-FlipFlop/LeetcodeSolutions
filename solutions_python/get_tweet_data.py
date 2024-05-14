def get_tweet_data(myString):
    result_dict = {'tags': [], 'mentions': [], 'tagCount': 0, 
                   'mentionCount': 0, 'length': 0}
    
    result_dict["length"] = len(myString)

    words = myString.split()

    for word in words:
        if word[0] == "#" and word not in result_dict["tags"]:
            result_dict["tagCount"] += 1
            result_dict["tags"].append(word)
        elif word[0] == "@" and word not in result_dict["mentions"]:
            result_dict["mentionCount"] += 1
            result_dict["mentions"].append(word)
    
    return result_dict