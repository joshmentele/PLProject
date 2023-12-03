namespace Matrices

type MatrixCalculator =

    /// <summary>
    /// Author: Josh Mentele
    /// Description: This function adds two matrices together, returning the result. If the dimensions of the two matrices
    /// do not match, an exception is thrown.
    /// </summary>
    /// <param name="left">The first matrix to add.</param>
    /// <param name="right">The second matrix to add.</param>
    /// <returns>The resulting matrix.</returns>
    static member Add(left: Matrix, right: Matrix) : Matrix =
        if left.Rows <> right.Rows || left.Cols <> right.Cols then
            raise (System.InvalidOperationException "The dimensions of the two matrices did not match, so they cannot be added")

        // store result
        let result = new Matrix(left.Rows, left.Cols)

        // add matrix values
        for i = 0 to left.Rows - 1 do
            for j = 0 to left.Cols - 1 do
                result.Values[i, j] <- left.Values[i, j] + right.Values[i, j]
                
        // return result
        result