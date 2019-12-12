import math

def is_smart_number(num):
    val = int(math.sqrt(num))
    print(str(num/val))
    if num / val == 0:
        return True
    return False


a = is_smart_number(2)
print(a)
