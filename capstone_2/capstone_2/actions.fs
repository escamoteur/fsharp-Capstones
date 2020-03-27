module actions

open Model
 

let withDraw (logger, account, amount ) : TransActionResult =
    if (account.Balance - amount) > decimal(0) then 
        let account = { account with Balance = account.Balance - amount}
        logger(account, "Withdraw", amount)
        Valid(account)
    else
        Invalid(account)

let deposit (logger, account, amount ) : TransActionResult =
    let account = { account with Balance = account.Balance + amount}
    logger(account, "deposit", amount) 
    Valid(account)