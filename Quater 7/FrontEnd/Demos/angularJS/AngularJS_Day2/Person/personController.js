myApp.controller('personController',$scope => {
    $scope.person = {
        name: "Bill",
        species: "dolphin",
        fullName: () => {
            let personObject;
            personObject = $scope.person;
            return `${personObject.name} the ${personObject.species}`;
        }

    };
});