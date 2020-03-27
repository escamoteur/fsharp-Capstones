module Model

type Customer = {
    Id : int
    Name : string
}

type BankAccount = {
    Owner : Customer
    AccountId : int
    Balance : decimal
}

type TransActionResult =
    | Valid of newAccount: BankAccount
    | Invalid of oldAccount: BankAccount