var mongo = require('mongodb').MongoClient;
const url = 'mongodb://localhost:27017'
var name =      document.getElementById('name').value;
var age =       document.getElementById('age').value;
var breed =     document.getElementById('breed').value;
var location =  document.getElementById('location').value;
var images =    document.getElementById('images').value;
var bio =       document.getElementById('bio').value;
var gender =    document.getElemntById('gender').value;
var shots =     document.getElementById('shots').value;
var purebreed = document.getElementById('purebreed').value;

mongo.connect(url, (err, client) => {
    if (err) {
        console.error(err)
        return
    }

    const db = client.db('BumFizzle');

    const collection = db.collection('Dogs');

    collection.insertOne({ name: name, Age: age, Breed: breed, Location: location, Images: images, Bio: bio, Gender: gender, Shots: shots, Purebreed: purebreed },
        (err, result) => {

        });

    collection.find().toArray((err, items) => {
        console.log(items)
    });


    client.close();

});


