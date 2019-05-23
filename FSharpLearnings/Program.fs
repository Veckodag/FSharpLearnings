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

//let string_stuff() = 

//    let str1 = "This is an ordinary string!"
//    let str2 = @"Verbatim sting, ignores backslashes \ \\"
//    let str3 = """ "I Ignore double quoutes " and backslashes \ \\" """

//    let str4 = str1 + " " + str2    

//    printfn "Length : %i" (String.length str4)
//    printfn "%c" str3.[4]
//    printfn "1st word : %s" (str2.[0..7])

//    let upper_str = String.collect (fun c -> sprintf"%c, " c) "commas"
//    printfn "Commas : %s" upper_str
//    printfn "Any upper : %b" (String.exists (fun c -> Char.IsUpper(c)) str2)
//    printfn "Number : %b" (String.forall (fun c -> Char.IsDigit(c)) "1234")

//    let string1 = String.init 10 (fun i -> i.ToString())
//    printfn "More Numbers : %s" string1

//    String.iter(fun c -> printfn "%c" c) "Print Me!"

//string_stuff()

//let loop_stuff() =
//    let magic_num = "7"
//    let mutable guess = ""

//    while not (magic_num.Equals(guess)) do
//        printf "Guess the number : "
//        guess <- Console.ReadLine()

//    printfn "You guessed the Magic Number!"

//loop_stuff()

//let more_loops() = 
//    for i = 1 to 10 do 
//        printfn "Up : %i" i

//    for i = 10 downto 1 do
//        printfn "Down : %i" i

//    for i in [1..10] do
//        printfn "Range : %i" i

//    [1..10] |> List.iter (printfn "Num : %i")

//    let sum = List.reduce (+) [1..10]
//    printfn "Sum : %i" sum

//more_loops()

//let cond_stuff() = 
//    let age = 8

//    if age < 5 then
//        printfn "Preschool"
//    elif age = 5 then
//        printfn "Kindergarten"
//    elif (age > 5) && (age <= 18) then
//        let grade = age - 5
//        printfn "Go to Grade %i" grade
//    else 
//        printfn "Go to College"

//    let gpa = 3.9
//    let income = 15000

//    printfn "College Grant : %b" ((gpa >= 3.8) || (income <= 12000))
//    printfn "Not True : %b" (not true)

//    let grade2: string = 
//        match age with
//        | age when age < 5 -> "Preschool"
//        | 5 -> "Kindergarten"
//        | age when (age > 5) && (age <= 18) -> (age - 5).ToString()
//        | _ -> "College"

//    printfn "Grade2 : %s" grade2    

//cond_stuff()

//let list_stuff() = 
//    let list1 = [1;2;3;4]

//    list1 |> List.iter (printfn "Num : %i")
//    printfn "%A" list1

//    let list2 = 5::6::7::[]
//    printfn "%A" list2

//    let list3 = [3..6]
//    let list4 = ['a'..'g']
//    printfn "%A" list4

//    let list5 = List.init 5 (fun i -> i * 2)
//    printfn "%A" list5

//    printfn "COOL STUFF BELOW!"
//    let list6 = [ for a in 1..5 do yield (a * a) ]
//    printfn "%A" list6
//    let list7 = [ for a in 1..20 do if a % 2 = 0 then yield a ]
//    printfn "%A" list7
//    let list8 = [ for a in 1..3 do yield! [a .. a + 2]]
//    printfn "%A" list8

//    printfn "Length : %i" list8.Length
//    printfn "Empty : %b" list8.IsEmpty
//    printfn "At index : %c" (list4.Item(2))
//    printfn "Head : %c" (list4.Head)
//    printfn "Tail : %A" (list4.Tail)

//    let list9 = list3 |> List.filter (fun x -> x % 2 = 0)

//    let list10 = list9 |> List.map (fun x -> (x * x))

//    printfn "Filtered : %A" list9
//    printfn "Mapped: %A" list10
//    printfn "Sorted : %A" (List.sort [1;5;4;3;2])
//    printfn "Sum : %i" (List.fold (fun sum elem -> sum + elem) 0 [1;2;3])

//list_stuff()

type emotion = 
| joy = 0
| fear = 1
| anger = 2

let enum_stuff() = 
    let my_feeling = emotion.joy

    let current_emotion = match my_feeling with
    | emotion.joy ->"I'm joyful"
    | emotion.fear -> "I'm fearful"
    | emotion.anger -> "I'm angry"
    | _ -> "I'm emotionless"

    printfn "%s" current_emotion

enum_stuff()

Console.ReadKey () |> ignore
    

//module HelloSquare

//let square x = x * x;

//[<EntryPoint>]
//let main argv = 
//    printf "%d squared is: %d!" 12 (square 12)
//    0
