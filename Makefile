.PHONY: check

check:
	python3 scripts/check_repository.py

.PHONY: test
test:
	docker run --rm --network none --cap-drop ALL --security-opt no-new-privileges -e PYTHONDONTWRITEBYTECODE=1 -v "$(CURDIR):/project:ro" -w /project python:2.7.18-slim python -m unittest discover -s tests
