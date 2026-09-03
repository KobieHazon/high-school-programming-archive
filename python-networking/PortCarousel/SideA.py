import socket, random

SA = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
SA.bind(("0.0.0.0", 8111))
IsClient = False
Input = ""
NewP = 8111
while(input != "exit"):
    if(IsClient == True):
        print "I am the client"
        input = raw_input()
        SA.send(input)
        NewP = random.randint(1000, 9999)
        SA.send(str(NewP))
        IsClient = False
        SA.close()
        SA = socket.socket()
        SA.bind(("0.0.0.0", int(NewP)))
    else:
        print "I am the server"
        SA.listen(1)
        (Data, Address) = SA.accept()
        Echo = Data.recv(1024)
        print "Echo: " + Echo
        NewP = Data.recv(1024)
        IsClient = True
        SA.close()
        SA = socket.socket()
        print "running on port- " + NewP
        SA.connect(("127.0.0.1", int(NewP)))
SA.close()
