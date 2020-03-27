// Learn more about F# at http://fsharp.org

open System
open Model
open actions


let rec Transaction( lastResult ) =
    let account = 
        match lastResult with
        | Valid newAccount -> newAccount
        | Invalid oldAccount ->
            printfn("Not enough money")
            oldAccount

    printfn "Your current balance is %M" account.Balance
    
    printfn "Select Deposit: (d) or withdraw: (w) or exit:(x) "
    let action = Console.ReadLine()

    if action = "x" then Environment.Exit 0

    printfn("Please enter the amount:")
    let amount = Console.ReadLine() |> Decimal.Parse
    

    let result =
        if action = "d"  then 
            deposit(logger.console, account, amount) 
        else if action = "w" then 
            withDraw(logger.console, account, amount) 
        else
            Valid(account)

    Transaction(result)


[<EntryPoint>]
let main argv =
    let account =
        let customer =
            printfn "Please enter a customer Name:"
            let name = Console.ReadLine()
            {Id=42; Name = name}
        let balance = 
            printfn("Please enter opening balance:")
            Console.ReadLine() |> Decimal.Parse
        {
          Owner= customer 
          AccountId =4711 
          Balance = balance
        }

    Transaction(Valid(account))        
    0 // return an integer exit code
