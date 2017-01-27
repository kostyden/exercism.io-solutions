module HelloWorld

let hello (arg : string option) : string = 
    let name = defaultArg arg "World"
    sprintf "Hello, %s!" name

