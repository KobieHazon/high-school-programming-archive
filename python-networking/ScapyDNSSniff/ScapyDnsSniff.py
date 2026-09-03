from scapy.all import *
from scapy.layers.dns import *

def print_query_name(dns_packet):
    print dns_packet[DNSQR].qname
def filter_dns(packet):
    return (DNS in packet and packet[DNS].opcode == 0 and packet[DNSQR].qtype == 1)

sniff(count=10, lfilter=filter_dns, prn=print_query_name)