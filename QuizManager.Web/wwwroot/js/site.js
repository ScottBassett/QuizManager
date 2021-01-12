// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function check(el) {
    var checkBoxes = document.getElementsByName("correct-answer-checkbox");
    checkBoxes.forEach(function (item) {
        if (item != el) {
            console.log(item);
            item.checked = false;
        }
    });
}

function MutExChkList(chk) {
    var chkList = chk.parentNode.parentNode.parentNode;
    var chks = chkList.getElementsByName("correct-answer-checkbox");
    for (var i = 0; i < chks.length; i++) {
        if (chks[i] != chk && chk.checked) {
            chks[i].checked = false;
        }
    }
}