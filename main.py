def check_num(num, arr):
	for a in arr:
		if a == num:
			print('YES')
			return
	print('NO')


i1 = input()
i2 = input()
i3 = input()

count1 = i2.split()[0]
count2 = i3.split()[1]

a = i2.split()
b = i3.split()

for n in a: n = int(n)
for n in b: n = int(n)

for n in b: check_num(n, a)
		
