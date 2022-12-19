with open("input.txt") as file:
    readings = []

    for line in file:
        readings.append(line)

    increases = 1

    for i in range(1, len(readings)):
        if (readings[i] > readings[i-1]):
            increases += 1

print("Part 1: ", increases)
