module Matrices
    
    type Matrix(rows : int, cols : int) =
        do printfn "Initializing Matrix with %d rows and %d columns" rows cols
        let mutable values = Array2D.create<double> rows cols 0.0
        member private this.rows = rows
        member private this.cols = cols

        // public property to get values
        member this.Values
            with get() = values


        static member Add(left: Matrix, right: Matrix) : Matrix =
            if left.rows <> right.rows || left.cols <> right.cols then
                raise (invalidOp "The dimensions of the two matrices did not match, so they cannot be added")

            // store result
            let result = new Matrix(left.rows, left.cols)

            // add matrix values
            for i = 0 to left.rows do
                for j = 0 to left.cols do
                    result.Values[i, j] <- left.Values[i, j] + right.Values[i, j]

            // return result
            result


        /// <summary>
        /// Author: Josh Mentele
        /// Description: Sets the values of the matrix (here we use a 1D list to fill)
        /// </summary>
        /// <param name="valuesIn">The values to store in the matrix</param>
        /// <returns>True if successful, false otherwise</returns>
        member this.SetMatrix(valuesIn : list<double>) : bool =
            if values.Length <> this.rows * this.cols then
                false
            else
                for i = 0 to rows - 1 do
                    for j = 0 to cols - 1 do
                        values.[i, j] <- valuesIn.[i * cols + j]
                true
        
        /// <summary>
        /// Author: Josh Mentele
        /// Description: Prints the matrix to the console.
        /// </summary>
        member this.PrintMatrix() =
            // loop rows
            for i = 0 to rows - 1 do
                printf "Row %d: " i
                // loop columns
                for j = 0 to cols - 1 do
                    printf "%f " values.[i, j]
                printfn ""

