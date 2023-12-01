namespace Matrices
    
type Matrix(rows : int, cols : int) =
    // holds matrix values
    let mutable values = Array2D.create<double> rows cols 0.0
    member private this.rows = rows
    member private this.cols = cols


    /// <summary>
    /// Author: Josh Mentele
    /// Description: Sets the values of the matrix (here we use a 1D list to fill)
    /// </summary>
    /// <param name="valuesIn">The values to store in the matrix</param>
    /// <returns>True if successful, false otherwise</returns>
    member this.SetValues(valuesIn : list<double>) : bool =
        if values.Length <> this.rows * this.cols then
            false
        else
            for i = 0 to rows - 1 do
                for j = 0 to cols - 1 do
                    values.[i, j] <- valuesIn.[i * cols + j]
            true

    /// <summary>
    /// Author: Josh Mentele
    /// Description: Prints the matrix to a string.</summary>
    /// <param name="unit"></param>
    /// <returns>The matrix string representation</returns>
    override this.ToString() =
        let mutable result = ""
        // loop rows
        for i = 0 to rows - 1 do
            result <- $"| {result}"
            // loop columns
            for j = 0 to cols - 1 do
                result <- $"{values.[i, j] }"
            result <- $"{result}|\n"
        result
    
    // public property to get values
    member this.Values
        with get() = values
    
    
    // public property to get rows
    member this.Rows
        with get() = rows

    // public property to get columns
    member this.Cols
        with get() = cols