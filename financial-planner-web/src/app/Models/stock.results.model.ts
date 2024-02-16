export class Results implements IResults {
    public c : number
    public h : number
    public l : number
    public n : number
    public o : number
    public t : number
    public vw : number
    public v : number

    constructor(close : number, 
        high : number,
        low : number, 
        numOfTransactions: number, 
        open : number,
        timeStamp: number,
        volume: number,
        volumeWeighted: number){
            this.c = close
            this.h = high
            this.l = low
            this.n = numOfTransactions
            this.o = open
            this.t = timeStamp
            this.v = volume
            this.vw = volumeWeighted
        }
}

interface IResults{
    c : number
    h : number
    l : number
    n : number
    o : number
    t : number
    vw : number
    v : number
}