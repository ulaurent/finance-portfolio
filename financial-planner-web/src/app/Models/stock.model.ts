import { Results } from "./stock.results.model";

export class Stock implements IStock{
    public ticker: string;
    public queryCount: number;
    public resultsCount: number;
    public adjusted: boolean;
    public results: Results[];
    public status: string;
    public request_Id: string;
    public count: number;

    constructor(ticker: string, 
        queryCount: number, 
        resultsCount: number,
        adjusted: boolean,
        results: Results[],
        status: string,
        request_Id: string, 
        count: number){
            this.ticker = ticker
            this.queryCount = queryCount
            this.request_Id = request_Id
            this.resultsCount = resultsCount
            this.adjusted = adjusted
            this.status = status
            this.count = count
            this.results = results
        }
}

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