"""Run a classic Web Forms exercise locally in a disposable Mono container."""
import argparse
from pathlib import Path
import subprocess

ROOT = Path(__file__).resolve().parents[1]
PAGES = {'calculator':'Kobie_Calc.aspx','image-gallery':'ImagesRay.aspx','pizza-order':'kobie_pizza.aspx','holiday':'Default.aspx','shop':'Store.aspx','text-style':'TextStyle.aspx','clock':'TimeLive.aspx','photo-page':'Default.aspx'}
parser = argparse.ArgumentParser(description=__doc__)
parser.add_argument('site', choices=PAGES)
parser.add_argument('--port', type=int, default=8080)
args = parser.parse_args()
if not 1024 <= args.port <= 65535:
    parser.error('Use a port from 1024 to 65535.')
print(f'Open http://127.0.0.1:{args.port}/{PAGES[args.site]} — Ctrl+C to stop.', flush=True)
command = 'cp -R /source/webforms/grade11/"$1" /tmp/site; mkdir -p /tmp/site/bin; mcs -r:System.Web -out:/tmp/site/bin/Server.exe /source/webforms/Server.cs; exec mono /tmp/site/bin/Server.exe /tmp/site 8080'
raise SystemExit(subprocess.call(['docker','run','--rm','--init','--cap-drop','ALL','--security-opt','no-new-privileges','-p',f'127.0.0.1:{args.port}:8080','-v',str(ROOT)+':/source:ro','high-school-webforms:local','sh','-ec',command,'webforms',args.site]))
