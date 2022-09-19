$(document).ready(function () {
    $('.editContactLogo').mouseover(function () {
        $(this).attr('src', "/images/EditBlack.svg");
    });
    $('.editContactLogo').mouseout(function () {
        $(this).attr('src', "/images/EditWhite.svg");
    });
    $('.deleteContactLogo').mouseover(function () {
        $(this).attr('src', "/images/DeleteBlack.svg");
    });
    $('.deleteContactLogo').mouseout(function () {
        $(this).attr('src', "/images/DeleteWhite.svg");
    });
    $('.addContact').click(function () {
        $('#popup1').show(800);
    })
    $('.editContact').click(function () {
        const contactId = $(this).attr('data-id');
        $(`#popup2[data-id='${contactId}']`).show(800);
    })
    $('.popupClose').click(function () {
        $('.popup').hide(800);
    })
    $('.deleteContact').click(function () {
        const contact = $(this).closest('.catalogItem');
        const contactId = $(this).attr('data-id');
        $.get(`api/TheFirstPage/RemoveContact?id=${contactId}`)
            .done(function () {
                contact.remove();
            });
    });
    $('.addContactPopup').click(function () {
            const name = $('#name1').val();
            const mobilePhone = $('#mobilePhone1').val();
            const jobTitle = $('#jobTitle1').val();
            const birthDate = $('#birthDate1').val();
            $.get("/api/TheFirstPage/AddContact", { name: name, mobilePhone: mobilePhone, jobTitle: jobTitle, birthDate: birthDate })
                .done(function () {
                    window.location.reload();
                });
  
    });
    $('.updateContactPopup').click(function () {

        const id = $('#popup2').attr('data-id');
        const name = $('#name').val();
        const mobilePhone = $('#mobilePhone').val();
        const jobTitle = $('#jobTitle').val();
        const birthDate = $('#birthDate').val();
        $.get("/api/TheFirstPage/EditContact", { id: id, name: name, mobilePhone: mobilePhone, jobTitle: jobTitle, birthDate: birthDate })
            .done(function () {
                window.location.reload();
            });

    });


    $('.mobilePhoneImput').mask("+375(99) 999-99-99", { placeholder: "-" });


     $('form').validate({
            rules: {
                name: 'required',
                mobilePhone: 'required',
                jobTitle: {
                    required: true,
                    minlength: 3,
                },
                birthDate: {
                    required: true,
                    date: true,
                }
            },
            messages: {
                name: 'This field is required',
                mobilePhone: 'This field is required',
                jobTitle: {
                    required: 'This field is required',
                    minlength: 'JobTitle must be atleast 3 characterslong'
                },
                birthDate: {
                    required: 'This field is required',
                    date: 'Enter a valid date'
                }
            }
     });

});
