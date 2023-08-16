n = int(input())
s = 0
if n > 0:
    for i in range(1,n+1):
        s+=i
elif n<0:
    for i in range(n,2):
        s+=i
else:
    s=1
print(s)