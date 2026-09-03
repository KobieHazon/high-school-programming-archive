import socket

s = socket.socket()
s.connect("127.0.0.1", 1729)
while(True):
    s.send(raw_input())
    print "Echo:" + s.recv(5024)
s.close()