import tensorflow as tf
import matplotlib.pyplot as plt
import numpy as np

import matplotlib.image as Image

model = tf.keras.models.load_model("myModel.h5")

img = Image.imread("slika_3.png")[:,:,0]
normalized_img = tf.keras.utils.normalize(img, axis=1)
normalized_img = np.reshape(normalized_img, (1, 28,28))

plt.imshow(img, cmap='gray')
plt.show()

predictions = model.predict([normalized_img])
print(f"Predicted: {np.argmax(predictions)}")
print("Actual: 3")



# mnist = tf.keras.datasets.mnist 
# (X_train, y_train),(X_test, y_test) = mnist.load_data()

# X_train = tf.keras.utils.normalize(X_train, axis=1)
# X_test = tf.keras.utils.normalize(X_test, axis=1)

# plt.imshow(X_train[0], cmap="gray")
# plt.show()
        