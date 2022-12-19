with open("input.txt") as file:

    lines = []
    for line in file:
        lines.append(line)

    gamma = ''
    epsilon = ''

    for i in range(12):

        zeros = 0
        ones = 0
        for line in lines:
            if line[i] == '0':
                zeros += 1
            else:
                ones += 1

        if ones > zeros:
            gamma += '1'
            epsilon += '0'
        else:
            gamma += '0'
            epsilon += '1'

        zeros = 0
        ones = 0

    gammaInt = 0
    epsilonInt = 0
    
    gammaInt = int(gamma, 2)
    epsilonInt = int(epsilon, 2)

    print("Part 1: ", gammaInt * epsilonInt)
