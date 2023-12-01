module Manager

open System
open Matrices

type MatrixManager() =
    // holds list of matrices
    let mutable matrices : Matrix array = [||]

    member this.PrintMatrices() =
        // loop through matrices, print out to screen
        for i = 0 to (Array.length matrices) do
            printfn "Matrix #%d; Rows: %d, Cols: %d\n%s\n" i matrices[i].Rows matrices[i].Cols (matrices[i].ToString())
            

    member this.AddMatrices(idx1: int, idx2: int): Matrix = 
        
        // check that the two matrices exist
        if (Array.length matrices) <= idx1 || (Array.length matrices) <= idx2 then
            raise (System.InvalidOperationException "s")

        // perform operation
        let result = MatrixCalculator.Add(matrices[idx1], matrices[idx2])

        // store result
        matrices <- Array.append matrices [|result|]

        // return result
        result
