import socket

s = socket.socket()
s.connect(("127.0.0.1", 1729))
while(True):
    try:
        message = raw_input()
    except EOFError:
        break
    s.sendall(message)
    print "Echo:" + s.recv(5024)
s.close()
