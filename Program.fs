
module Program

open Matrices

[<EntryPoint>]
let main args =
    let m1 = new Matrix(3, 2)

    let result =m1.setMatrix [1.0; 2.0; 3.0; 4.0; 5.0; 6.0]

    printfn "Setting matrix values resulted in a success: %b" result
    printfn "Printing matrix..."

    m1.printMatrix()
    0
    