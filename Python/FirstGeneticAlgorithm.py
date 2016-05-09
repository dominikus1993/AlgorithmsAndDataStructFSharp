import random
from functools import reduce

import numpy
import sys
from typing import List


def function(x):
    return 2 * (x ** x + 1)


values = range(1, 128)


def random_values_array_generator(array: List[int], count=50):
    return random.sample(array, count)


def count_max_function_value(numbers: List[int], n=128):
    maximum = 0
    for x in range(0, n):
        random_values = random_values_array_generator(numbers, 50)
        function_values = map(lambda val: function(val), random_values)

        maximum = max(function_values)

    return maximum


print(count_max_function_value(values, 5000))
