import { Results } from "./stock.results.model"

interface IStock{
    ticker : string
    queryCount : number
    resultsCount : number
    adjusted : boolean
    results : Results[]
    status : string
    request_Id : string
    count : number
}