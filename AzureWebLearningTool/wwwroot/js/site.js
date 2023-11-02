// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function getDesiredElement(id)
{
    return document.getElementById(id);
}

function breakCaching()
{
    var el = getDesiredElement("councilLogo");

    alert(el.style.backgroundImage);

    el.style["background-image"] = 'url(' + el.style.backgroundImage + '?' + (new Date()) + ')';
}

