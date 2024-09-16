from fastapi import FastAPI, HTTPException, status
import uvicorn
from pydantic import BaseModel
import json
import os

app = FastAPI()

@app.get("/api/healthcheck", status_code=status.HTTP_200_OK)
def healthcheck():
    return {"message": "Server is connected"}

@app.get("/api/doughnuts/{max_calories}/{contains_nuts}", status_code=status.HTTP_200_OK)
def filter_doughnuts(max_calories: int, contains_nuts: bool):
    max_calories = max_calories
    contains_nuts = contains_nuts

    file_path = os.path.normpath(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..','data/doughnuts.json'))
    json_file = open(file_path)
    str = json_file.read()
    doughnuts_list = json.loads(str)["doughnut_data"]

    result_list = []

    if contains_nuts:
        for dict in doughnuts_list:
            if dict["calories"] < max_calories:
                short_dict = { "doughnut_type": dict["doughnut_type"], "price": dict["price"]}
                result_list.append(short_dict)
    else:
        for dict in doughnuts_list:
            if dict["calories"] < max_calories and dict["contains_nuts"] == False:
                short_dict = { "doughnut_type": dict["doughnut_type"], "price": dict["price"]}
                result_list.append(short_dict)
    
    if len(result_list) == 0:
            raise HTTPException(status_code=status.HTTP_204_NO_CONTENT)

    return { "results": result_list }



if __name__ == "__main__":
    uvicorn.run(app='__main__:app', host='localhost', port=8888, reload=True)