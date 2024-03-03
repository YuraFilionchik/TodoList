let SetCustomFocus = SetCustomFocus || {};
SetCustomFocus.setFocus = function (elementId) {
    var element = document.getElementById(elementId);
    if (element) {
        element.focus();
    }
};