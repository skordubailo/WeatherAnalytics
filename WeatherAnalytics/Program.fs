module MainModule

open System
open System.Net

let myCallback (reader:IO.StreamReader) url = 
    let html = reader.ReadToEnd()
    let html1000 = html.Substring(0,1000)
    printfn "Downloaded %s. First 1000 is %s" url html1000
    html      // return all the html

[<EntryPoint>]
let main argv =
    let url = "https://en.wikipedia.org/wiki/Application_programming_interface"
    let result = WeatherApi.fetchUrl myCallback  url
    0 // return an integer exit code