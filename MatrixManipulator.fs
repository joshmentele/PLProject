namespace Matrices

type MatrixManipulator =

    static member Add(left: Matrix, right: Matrix) : Matrix =
        if left.Rows <> right.Rows || left.Cols <> right.Cols then
            raise (invalidOp "The dimensions of the two matrices did not match, so they cannot be added")

        // store result
        let result = new Matrix(left.Rows, left.Cols)

        // add matrix values
        for i = 0 to left.Rows - 1 do
            for j = 0 to left.Cols - 1 do
                result.Values[i, j] <- left.Values[i, j] + right.Values[i, j]
                
        // return result
        result