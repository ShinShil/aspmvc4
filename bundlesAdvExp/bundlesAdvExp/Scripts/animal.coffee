class Animal:
    say ->
        console.log('OOO')

($document).ready -> 
    a = new Animal
    a.say()