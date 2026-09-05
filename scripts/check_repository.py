#!/usr/bin/env python3
import re
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
required = [
    ROOT / "python-networking" / "SocketTry" / "SocketTry.py",
    ROOT / "python-networking" / "WeatherApi" / "Server.py",
    ROOT / "python-networking" / "messaging" / "Messaging.py",
]
missing = [str(path.relative_to(ROOT)) for path in required if not path.exists()]
if missing:
    print("Missing required files: " + ", ".join(missing), file=sys.stderr)
    sys.exit(1)

if (
    (ROOT / "assembly").exists()
    or (ROOT / "Main.py").exists()
    or (ROOT / "NATscript.sh").exists()
):
    print("A standalone project is still mixed into this archive", file=sys.stderr)
    sys.exit(1)

for path in ROOT.rglob("*"):
    if ".git" in path.parts:
        continue
    rel = path.relative_to(ROOT).as_posix()
    if any(part.startswith("._") for part in path.parts) or path.name in {
        ".DS_Store",
        "Thumbs.db",
    }:
        print(f"Metadata file should not be staged: {rel}", file=sys.stderr)
        sys.exit(1)
    if path.suffix.lower() in {
        ".com",
        ".debug",
        ".list",
        ".symbol",
        ".doc",
        ".docx",
        ".pdf",
        ".mov",
        ".mp4",
        ".avi",
    }:
        print(f"Forbidden generated/private artifact: {rel}", file=sys.stderr)
        sys.exit(1)

text_files = [
    p
    for p in ROOT.rglob("*")
    if p.is_file()
    and ".git" not in p.parts
    and p.suffix.lower() in {".py", ".asm", ".md", ".txt", ""}
]
combined = "\n".join(p.read_text(encoding="utf-8", errors="ignore") for p in text_files)
markers = [
    "".join(["208", "234", "161"]),  # noqa: FLY002 - avoid matching this checker
    "/" + "Users" + "/",
    "/" + "home" + "/",
    "C:" + "\\" + "Users",
]
if any(marker in combined for marker in markers) or re.search(
    r"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+", combined
):
    print("Privacy or machine-path marker found in tracked text", file=sys.stderr)
    sys.exit(1)
for marker in ["socket", "scapy"]:
    if marker not in combined:
        print(f"Missing expected marker: {marker}", file=sys.stderr)
        sys.exit(1)
print("Repository static checks passed.")
