import itertools

def bin_to_dec(num):
    return int(num, 2)

def dec_to_bin(num):
     return bin(num)[3:]

def ip_to_binary(ip):
    return ".".join([dec_to_bin(int(x) + 256) for x in ip.split('.')])

def binary_ip_to_dec(ip):
    return ".".join([str(bin_to_dec(x)) for x in ip.split(".")])

def binary_operations(ip, func):
    res = func(ip.split(".")[::-1][0])
    return ip[0:26] + "." + res

def ip_generator(num):
    return "".join(map(lambda x: '.' if x % 9 == 0  else '0' ,[ x for x in range(num + 1,36)]))

def mask_generator(num):
    return "".join(map(lambda x: '.' if x % 9 == 0  else '1' if x <= (num + 3) else '0' ,[ x for x in range(1,36)]))

def network_operations(ip,mask):
    def operations(filter_func):
        zipped_list = zip(list(ip),list(mask))
        return "".join(map(lambda x: '.' if  x[0] == '.' or x[1] == '.' else '1' if filter_func(x[0], x[1]) else '0', zipped_list)) 
    return operations

ip_and_mask =  "212.191.99.68 27".split(" ")
ip_func = network_operations(ip_to_binary(ip_and_mask[0]),mask_generator(int(ip_and_mask[1])))

nettwork_address = ip_func(lambda x, y: x == '1' and y == '1')
print("network address: " + nettwork_address + " - " + binary_ip_to_dec(nettwork_address))

broadcast = ip_func(lambda x,y: x == '1' or str(int(not bool(int(y)))) == '1')
print("broadcast address: " + broadcast + " - " + binary_ip_to_dec(broadcast))

first_host = binary_operations(ip_func(lambda x,y: x == '1' and y == '1'), lambda x: dec_to_bin(bin_to_dec(x) + 257))
print("first host: " + first_host + " - " + binary_ip_to_dec(first_host))

last_host = binary_operations(ip_func(lambda x,y: x == '1' or str(int(not bool(int(y)))) == '1'), lambda x: dec_to_bin(bin_to_dec(x) + 255))
print("last host: " + last_host + " - " + binary_ip_to_dec(last_host))

first_ip = ip_to_binary("212.191.99.68")
second_ip = ip_to_binary("212.191.99.71")


result = "".join([x[0] for x in list(itertools.takewhile(lambda x: x[0] == x[1], zip(first_ip, second_ip)))])
mask_bit = str(len("".join(result.split("."))))
address = result + ip_generator(len(result))
print("network addrss:  " + address)
print("mask bit " + mask_bit)
