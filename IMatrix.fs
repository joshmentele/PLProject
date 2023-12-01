namespace Matrices

type IMatrix =
    abstract member SetValues: valuesIn : list<double> -> bool
    abstract member ToString: unit -> string
    abstract member Add: m: IMatrix -> unit
    abstract member ScalarMultiply: c: double -> unit
    abstract member Multiply: m: IMatrix -> unit
    abstract member Values : double array2d