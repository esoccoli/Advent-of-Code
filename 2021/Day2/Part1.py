
with open("input.txt") as line:
    move = []

    horPos = 0
    depth = 0

    for step in line:
       move.append(step)

    for i in move:
        parts = i.split()

        if parts[0] == "forward":
            horPos += int(parts[1])
        elif parts[0] == "up":
            depth -= int(parts[1])
        else:
            depth += int(parts[1])

print("Part 1: ", horPos * depth)

