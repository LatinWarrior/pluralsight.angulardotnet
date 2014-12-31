'use strict';

registrationModule.controller('CoursesController',
    function($scope, courseRepository) {
        courseRepository.get().then(function(courses) { $scope.courses = courses; }, function() { console.log("failure of instructor retrieval."); });
    });