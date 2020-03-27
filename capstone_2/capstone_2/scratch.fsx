#load "Model.fs"
#load "actions.fs"

open actions
open Model

let account = {userId = 1; accountId = 2; balance = 40}

let newAccount =  deposit( account, 60 )

printfn "%A" newAccount