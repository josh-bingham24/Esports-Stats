from decouple import config
from fastapi import APIRouter
from fastapi.responses import JSONResponse
import requests


router = APIRouter(
    prefix="/live_data_feed"
)


api_key = config('x-api-key')