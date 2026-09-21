# High-School Programming Archive

A collection of my high-school programming exercises.

## Project Summary

This repository consolidates a small representative set of high-school Python networking exercises in one archive.

## Contents

- `python-networking/` contains small Python networking exercises covering sockets, simple client/server flows, DNS sniffing, and HTTP-style examples.

Two substantial projects from the same high-school archive are maintained independently:

- `high-school-dos-space-invaders`
- `high-school-nat-router`

## Tech Stack

- Python 2 networking scripts
- Basic sockets and Scapy-era packet inspection examples

## Validate

Run:

```sh
make check
make test
```

`make test` runs the actual echo client and time server over loopback sockets in a Python 2 Docker container, with external networking disabled. It checks request/reply behavior and client reconnection. Docker is required.

`make check` checks the source collection. The other classroom scripts include incomplete sketches and packet-sniffing examples; they are not all standalone applications and are not covered by the loopback suite.
