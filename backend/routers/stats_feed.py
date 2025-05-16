from decouple import config
from fastapi import APIRouter
from fastapi.responses import JSONResponse
import requests


router = APIRouter(
    prefix="/stats_feed"
)


api_key = config('x-api-key')