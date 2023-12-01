
module Program

open Matrices
open Manager
open System

[<EntryPoint>]
let main args =
    let manager = MatrixManager

    let menu: string = ("1.) Create Matrix\n" + 
                        "2.) Print Matrix\n" + 
                        "3.) List Matrices\n" +
                        "4.) Add Matrices\n" +
                        "5.) Multiply Matrices\n" +
                        "6.) Multiply Matrix by Scalar\n" +
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
            | _ -> printfn "Please select a valid menu option.\n"

    0
    