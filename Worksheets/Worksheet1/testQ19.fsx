#load "Q19.fs"

open Q19

printfn "%A" (insertElement [0; 1; 3; 4] 2 2)
System.Console.ReadLine() // prevent the program from terminating

printfn "%A" (insertList [0; 2; 4; 16] [8] 3)
System.Console.ReadLine() // prevent the program from terminating
