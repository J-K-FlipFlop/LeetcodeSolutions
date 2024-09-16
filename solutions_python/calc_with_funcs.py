def zero(arg = None): 
    if arg:
        return arg(0)
    return 0
def one(arg = None): 
    if arg:
        return arg(1)
    return 1
def two(arg = None): 
    if arg:
        return arg(2)
    return 2
def three(arg = None): 
    if arg:
        return arg(3)
    return 3
def four(arg = None): 
    if arg:
        return arg(4)
    return 4
def five(arg = None): 
    if arg:
        return arg(5)
    return 5
def six(arg = None): 
    if arg:
        return arg(6)
    return 6
def seven(arg = None): 
    if arg:
        return arg(7)
    return 7
def eight(arg = None): 
    if arg:
        return arg(8)
    return 8
def nine(arg = None): 
    if arg:
        return arg(9)
    return 9

def plus(right): 
    def plus_func(left):
        return left + right
    return plus_func
def minus(right): 
    def minus_func(left):
        return left - right
    return minus_func
def times(right): 
    def times_func(left):
        return left * right
    return times_func
def divided_by(right): 
    def divide_by_func(left):
        return int(left) / right
    return divide_by_func