# High-School Programming Archive

My selected high-school programming work.

## Project Summary

This repository consolidates a small representative set of high-school programming artifacts instead of publishing many small repos.

## Contents

- `assembly/space-invaders/` contains a DOS-era assembly game source snapshot with bitmap assets.
- `python-networking/` contains small Python networking exercises covering sockets, simple client/server flows, DNS sniffing, and HTTP-style examples.
- `docs/OMITTED_ARTIFACTS.md` lists recovered material that was intentionally left out.

## Tech Stack

- x86 assembly for DOS-style tooling
- Python 2 networking scripts
- Basic sockets and Scapy-era packet inspection examples

## Validate

Run:

```sh
make check
```

The check is static. It confirms the expected representative files are present and scans tracked text for privacy and machine-path markers. Legacy DOS/Python 2 tooling was not available during validation.
