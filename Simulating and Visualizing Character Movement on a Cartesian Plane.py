import matplotlib.pyplot as plt

# Define the initial position and the path of the character
initial_position = (0, 0)
path = [
    (2, -1),
    (4, -3),
    (3, -4),
    (0, 0)
]

# Extract x and y coordinates from the path
x_coords = [initial_position[0]] + [pos[0] for pos in path]
y_coords = [initial_position[1]] + [pos[1] for pos in path]

# Create a plot
plt.figure(figsize=(8, 8))

# Plot the path
plt.plot(x_coords, y_coords, 'ro-')  # 'ro-' means red color, circle markers, solid line

# Annotate each point
for i, (x, y) in enumerate(zip(x_coords, y_coords)):
    plt.text(x, y, f'({x}, {y})', fontsize=12, ha='right')

# Set the x and y axis labels
plt.xlabel('X-axis')
plt.ylabel('Y-axis')

# Set the x and y axis limits
plt.xlim(-1, 5)
plt.ylim(-5, 1)

# Draw grid
plt.grid(True)

# Title
plt.title('Character Movement in "The Sims" on a 2D Cartesian Plane')

# Draw axes
plt.axhline(0, color='black',linewidth=0.5)
plt.axvline(0, color='black',linewidth=0.5)

# Show the plot
plt.show()
t