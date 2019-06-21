const PI = 3.14159;

//const functions
const hello = () => {
    console.log("Hello World!");
}
const howdy = name =>{
    console.log(`Howdy ${name}`);
}
hello();
howdy("dingus");

//Back ticks
const whatever = `This
is 
so 
very very very 
cool`;
console.log(whatever);

//Let
let definePerson = (name, age) => ({name, age});
let bob = definePerson("bob", 20);
console.log(bob);

let people = [
    {name: 'Bob', age: 10},
    {name: 'Hey', age: 22},
    {name: 'Beater', age: 49},
    {name: 'EggBeater', age: 2},
];

let ages = people.map( person => person.name);

console.log(ages);

