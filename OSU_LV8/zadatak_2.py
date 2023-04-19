import numpy as np
import matplotlib.pyplot as plt
from tensorflow import keras
from sklearn.metrics import confusion_matrix

#Ucitavanje modela
model = keras.models.load_model('net.h5')

#Podaci za treniranje i ucenje iz MNIST
(x_train, y_train), (x_test, y_test) = keras.datasets.mnist.load_data()

# Skaliranje slika
x_test = x_test / 255.0

# Predviđanje na testnom skupu podataka
y_pred = model.predict(x_test)

# Pronalazak indeksa slika koje su loše klasificirane
y_pred_classes = np.argmax(y_pred, axis=1)
bad_classifications = np.nonzero(y_pred_classes != y_test)[0]

# Prikazivanje nekoliko loše klasificiranih slika
num_samples_to_show = 5
for i in range(num_samples_to_show):
    index = bad_classifications[i]
    plt.imshow(x_test[index], cmap='gray')
    plt.title(f"Stvarna oznaka: {y_test[index]}, Predviđena oznaka: {y_pred_classes[index]}")
    plt.show()