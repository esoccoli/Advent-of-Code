with open("input.txt") as line:
    moves = []

    aim = 0
    depth = 0
    horPos = 0

    for i in line:
        moves.append(i)

    for i in moves:
        parts = i.split()

        if parts[0] == "forward":
            horPos += int(parts[1])
            depth += aim* int(parts[1])
        elif parts[0] == "down":
            aim += int(parts[1])
        else:
            aim -= int(parts[1])
print("Part 2:", horPos * depth)
