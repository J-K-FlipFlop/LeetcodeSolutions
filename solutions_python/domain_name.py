def get_domain_name(url):
    new_str = url.replace('http://', '')
    new_str = new_str.replace('https://', '')
    new_str = new_str.replace('www.', '')
    new_str = new_str.split(".")[0]
    
    result = new_str
    return result