#load "T1.fsx"

open T1

let testT1 x =
    let inp = (3,50000)
    let result =  [[68000; 68000; 68000]; [68000; 68000; 100000]; [68000; 68000; 150000];
                   [68000; 68000; 220000]; [68000; 68000; 330000]; [68000; 68000; 470000];
                   [68000; 68000; 680000]; [68000; 100000; 100000]; [68000; 100000; 150000];
                   [68000; 100000; 220000]; [68000; 100000; 330000]; [68000; 100000; 470000];
                   [68000; 100000; 680000]; [68000; 150000; 150000]; [68000; 150000; 220000];
                   [68000; 150000; 330000]; [68000; 150000; 470000]; [68000; 150000; 680000];
                   [68000; 220000; 220000]; [68000; 220000; 330000]; [68000; 220000; 470000];
                   [68000; 220000; 680000]; [68000; 330000; 330000]; [68000; 330000; 470000];
                   [68000; 330000; 680000]; [68000; 470000; 470000]; [68000; 470000; 680000];
                   [68000; 680000; 680000]; [100000; 100000; 100000]; [100000;100000; 150000];
                   [100000; 100000; 220000]; [100000; 100000; 330000];
                   [100000; 100000; 470000]; [100000; 100000; 680000];
                   [100000; 150000; 150000]; [100000; 150000; 220000];
                   [100000; 150000; 330000]; [100000; 150000; 470000];
                   [100000; 150000; 680000]; [100000; 220000; 220000];
                   [100000; 220000; 330000]; [100000; 220000; 470000];
                   [100000; 220000; 680000]; [100000; 330000; 330000];
                   [100000; 330000; 470000]; [100000; 330000; 680000];
                   [100000; 470000; 470000]; [100000; 470000; 680000];
                   [100000; 680000; 680000]; [150000; 150000; 150000];
                   [150000; 150000; 220000]; [150000; 150000; 330000];
                   [150000; 150000; 470000]; [150000; 150000; 680000];
                   [150000; 220000; 220000]; [150000; 220000; 330000];
                   [150000; 220000; 470000]; [150000; 220000; 680000];
                   [150000; 330000; 330000]; [150000; 330000; 470000];
                   [150000; 330000; 680000]; [150000; 470000; 470000];
                   [150000; 470000; 680000]; [150000; 680000; 680000];
                   [220000; 220000; 220000]; [220000; 220000; 330000];
                   [220000; 220000; 470000]; [220000; 220000; 680000];
                   [220000; 330000; 330000]; [220000; 330000; 470000];
                   [220000; 330000; 680000]; [220000; 470000; 470000];
                   [220000; 470000; 680000]; [220000; 680000; 680000];
                   [330000; 330000; 330000]; [330000; 330000; 470000];
                   [330000; 330000; 680000]; [330000; 470000; 470000];
                   [330000; 470000; 680000]; [330000; 680000; 680000];
                   [470000; 470000; 470000]; [470000; 470000; 680000];
                   [470000; 680000; 680000]; [680000; 680000; 680000]]
    let zz = x inp
    if zz = result then printfn "Test Passed" else 
        printfn "Test Failed:\nInput = %A\nCorrect output=%A\nActual output=%A" inp result zz
testT1 fRes
//System.Console.ReadLine() // prevent the program from terminating
