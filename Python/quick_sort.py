from typing import List


def quick_sort(data: List[int]) -> List[int]:
    """

    :type data: List[int]
    """
    if len(data) == 0:
        return []
    else:
        head, *tail = data
        smaller = quick_sort(list(filter(lambda x: x <= head, tail)))
        greater = quick_sort(list(filter(lambda x: x >= head, tail)))
        return list(smaller + [head] + greater)


print(quick_sort([5, 4, 2, 1, 77, 8, 555, 44444]))
