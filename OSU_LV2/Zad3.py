import numpy as np
import matplotlib.pyplot as plt

img = plt.imread('road.jpg')

# a) 
brightness_increase = 50
brighter_image = np.clip(img.astype(np.int32) + brightness_increase, 0, 255).astype(np.uint8)

# b)
height, width, unused = img.shape
cropped_image = img[:, width // 4:width // 2, :]

# c) 
rotated_image = np.rot90(img, k=3)

# d) 
flipped_image = np.fliplr(img)

plt.imshow(img)
plt.show()
plt.imshow(brighter_image)
plt.show()
plt.imshow(cropped_image)
plt.show()
plt.imshow(rotated_image)
plt.show()
plt.imshow(flipped_image)
plt.show()