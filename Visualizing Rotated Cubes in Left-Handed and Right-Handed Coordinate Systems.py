import matplotlib.pyplot as plt
import numpy as np
from mpl_toolkits.mplot3d.art3d import Poly3DCollection

def plot_cube(ax, vertices, color):
    # Plot vertices
    ax.scatter3D(vertices[:, 0], vertices[:, 1], vertices[:, 2])
    
    # List of sides' polygons
    verts = [[vertices[j] for j in [0, 1, 5, 4]],
             [vertices[j] for j in [7, 6, 2, 3]],
             [vertices[j] for j in [0, 3, 7, 4]],
             [vertices[j] for j in [1, 2, 6, 5]],
             [vertices[j] for j in [0, 1, 2, 3]],
             [vertices[j] for j in [4, 5, 6, 7]]]

    # Plot sides
    ax.add_collection3d(Poly3DCollection(verts, 
     facecolors=color, linewidths=1, edgecolors='black', alpha=.25))

def rotate_z(vertices, angle):
    # Rotation matrix for rotation around Z-axis
    rotation_matrix = np.array([
        [np.cos(angle), -np.sin(angle), 0],
        [np.sin(angle), np.cos(angle), 0],
        [0, 0, 1]
    ])
    return vertices @ rotation_matrix.T

# Define vertices of a unit cube
vertices = np.array([[0, 0, 0],
                     [1, 0, 0],
                     [1, 1, 0],
                     [0, 1, 0],
                     [0, 0, 1],
                     [1, 0, 1],
                     [1, 1, 1],
                     [0, 1, 1]])

# Rotate cube by 45 degrees (left-handed)
angle = np.pi / 4
rotated_vertices_lh = rotate_z(vertices, angle)

# Rotate cube by 45 degrees (right-handed)
angle = -np.pi / 4
rotated_vertices_rh = rotate_z(vertices, angle)

fig = plt.figure(figsize=(12, 6))

# Left-handed system
ax1 = fig.add_subplot(121, projection='3d')
plot_cube(ax1, rotated_vertices_lh, 'cyan')
ax1.set_title('Left-Handed System')
ax1.set_xlabel('X')
ax1.set_ylabel('Y')
ax1.set_zlabel('Z')

# Right-handed system
ax2 = fig.add_subplot(122, projection='3d')
plot_cube(ax2, rotated_vertices_rh, 'magenta')
ax2.set_title('Right-Handed System')
ax2.set_xlabel('X')
ax2.set_ylabel('Y')
ax2.set_zlabel('Z')

plt.show()
