
function check(el) {
    var checkBoxes = document.getElementsByClassName("correct-answer-checkbox");
    for (var i = 0, len = checkBoxes.length; i < len; i++) {
        if (checkBoxes[i] != el) {
            console.log(checkBoxes[i]);
            checkBoxes[i].checked = false;
        }
    }
};




//function check(el) {
//    var checkBoxes = document.getElementsByClassName("correct-answer-checkbox");
//    checkBoxes.forEach(function (item) {
//        if (item != el) {
//            console.log(item);
//            item.checked = false;
//        }
//    });
//}
