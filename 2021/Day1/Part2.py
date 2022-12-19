with open("input.txt") as line:
    vals = []
    sums = []

    for reading in line:
        vals.append(int(reading))

    for i in range(len(vals) - 2):
        sums.append(vals[i] + vals[i+1] + vals[i+2])

    timesIncreased = 0

    for item in range(len(sums)):
        if (sums[item] > sums[item-1]):
            timesIncreased += 1

print("Part 2: ", timesIncreased)
     
