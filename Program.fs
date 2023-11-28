
module Program

open Matrices

[<EntryPoint>]
let main args =
    let m1 = new Matrix(3, 2)
    let m2 = new Matrix(3, 2)

    m1.SetMatrix [1.0; 2.0; 3.0; 4.0; 5.0; 6.0]
    m2.SetMatrix [2.0; 3.0; 4.0; 5.0; 6.0; 7.0]

    printfn "Printing added matrix..."

    Matrix.Add(m1, m2).PrintMatrix()
    0
    