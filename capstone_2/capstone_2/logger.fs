module logger

open Model


open System.IO

/// Logs to the console
let console (account, message, amount) = printfn "Account %O: %s %M" account.AccountId message amount

/// Logs to the file system
let fileSystem (account, message) =
    Directory.CreateDirectory(sprintf @"C:\temp\learnfsharp\lesson14\%s" account.Owner.Name) |> ignore
    let filePath = sprintf @"C:\temp\learnfsharp\lesson14\%s\%O.txt" account.Owner.Name account.AccountId
    File.AppendAllLines(filePath, [ message ])