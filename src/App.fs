module App
open Browser.Dom

let mutable count = 0

let incButton = document.getElementById "inc"
let decButton = document.getElementById "dec"
let textCount = document.getElementById "textCount" 

incButton.addEventListener
    ("click", 
    fun _ -> count <- count + 1; textCount.innerHTML <- (string count) )

decButton.addEventListener
    ("click", 
    fun _ -> count <- count - 1; textCount.innerHTML <- (string count) )