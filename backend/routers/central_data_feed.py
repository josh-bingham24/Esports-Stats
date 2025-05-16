from decouple import config
from fastapi import APIRouter
from fastapi.responses import JSONResponse
import requests


router = APIRouter(
    prefix="/central_data_feed"
)


api_key = config('x-api-key')


def send_request(url, query) -> requests.Response:
    headers = {
        "Content-Type": "application/json",
        "x-api-key": api_key
    }

    response = requests.post(
        url=url,
        json={"query": query},
        headers=headers
    )
    
    return response


@router.get("/get_title")
async def get_title(id: str):
    query = f"""
        query get_title {{
            title(id: {id}) {{
                id
                name
                nameShortened
            }}
        }}
    """
    
    response = send_request("https://api-op.grid.gg/central-data/graphql", query)
    
    if response.status_code == 200:
        response = response.json()
        title = response.get("data", {}).get("title", [])
        return title
    else:
        return {"error": response.text, "status_code": response.status_code}


@router.get("/get_titles")
async def get_titles():
    query = """
    query GetTitles {
      titles(filter: {}) {
        id
        name
        nameShortened
      }
    }
    """
    
    response = send_request("https://api-op.grid.gg/central-data/graphql", query)
    
    if response.status_code == 200:
        response = response.json()
        titles = response.get("data", {}).get("titles", [])
        return titles
    else:
        return {"error": response.text, "status_code": response.status_code}
    
    
    
@router.get('/get_orgs')
async def get_orgs(search: str):
    query = f"""
    query getOrginizations {{
        organizations(first: 2, filter: {{ name: {{ contains: {search} }} }}) {{
            totalCount
            edges {{
                node {{
                    id
                    name
                }}
            }}
        }}
    }}
    """
    
    response = send_request("https://api-op.grid.gg/central-data/graphql", query)
    
    if response.status_code == 200:
        response = response.json()
    
        simplified_orgs = [
            {
                "id": edge["node"]["id"],
                "name": edge["node"]["name"]
            }
            for edge in response["data"]["organizations"]["edges"]
        ]
        
        return JSONResponse(content=simplified_orgs)
    else:
        return {"error": response.text, "status_code": response.status_code}
    
    

@router.get('/get_team')
async def get_team(titleId: str, orgId: str):
    query = f"""
    query getTeams {{
        teams(first: 1, filter: {{titleId: {titleId}, organizationId: {orgId}}}) {{
            edges {{
                node {{
                    id
                    title {{
                        id
                        name
                        nameShortened
                    }}
                    name
                    colorPrimary
                    colorSecondary
                    logoUrl
                }}
            }}
        }}
    }}
    """
    
    response = send_request("https://api-op.grid.gg/central-data/graphql", query)
    
    if response.status_code == 200:
        response = response.json()
    
        simplified_orgs = [
            {
                "id": edge["node"]["id"],
                "title": edge["node"]["title"],
                "name": edge["node"]["name"],
                "colorPrimary": edge["node"]["colorPrimary"],
                "colorSecondary": edge["node"]["colorSecondary"],
                "logoUrl": edge["node"]["logoUrl"]
            }
            for edge in response["data"]["teams"]["edges"]
        ]
        
        return JSONResponse(content=simplified_orgs)
    else:
        return {"error": response.text, "status_code": response.status_code}