from decouple import config
from typing import Optional
from fastapi import APIRouter
from fastapi.responses import JSONResponse
from ..queries import load_query
import requests


router = APIRouter(
    prefix="/central_data_feed"
)


api_key = config('x-api-key')
enpoint_url = "https://api-op.grid.gg/central-data/graphql"


def send_request(query, variables=None) -> requests.Response:
    headers = {
        "Content-Type": "application/json",
        "x-api-key": api_key
    }

    response = requests.post(
        url=enpoint_url,
        json={"query": query, "variables": variables},
        headers=headers
    )   
    
    return response


@router.get("/all_series")
async def all_series(
    after: Optional[str] = None,
    before: Optional[str] = None,
    first: int = 50,
    last: Optional[int] = None
):  
    query = load_query("central_data_queries", "all_series")
    
    variables = {
        "after": after,
        "before": before,
        "first": first,
        "last": last
    }
    
    response = send_request(query, variables)
    
    if response.status_code == 200:
        json: dict = response.json().get("data").get("allSeries")
        return json
    else:
        return {"error": response.text, "status_code": response.status_code}


@router.get("/data_providers")
async def data_providers():  
    query = load_query("central_data_queries", "data_providers")
    
    response = send_request(query)
    
    if response.status_code == 200:
        json: dict = response.json().get("data").get("dataProviders")
        return json
    else:
        return {"error": response.text, "status_code": response.status_code}
    
    
@router.get("/organization")
async def organization(
    id: str
):  
    query = load_query("central_data_queries", "organization")
    
    variables = {
        "id": id,
    }
    
    response = send_request(query, variables)
    
    if response.status_code == 200:
        json: dict = response.json().get("data").get("organization")
        return json
    else:
        return {"error": response.text, "status_code": response.status_code}
    
    
@router.get("/organizations")
async def organizations(
    after: Optional[str] = None,
    before: Optional[str] = None,
    first: int = 50,
    last: Optional[int] = None
):  
    query = load_query("central_data_queries", "organizations")
    
    variables = {
        "after": after,
        "before": before,
        "first": first,
        "last": last
    }
    
    response = send_request(query, variables)
    
    if response.status_code == 200:
        json: dict = response.json().get("data").get("organizations")
        return json
    else:
        return {"error": response.text, "status_code": response.status_code}


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
    
    response = send_request(query)
    
    if response.status_code == 200:
        json = response.json()
        title = json.get("data").get("title")
        return title
    else:
        return {"error": json.text, "status_code": json.status_code}


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
    
    response = send_request(query)
    
    if response.status_code == 200:
        json = response.json()
        titles = json.get("data").get("titles")
        return titles
    else:
        return {"error": json.text, "status_code": json.status_code}
    
    
    
@router.get('/get_orgs')
async def get_orgs(search: str):
    query = f"""
    query getOrginizations {{
        organizations(first: 2, filter: {{ name: {{ contains: {search} }} }}) {{
            edges {{
                node {{
                    id
                    name
                    private
                    teams {{
                        colorPrimary
                        colorSecondary
                        id
                        logoUrl
                        name
                        nameShortened
                        titles {{
                            id
                            name
                            nameShortened
                            private
                        }}
                    }}
                }}
            }}
            pageInfo {{
                endCursor
                hasNextPage
                hasPreviousPage
                startCursor
            }}
            totalCount
        }}
    }}
    """
    
    response = send_request(query)
    
    if response.status_code == 200:
        json = response.json()
        titles = json.get("data")
        return titles
    else:
        return {"error": json.text, "status_code": json.status_code}
    
    

@router.get('/get_team')
async def get_team(titleId: str, orgId: str):
    query = f"""
    query getTeams {{
        teams(first: 1, filter: {{titleId: {titleId}, organizationId: {orgId}}}) {{
            edges {{
                node {{
                    id
                    colorPrimary
                    colorSecondary
                    externalLinks {{
                        dataProvider {{
                            description
                            name
                        }}
                        externalEntity {{
                            id
                        }}
                    }}
                    logoUrl
                    name
                    nameShortened
                    organization {{
                        id
                        name
                    }}
                    private
                    title {{
                        id
                        name
                        nameShortened
                        private
                    }}
                }}
            }}
        }}
    }}
    """
    
    response = send_request(query)
    
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