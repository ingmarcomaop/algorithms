def timeConversion(s):

    hour = "" 
    ap = s[-2]
    #print(ap)
    h=s[0:2]
    #print(h)
    s1 = s[0:len(s)-2]
    #print(s1)
    array_str = [s[x] for x in range(0, len(s)-2)]

    #print(array_str)
    minutes = s[3:5]
    print(minutes)
    
    

    if(ap=="A"):
        
        if h == "12":
            array_str[0] = "0"
            array_str[1] = "0"
            hour = ''.join(array_str)
            print(hour)
        else:
            hour = ''.join(array_str)
            print(hour)
                
        return hour
            
    else:

        if h == "12":
            print(s1)
            return s1
        #if minutes != "00"
        else:
            h = int(h)
            h += 12
            h = str(h)
            array_str[0] = h[0]
            array_str[1] = h[1]
            hour = ''.join(array_str)
            print(hour)
        

        return hour
        
            
        


# return s[0:len(s)-2]  
# g = ''.join(d)

 
  


timeConversion("11:32:00PM")
