'use strict';

var registrationModule = angular.module('registrationModule', ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        console.log($routeProvider);   
        $routeProvider.when('/Registration/Courses', { templateUrl: '/Templates/courses.html', controller: 'CoursesController' });
        $routeProvider.when('/Registration/Instructors', { templateUrl: '/Templates/instructors.html', controller: 'InstructorsController' });
        $routeProvider.when('/Registration/CreateAccount', { templateUrl: '/Templates/create-account.html', controller: 'AccountController' });
        $locationProvider.html5Mode(true);
    });