# High-School Programming Archive

My high-school exercises in C#, ASP.NET Web Forms and Python networking, organized by grade and topic. Supplied classroom and competition examples are kept separately with their credits.

## Contents

- [C# exercises](csharp/README.md): Grade 10 basics, arrays, strings and objects; Grade 11 linked lists, stacks, queues, trees and recursion; Grade 12 algorithm problems.
- [Web Forms exercises](webforms/README.md): calculators, selection controls, a shop, text formatting, a clock and introductory database pages.
- [Reference examples](reference/README.md): supplied school, textbook, classmate and competition code. These are not presented as my own solutions.
- `python-networking/`: Python 2 sockets, clients, servers and packet-inspection exercises.
- `tests/`: executable console, data-structure, web-form and networking tests.

The [DOS game](https://github.com/KobieHazon/high-school-dos-space-invaders) and [NAT router](https://github.com/KobieHazon/high-school-nat-router) are separate projects.

## Run a C# exercise

Install the .NET 10 SDK. For example:

```sh
dotnet run --project csharp/grade11/recursion/arrsum/Exercise.csproj
```

This prints `20`. Interactive exercises accept one value per line; press Ctrl+C to stop. With Python 3.9+ and `uv`, list or build the collection using:

```sh
uv run --no-project python csharp/run.py list
uv run --no-project python csharp/run.py build
```

The [C# index](csharp/README.md) identifies incomplete drafts and source examples with known limitations. Not every compiled exercise is a complete or correct application.

## Run a web exercise

Docker and `uv` are required:

```sh
make webforms-image
uv run --no-project python webforms/run.py calculator
```

Open <http://127.0.0.1:8080/Kobie_Calc.aspx>. Stop with Ctrl+C. The [Web Forms guide](webforms/README.md) lists the other sites and their entry pages. These are local teaching examples, not production web applications.

## Tests

With .NET 10, `uv` and Docker installed:

```sh
make test
```

- `make test-csharp` builds 166 console/library source sets, excluding seven incomplete drafts, then checks actual program outputs and 35 data-structure/recursion assertions. It does not claim exhaustive coverage of every historical exercise.
- `make test-webforms` runs eight basic sites through Mono's ASP.NET runtime in Docker, including calculator form submissions, clock resources and a shop order/session flow.
- `make test-python` runs the echo client and time server over loopback in a Python 2 container, checking replies and reconnection. Packet-sniffing examples and incomplete networking sketches are not covered.

The container tests have no external network access. The first image build downloads its dependencies. Access-database pages require Windows and a compatible database; they are not part of the Mono runtime test suite.
