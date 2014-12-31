'use strict';

registrationModule.factory('instructorRepository',
    function($resource) {
        return {
            get: function() {                
                return $resource('/api/instructors').query();
            }
        }
    });