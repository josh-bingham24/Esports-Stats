from fastapi import FastAPI
from decouple import config
from .routers import central_data_feed, live_data_feed, stats_feed

app = FastAPI()

app.include_router(central_data_feed.router)
app.include_router(live_data_feed.router)
app.include_router(stats_feed.router)
