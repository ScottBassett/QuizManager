
function check(el) {
    var checkBoxes = document.getElementsByClassName("correct-answer-checkbox");
    for (var i = 0, len = checkBoxes.length; i < len; i++) {
        if (checkBoxes[i] != el) {
            checkBoxes[i].checked = false;
        }
    }
};