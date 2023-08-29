namespace MobileCounter.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open MobileCounter
open System

[<ApiController>]
[<Route("[controller]")>]
type CounterController(logger : ILogger<CounterController>) =
    inherit ControllerBase()

    static let counter =
        { Date = DateTime.Now
          Count = 0 }

    [<HttpPost("/counter/update/{value}")>]
    member this.Post(value) : IActionResult =
        counter.Update value
        (this.Ok counter) :> IActionResult

    [<HttpGet>]
    member this.Get() : IActionResult =
        (this.Ok counter) :> IActionResult