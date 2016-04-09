import random
import numpy

point_vector = numpy.array([[-8, 2, 4, 5, -9, -6, -2, -6, -2, 1, 4], [-20, 20, 25, 9, -10, -5, -10, -25, -10, -10, -16]])
teacher_vector = []


def generate_w_vector(point_v):
    for x in range(0, len(point_v)):
        yield random.random()


w = list(generate_w_vector(point_vector))
b = random.random()

point_vector = [list(i) for i in zip(*point_vector)]


def neuron(w_vector, point_vector, b_ratio):
    i = 0
    e = []
    while True:
        t = random.choice(point_vector[i])
        a = numpy.dot(w_vector, point_vector[i]) + b_ratio
        point_vector[i][1] = 1 if a > 0 else 0
        error = t - point_vector[i][1]
        e.append(error)
        if error != 0:
            b_ratio += error
            w_vector += numpy.dot(error, point_vector[i])
        else:
            return a, b

        i = (i + 1) % len(point_vector)


print(neuron(w, point_vector, b))
