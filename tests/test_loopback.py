"""Exercise the actual Python 2 programs over isolated loopback sockets."""
import os
import socket
import subprocess
import sys
import threading
import time
import unittest

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))


class LoopbackTests(unittest.TestCase):
    def test_time_server_responds_and_accepts_another_client(self):
        with open(os.devnull, 'w') as output:
            server = subprocess.Popen([sys.executable, os.path.join(ROOT, 'python-networking/WeatherApi/Server.py')], stdout=output, stderr=output)
            try:
                deadline = time.time() + 5
                while True:
                    try:
                        client = socket.create_connection(('127.0.0.1', 5000), timeout=1)
                        break
                    except socket.error:
                        if server.poll() is not None or time.time() > deadline:
                            self.fail('Time server did not start')
                        time.sleep(0.05)
                for index in range(2):
                    if index:
                        client = socket.create_connection(('127.0.0.1', 5000), timeout=1)
                    try:
                        client.sendall("What's the time?")
                        self.assertLess(abs(float(client.recv(4096)) - time.time()), 5)
                    finally:
                        client.close()
            finally:
                server.terminate()
                server.wait()

    def test_echo_client_sends_input_and_prints_reply(self):
        listener = socket.socket()
        listener.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        listener.bind(('127.0.0.1', 1729))
        listener.listen(1)
        listener.settimeout(5)
        received = []
        def echo():
            connection, _ = listener.accept()
            try:
                received.append(connection.recv(4096))
                connection.sendall(received[0])
            finally:
                connection.close()
        thread = threading.Thread(target=echo)
        thread.daemon = True
        thread.start()
        client = subprocess.Popen([sys.executable, os.path.join(ROOT, 'python-networking/EchoServer/EchoServer.py')], stdin=subprocess.PIPE, stdout=subprocess.PIPE, stderr=subprocess.PIPE)
        try:
            output, errors = client.communicate('hello\n')
            thread.join(5)
            self.assertEqual(client.returncode, 0, errors)
            self.assertEqual(received, ['hello'])
            self.assertIn('Echo:hello', output)
        finally:
            if client.poll() is None:
                client.kill()
                client.wait()
            listener.close()
