import imageio
import os
import numpy as np

# Specify the directory where the png files are
png_dir = 'G:\\Projects\\Foxhound\FH2\\04-Results\\Finished\\A-10-002_FixedForces\\Animation\\images\\A-10-002_Animation\\'

# Get all file names in the directory
file_names = sorted((fn for fn in os.listdir(png_dir) if fn.endswith('.png')))

# An array to hold each frame
images = []

# Append each frame to the images array
for filename in file_names:
    images.append(imageio.v2.imread(png_dir+filename))

# Save the images as an animated gif
gifPath = os.path.join(png_dir, 'test.gif')
fps = 60
duration = 1/fps * 100
kargs = { 'duration': duration, 'optimize': True }
imageio.v2.mimwrite(gifPath, images, plugin='pillow', **kargs)
