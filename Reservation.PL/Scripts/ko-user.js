/// <reference path="jquery-1.10.2.js"/>
/// <reference path="knockout-2.2.0.debug.js"/>

var viewModel = {
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
            console.log(viewModel);
            // Check whether the form is valid. Only HTML5
            if (document.forms[0].checkValidity()) {
                e.preventDefault();
                viewModel.UserTypeId = $('#user_type').val();
                $.ajax({
                    type: "POST",
                    url: User.SaveUrl,
                    data: ko.toJSON(viewModel),
                    contentType: 'application/json',
                    async: true,
                    beforeSend: function () {
                        // Display loading image
                    },
                    success: function (result) {
                        // Handle the response here.
                    },
                    complete: function () {
                        // Hide loading image.
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        // Handle error.
                    }
                });
            }
        });
    },
};

$(document).ready(function () {
    User.BindUIwithViewModel(viewModel);
    User.RegisterUIEventHandlers();
});