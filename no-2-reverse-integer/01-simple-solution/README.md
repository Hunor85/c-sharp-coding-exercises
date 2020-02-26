
## Algorithm:

Input:  num
(1) Initialize rev_num = 0
(2) Loop while num > 0
     (a) Multiply rev_num by 10 and add remainder of num  
          divide by 10 to rev_num
               rev_num = rev_num*10 + num%10;
     (b) Divide num by 10
(3) Return rev_num


## Example:
num = 4562
rev_num = 0

rev_num = rev_num *10 + num%10 = 2
num = num/10 = 456

rev_num = rev_num *10 + num%10 = 20 + 6 = 26
num = num/10 = 45

rev_num = rev_num *10 + num%10 = 260 + 5 = 265
num = num/10 = 4

rev_num = rev_num *10 + num%10 = 265 + 4 = 2654
num = num/10 = 0
