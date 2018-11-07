// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(() => {

    $('.slider').slider({
        height: 500
    });
    $('.sidenav').sidenav({
        edge: "right"
    });
    $('.dropdown-trigger').dropdown();

    $('select').formSelect();
    $('.materialboxed').materialbox();
});