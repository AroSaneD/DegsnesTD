namespace TDLibrary

open UnityEngine

type public Class1() = 
    member this.X = "F#"
    member this.GetFive() = 5


type public TowerHelper() =
    static member public GetInRangeTurrets(startingPosition : Vector3, range : float32, gameObjects : GameObject[]) = 
        5