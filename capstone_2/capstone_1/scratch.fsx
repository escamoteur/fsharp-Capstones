#load "Model.fs"
#load "actions.fs"

open actions
open Model

let account = {userId = 1; accountId = 2; balance = 40}

let newAccount =  withDraw( account, 10 )

