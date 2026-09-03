import socket



DNS_Server_IP = '0.0.0.0'
DNS_Server_Port = 8111
Buffer_Size = 1024

def DNS_Handler(Data, Address):
    print "Data: " + Data
    print "Address: " + Address


def DNS_Server(IP, Port):
    ServerS = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    ServerS.bind((IP, Port))
    print "Server started!"
    while (True):
        try:
            data, addr = ServerS.recvfrom(Buffer_Size)
            DNS_Handler(data, addr)
        except Exception, ex:
            print "Client exception!    %s" % (str(ex), )


if __name__ == '__main__':
    print "starting udp server..."
    DNS_Server(DNS_Server_IP, DNS_Server_Port)