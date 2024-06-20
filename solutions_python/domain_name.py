def get_domain_name(url):
    new_str = url.replace('http://', '')
    new_str = new_str.replace('https://', '')
    new_str = new_str.replace('www.', '')
    result = new_str.split(".")[0]
    
    return result