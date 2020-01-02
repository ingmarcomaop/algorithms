# Drawing Book

import math

def pageCount(n, p):

    
    order_pages = int(p/2)
    inverted_pages = int(n/2 - order_pages)

    return min(order_pages, inverted_pages)
  

