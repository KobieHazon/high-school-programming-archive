# High-School Programming Archive

My selected high-school programming work.

## Project Summary

This repository consolidates a small representative set of high-school Python networking exercises in one archive.

## Contents

- `python-networking/` contains small Python networking exercises covering sockets, simple client/server flows, DNS sniffing, and HTTP-style examples.
- `docs/OMITTED_ARTIFACTS.md` lists recovered material that was intentionally left out.

Two substantial projects recovered from the same high-school archive are maintained independently:

- `high-school-dos-space-invaders`
- `high-school-nat-router`

## Tech Stack

- Python 2 networking scripts
- Basic sockets and Scapy-era packet inspection examples

## Validate

Run:

```sh
make check
```

The check confirms the expected representative files are present, verifies that the two standalone projects are no longer mixed into this archive, and scans tracked text for privacy and machine-path markers. Running the classroom network exercises still requires a controlled legacy Python 2 environment.
