namespace MobileCounter

open System

type DailyCounter =
    { Date: DateTime
      mutable Count: int }

    member this.Update(value) =
        this.Count <- this.Count + value