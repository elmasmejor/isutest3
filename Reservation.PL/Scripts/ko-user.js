/// <reference path="jquery-1.10.2.js"/>
/// <reference path="knockout-2.2.0.debug.js"/>

var viewModel = {
    id: 0,
    name: '',
    type: '',
    phone: '',
    dob: '',
    description: 'note',
    UserTypeId: 0
};

var User = {
    BindUIwithViewModel: function (viewModel) {
        ko.applyBindings(viewModel);
    },

    RegisterUIEventHandlers: function () {
        $('#saveuser').click(function (e) {
            //console.log(viewModel);
            // Check whether the form is valid. Only HTML5
            if (document.forms[0].checkValidity()) {
                e.preventDefault();
                viewModel.UserTypeId = $('#user_type').val();
                viewModel.description = $("#description").code();
                $.ajax({
                    type: "POST",
                    url: User.SaveUrl,
                    data: ko.toJSON(viewModel),
                    contentType: 'application/json',
                    async: true,
                    beforeSend: function () {
                        // Display a loading image
                    },
                    success: function (result) {
                        // Handle the response here.
                        alert("User Created");
                    },
                    complete: function () {
                        // Hide loading image.
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        // Handle error.
                        alert("Error: User Has Not Been Created");
                    }
                });
            }
        });
        
        $('#edituser').click(function (e) {
            //console.log(viewModel);
            // Check whether the form is valid. Only HTML5
            if (document.forms[0].checkValidity()) {
                e.preventDefault();
                viewModel.UserTypeId = $('#user_type').val();
                viewModel.description = $("#description").code();
                $.ajax({
                    type: "POST",
                    url: User.EditUrl,
                    data: ko.toJSON(viewModel),
                    contentType: 'application/json',
                    async: true,
                    beforeSend: function () {
                        // Display loading image
                    },
                    success: function (result) {
                        // Handle the response here.
                        alert("User Edited");
                    },
                    complete: function () {
                        // Hide loading image.
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        // Handle error.
                        alert("Error: User Has Not Been Edited");
                    }
                });
            }
        });
    },
    
    ToEdit: function(modelToEdit) {
        viewModel = modelToEdit;
    }
};

$(document).ready(function () {
    User.BindUIwithViewModel(viewModel);
    User.RegisterUIEventHandlers();
});