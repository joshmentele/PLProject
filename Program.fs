
module Program

open Matrices
open Manager

[<EntryPoint>]
let main args =
    let manager = MatrixManager

    let menu: string = ("1.) Create Matrix\n" + 
                        "2.) Print Matrix\n" + 
                        "3.) List Matrices\n" +
                        "4.) Add Matrices\n" +
                        "5.) Multiply Matrices\n" +
                        "6.) Multiply Matrix by Scalar")

    0
    