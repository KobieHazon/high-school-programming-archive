# ASP.NET Web Forms exercises

Grade 11 exercises using C#, server controls, postbacks and session state. They use classic `System.Web`, not ASP.NET Core.

## Run locally

From the repository root, with Docker and `uv` installed:

```sh
make webforms-image
uv run --no-project python webforms/run.py calculator
```

Open the page below at `http://127.0.0.1:8080/`. Use `--port 8081` to choose another host port. Press Ctrl+C to stop and remove the disposable container. The source is mounted read-only; the server works on a temporary copy.

| Site argument | Entry page | Exercise |
| --- | --- | --- |
| `calculator` | `Kobie_Calc.aspx` | Four arithmetic operations |
| `image-gallery` | `ImagesRay.aspx` | Image controls |
| `pizza-order` | `kobie_pizza.aspx` | Radio buttons, lists and checkboxes |
| `holiday` | `Default.aspx` | Button events and greeting text; also `Rosh Hashana.aspx` |
| `shop` | `Store.aspx` | Order controls and session-backed `Recipt.aspx` |
| `text-style` | `TextStyle.aspx` | Text, font, color and style controls |
| `clock` | `TimeLive.aspx` | Timer and partial page updates |
| `photo-page` | `Default.aspx` | Image selection controls |

The pages use neutral sample graphics. The small Mono teaching server is for these local exercises only: do not expose it to the internet. Some exercises use application-wide static fields and assume a single learner; they are not multi-user production applications.

## Access exercises

- `grade11/access-books` reads `Clients` and `Books` from `App_Data/Books.mdb` using the Jet OLE DB provider.
- `grade11/access-phone` uses the same table names in `App_Data/Database11.mdb`.
- `grade11/access-rival` is an unfinished data-display page without a database connection.
- `grade11/access-example` is an initial empty page template.

The first two require Windows, classic ASP.NET/.NET Framework, a matching 32-bit Jet provider, and your own sample database with the columns expected by the page. Database contents are not included. Open the site in a compatible Visual Studio/IIS Express setup; these pages are not supported by the Mono container. They are retained as source exercises, not claimed as tested database applications.

## Tests

```sh
make test-webforms
```

The tests render all eight basic sites and submit calculator operations and a shop order with a session cookie. They also check clock output and script-resource responses. The tests use the real ASP.NET page lifecycle inside an isolated, networkless Linux container; they do not replace the page code with mocks.
