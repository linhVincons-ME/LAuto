# Shared paths for the LAuto Python scripts. Override with LAUTO_ROOT / LAUTO_SRC / LAUTO_WORK;
# otherwise everything is resolved relative to this folder, so the LAuto tree can be moved freely.
import os

SCRIPTS_DIR = os.path.dirname(os.path.abspath(__file__))
ROOT = os.environ.get('LAUTO_ROOT') or os.path.dirname(SCRIPTS_DIR)
SRC_DIR = os.environ.get('LAUTO_SRC') or os.path.join(ROOT, 'src')
WORK_DIR = os.environ.get('LAUTO_WORK') or os.path.join(ROOT, 'work')
ERRORS_FILE = os.path.join(WORK_DIR, 'errors.txt')


def arg(argv, index, default):
    """argv[index] if given, else default."""
    return argv[index] if len(argv) > index else default
