def satisfies_relation(a, b):
    return b != 0 and a %(b**2) == 0

a = int(input("Enter the first natural number: A"))
b = int(input("Enter the second natural number B:"))

if satisfies_relation(a, b):
    print(f"the numbers {a} and {b} satisfy the relation R")
else:
    print(f"The numbers {a} and {b} do not satisfy the relation R")