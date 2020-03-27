module Model

type User = {
    id : int
    name : string
}

type BankAccount = {
    userId : int
    accountId : int
    balance : int
}