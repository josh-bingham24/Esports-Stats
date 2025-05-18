from pathlib import Path

def load_query(module: str, query_name: str) -> str:
    path = Path(__file__).parent / module / f"{query_name}.graphql"
    return path.read_text(encoding="utf-8").strip()