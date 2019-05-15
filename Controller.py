stringArray = ["z", "e", "x", "c", "m", "q", "a", "b", "k", "r", "q", "o", "p", "gentle", "gentler", "gentlest", "wide"]
intArray = [10, 2, 1, 4, 3, 6, 8, 7, 11, 40, 102, 5435, 5, 13, 41]
charArray = ['a', 'z', 'y', 'c', 'm', 'z']


def quick_sort(array):
    if 1 >= len(array):
        return array
    else:
        return quick_sort([element for element in array[1:] if array[0] > element]) + [array[0]] + \
               quick_sort([element for element in array[1:] if array[0] <= element])


print("Unsorted string array")
print(stringArray)

print("Sorted string array")
print(quick_sort(stringArray))

print("Unsorted int array")
print(intArray)

print("Sorted int array")
print(quick_sort(intArray))

print("Unsorted character array")
print(charArray)

print("Sorted character array")
print(quick_sort(charArray))
