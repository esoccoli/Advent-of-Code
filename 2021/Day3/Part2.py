with open('input.txt') as file:

    lines = []

    o2 = 0
    co2 = 0

    for line in file:
        lines.append(line)

    for j in range(2):

        l = lines[:]
        print(len(l))

        for i in range(12):

            if len(l) == 1:
                if not j:
                    o2 = int(l[0],2)

                else:
                    co2 = int(l[0],2)

                break

            ones = 0
            zeroes = 0

            for line in l:
                if line[i] == '1':
                    ones += 1

                else:
                    zeroes += 1

            if ones >= zeroes:
                target = '1'

            else:
                target = '0'

           
print("Part 2: ", o2*co2)