import numpy as np
import tensorflow as tf
from tensorflow import keras
from PIL import Image
import matplotlib.pyplot as plt



# učitavanje modela
model = keras.models.load_model('net.h5')

# učitavanje slike
img = Image.open('slika.png')

# prikaz slike
plt.imshow(img)
plt.show()

# pretvaranje slike u numpy array
img_array = np.array(img)

# skaliranje slike na raspon [0,1]
img_array = img_array.astype("float32") / 255

# dodavanje treće dimenzije (grayscale slika)
img_array = np.expand_dims(img_array, axis=2)

# dodavanje dimenzije serije (batch)
img_array = np.expand_dims(img_array, axis=0)

# klasifikacija slike
predictions = model.predict(img_array)

# ispis rezultata
print('Rezultat klasifikacije:', np.argmax(predictions))