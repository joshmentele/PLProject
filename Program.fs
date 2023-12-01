
module Program

open Matrices
open Manager
open System


let printMatrix() = 
    printf "Enter the matrix index:> "

    // get input


let addMatrices(manager: MatrixManager) : unit =
    printf "Enter the first matrix index:> "

    try
        // get input
        let idx1 = System.Int32.Parse(Console.ReadLine().Trim())

        printf "Enter the second matrix index:> "

        // get input
        let idx2 = System.Int32.Parse(Console.ReadLine().Trim())

        printfn "%s" (manager.AddMatrices(idx1, idx2).ToString())
    with
    | :? FormatException -> printfn "Please input a valid integer"
    | :? InvalidOperationException as ex -> printfn "%s" ex.Message


[<EntryPoint>]
let main args =
    let manager = new MatrixManager()

    let menu: string = ("1.) Create Matrix\n" + 
                        "2.) Print Matrix\n" + 
                        "3.) List Matrices\n" +
                        "4.) Add Matrices\n" +
                        "5.) Subtract Matrices\n" +
                        "6.) Multiply Matrices\n" +
                        "7.) Multiply Matrix by Scalar\n" +
                        "0.) Quit\n" +
                        "Enter Selection:> ")

    // holds selection
    let mutable selection = -1

    while selection <> 0 do
        // print menu
        printf "%s" menu


        // get selection
        let input = Console.ReadLine().Trim()

        let (success, i) = System.Int32.TryParse input
        selection <- i

        if not success then
            printfn "Please select a valid menu options.\n"
        else
            match selection with
            | 0 -> printfn "Exiting..."
            | 1 -> printMatrix()
            | 2 -> manager.PrintMatrices()
            | _ -> printfn "Please select a valid menu option.\n"

    0
    