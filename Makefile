.PHONY: check test build-csharp test-csharp test-python webforms-image test-webforms

check: test

test: test-csharp test-python test-webforms

build-csharp:
	uv run --no-project python csharp/run.py build --include-reference

test-csharp: build-csharp
	uv run --no-project python -m unittest discover -s tests -p test_csharp.py -v

test-python:
	docker run --rm --network none --cap-drop ALL --security-opt no-new-privileges -e PYTHONDONTWRITEBYTECODE=1 -v "$(CURDIR):/project:ro" -w /project python:2.7.18-slim python -m unittest discover -s tests -p test_loopback.py

webforms-image:
	docker build -f tests/webforms.Dockerfile -t high-school-webforms:local .

test-webforms: webforms-image
	docker run --rm --network none --cap-drop ALL --security-opt no-new-privileges -e PYTHONDONTWRITEBYTECODE=1 -v "$(CURDIR):/project:ro" -w /project high-school-webforms:local python3 -m unittest discover -s tests -p test_webforms.py -v
