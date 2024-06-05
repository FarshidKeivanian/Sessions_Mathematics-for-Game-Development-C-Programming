import numpy as np
import matplotlib.pyplot as plt

# Define parameters
v0 = 20  # Initial velocity in m/s
theta = np.radians(45)  # Launch angle in degrees converted to radians
g = 9.81  # Acceleration due to gravity in m/s^2

# Calculate time of flight, maximum range, and maximum height
t_flight = 2 * v0 * np.sin(theta) / g
t = np.linspace(0, t_flight, num=500)

# Calculate projectile motion
x = v0 * np.cos(theta) * t
y = v0 * np.sin(theta) * t - 0.5 * g * t**2

# Plotting the trajectory
plt.plot(x, y)
plt.title('Projectile Motion of Angry Birds')
plt.xlabel('Distance')
plt.ylabel('Height')
plt.grid(True)
plt.show()
