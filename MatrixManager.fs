module Manager

open Matrices

type MatrixManager() =
    let mutable matrices = Array.create<Matrix>