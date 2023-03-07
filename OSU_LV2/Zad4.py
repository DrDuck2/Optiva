import numpy as np
import matplotlib.pyplot as plt

black_square = np.zeros((50, 50), dtype=np.uint8) #Crna = 0, velicina 50x50
white_square = np.ones((50, 50), dtype=np.uint8) * 255 #Bijela = 255, velicina 50x50

top_row = np.hstack((black_square, white_square)) #hstack postavio prvo crni pa bijeli kvadrat
bottom_row = np.hstack((white_square, black_square)) # bijeli pa crni
checkerboard = np.vstack((top_row, bottom_row)) # postavlja prvo gornji red pa onda donji red i vraca 2d matrix

plt.imshow(checkerboard, cmap='gray')
plt.show()