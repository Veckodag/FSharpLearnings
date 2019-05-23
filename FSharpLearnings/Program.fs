//// Learn more about F# at http://fsharp.org

open System
//https://www.youtube.com/watch?v=c7eNDJN758U

//let bind_stuff() = 
//    let mutable weight = 175
//    weight <- 170

//    printfn "Weight : %i" weight

//    let change_me = ref 10
//    change_me := 50

//    printfn "Change : %i" ! change_me

//bind_stuff()

//let do_funcs() = 
    
//    let get_sum (x : int, y : int) : int = x + y

//    printfn "5 + 7 = %i" (get_sum(5,7))

//do_funcs()

//let rec_func() = 

//    let rec factorial x = 
//        if x < 1 then 1
//        else x * factorial (x - 1)

//    printfn "Factorial 4 : %i" (factorial 4)

//rec_func()


//let lambda_func() =

//    let rand_list = [1;2;3]

//    let rand_list2 = List.map (fun x -> x * 2) rand_list

//    printfn "Double List : %A" rand_list2

//    [5;6;7;8]
//    |> List.filter (fun v -> (v % 2) = 0)
//    |> List.map (fun x -> x * 2)
//    |> printfn "Even Doubles : %A"
    
//    let mult_num x = x * 3
//    let add_num y = y + 5

//    let mult_add = mult_num >> add_num
//    let add_mult = mult_num << add_num

//    printfn "mult_add : %i" (mult_add 10)
//    printfn "add_mult : %i" (add_mult 10)

//lambda_func()

//let do_math()  = 
//    printfn "5 + 4 = %i" (5 + 4)
//    printfn "5 - 4 = %i" (5 - 4)
//    printfn "5 * 4 = %i" (5 * 4)
//    printfn "5 / 4 = %i" (5 / 4)
//    printfn "5 %% 4 = %i" (5 % 4)
//    printfn "5 ** 2 = %.1f" (5.0 ** 2.0)

//    let number = 2

//    printfn "Type : %A" (number.GetType())

//    printfn "A Float : %.2f" (float number)
//    printfn "An Int : %i" (int 3.14)

//    printfn "abs 4.5 : %i" (abs -1)
//    printfn "ceil 4.5 : %f" (ceil 4.5)
//    printfn "floor 4.5 : %f" (floor 4.5)
//    printfn "log 2.71828 : %f" (log 2.71828)
//    printfn "log10 1000 : %f" (log 1000.0)
//    printfn "sqrt 25 : %f" (log 25.0)

//do_math()

let string_stuff() = 

    let str1 = "This is an ordinary string!"
    let str2 = @"Verbatim sting, ignores backslashes \ \\"
    let str3 = """ "I Ignore double quoutes " and backslashes \ \\" """

    let str4 = str1 + " " + str2    

    printfn "Length : %i" (String.length str4)
    printfn "%c" str3.[4]
    printfn "1st word : %s" (str2.[0..7])

string_stuff()

Console.ReadKey () |> ignore
    

//module HelloSquare

//let square x = x * x;

//[<EntryPoint>]
//let main argv = 
//    printf "%d squared is: %d!" 12 (square 12)
//    0
