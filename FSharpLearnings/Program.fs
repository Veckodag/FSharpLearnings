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

//type emotion = 
//| joy = 0
//| fear = 1
//| anger = 2

//let enum_stuff() = 
//    let my_feeling = emotion.joy

//    let current_emotion = match my_feeling with
    //| emotion.joy ->"I'm joyful"
    //| emotion.fear -> "I'm fearful"
    //| emotion.anger -> "I'm angry"
    //| _ -> "I'm emotionless"

//    printfn "%s" current_emotion

//enum_stuff()

//let option_stuff() = 
//    let number_1 = 6
//    let number_2 = 2
//    let divide x y =
//        match y with
//        | 0 -> None
//        | _ -> Some(x/y)

//    if (divide number_1 number_2).IsSome then
//        printfn "%i / %i = %A" number_1 number_2 ((divide number_1 number_2).Value)
//    elif (divide number_1 number_2).IsNone then
//        printfn "Can't divide by zero"
//    else
//        printfn "Something happened!"

//option_stuff()

//let tuple_stuff() = 
//    let avg (w, x, y, z) : float =
//        let sum = w + x + y + z
//        sum / 4.0
     
//    printfn "Avg : %f" (avg (1.0, 2.0, 3.0, 4.0))

//    let my_data = ("Fredrik", 29, 6.0)

//    let (name, age, _) = my_data

//    printfn "Name & age : %s & %i" name age     

//tuple_stuff()

//type Customer =
//    { 
//        Name : string
//        Balance : float
//    }

//let record_stuff() =
    
//    let bob = { Name = "Bob Smith"; Balance = 101.508}
//    printfn "%s owes us %.2f" bob.Name bob.Balance

//record_stuff()

//let seq_stuff() =

//    let seq1 = seq { 1 .. 50 }
//    let seq2 = seq { 0 .. 2 .. 50 }
//    let seq3 = seq { 50 .. 1 }

//    printfn "%A" seq2

//    //Seq.toList seq2 |> List.iter (printfn "Num : %i")

//    let is_prime n = 
//        let rec check i = 
//            i > n/2 || (n % i <> 0 && check (i + 1))
//        check 2

//    let prime_seq = seq { for n in 1 .. 500 do if is_prime n then yield n }

//    printfn "%A" prime_seq
//    Seq.toList prime_seq |> List.iter (printfn "Prime : %i")

//seq_stuff()

//let map_stuff() = 
//    let customers = 
//        Map.empty
//            .Add("Bob Smith", 101.50)
//            .Add("Sally Marks", 50.75)

//    printfn "# of customers %i" customers.Count

//    let cust = customers.TryFind "Bob Smith"

//    match cust with
//    | Some x -> printfn "Balance : %.2f" x
//    | None -> printfn "Not Found"

//    printfn "Customer : %A" customers

//    if customers.ContainsKey "Bob Smith" then
//        printfn "Bob Smith was found"

//    printfn "Bobs balance : %.2f" customers.["Bob Smith"]

//    let custs2 = Map.remove "Sally Marks" customers

//    printfn "# of Customers %i" custs2.Count

//map_stuff()

//let add_stuff<'T> x y = 
//    printfn "%A" (x + y)

//let generic_stuff() = 
//    //add_stuff<float> 5.5 2.4
//    add_stuff<int> 17 4

//generic_stuff()

//let exp_stuff() =
//    let divide x y = 
//        try
//            if y = 0 then raise(DivideByZeroException "Can't Divide by 0")
//            else
//                printfn "%i / %i = %i" x y (x / y)
//        with
//            | :? System.DivideByZeroException as ex
//                -> printfn "Can't divide by zero"

//    divide 5 0

//exp_stuff()

//type Rectangle = struct
//    val Length : float
//    val Width : float

//    new (length, width) =
//        { 
//            Length = length; 
//            Width = width 
//        }
//end

//let struct_stuff() =
//    let area(shape: Rectangle) = 
//        shape.Length * shape.Width

//    let rect = new Rectangle(5.0, 6.0)

//    let rect_area = area rect

//    printfn "Area : %.2f" rect_area

//struct_stuff()

type Animal = class
    val Name : string
    val Height : float
    val Weight : float

    new (name, height, weight) =
        { Name = name; Height = height; Weight = weight; }

    member x.Run =
        printfn "%s Runs" x.Name

end

type Dog(name, height, weight) =
    inherit Animal(name, height, weight)

    member x.Bark = 
        printfn "%s Barks" x.Name

let class_stuff() =

    let dogge = new Animal("Spot", 20.5, 40.5)
    dogge.Run

    let mini = new Dog("Mini", 13.5, 25.5)
    mini.Run
    mini.Bark

class_stuff()


Console.ReadKey () |> ignore
    

//module HelloSquare

//let square x = x * x;

//[<EntryPoint>]
//let main argv = 
//    printf "%d squared is: %d!" 12 (square 12)
//    0
