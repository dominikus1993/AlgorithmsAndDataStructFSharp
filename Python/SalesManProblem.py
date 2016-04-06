import math
from typing import List
from random import random
import itertools

class City:
    def __init__(self, nr, x, y):
        self.nr = nr
        self.x = x
        self.y = y

    def __str__(self):
        return "[ nr: " + str(self.nr) + " x: " + str(self.x) + " y: " + str(self.y) + "]"

    def __repr__(self):
        return self.__str__()



def city_generator(n: int):
    res = [City(x + 1, random(), random()) for x in range(0, n)]
    return res


def count_cost(cities: List[City]):
    res = 0.0
    for x in range(1, len(cities) - 1):
        res = res + (cities[x + 1].x ** cities[x].x) + (cities[x - 1].y + cities[x].y)
    return math.sqrt(res)


def brute_force(cities: List[City]):
    return min([count_cost(cityGroup) for cityGroup in itertools.permutations(cities)])

def optimal_search(cities:List[City]):
    start = cities[0]
    to_visit = cities
    to_visit.remove(start)
    optimal_way = [start]
    while to_visit:
        nearest_city = min(to_visit,  key=lambda x: count_cost([optimal_way[-1], x]))
        optimal_way.append(nearest_city)
        to_visit.remove(nearest_city)
    return (optimal_way, count_cost(optimal_way))

cities = city_generator(5)

print(brute_force(cities))
print(optimal_search(cities))
