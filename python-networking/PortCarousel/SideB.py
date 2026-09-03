import socket, random

SB = socket.socket()
SB.connect(("127.0.0.1", 8111))
input = ""
IsClient = True
while(input != "exit"):
    if (IsClient == True):
        print "I am the client!"
        input = raw_input()
        SB.send(input)
        NewP = random.randint(1000, 9999)
        SB.send(str(NewP))
        IsClient = False
        SB.close()
        SB = socket.socket()
        SB.bind(("0.0.0.0", int(NewP)))
    else:
        print "I am the Server!"
        SB.listen(1)
        (Data, Address) = SB.accept()
        Echo = Data.recv(1024)
        print "Echo: " + Echo
        NewP = Data.recv(1024)
        IsClient = True
        SB.close()
        SB = socket.socket()
        print "running on port- " + NewP
        SB.connect(("127.0.0.1", int(NewP)))
SB.close()