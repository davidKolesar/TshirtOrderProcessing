function submitOrder() {
    var request = new XMLHttpRequest();
    var o = new Object();
    o.data1 = "Rami";
    o.data2 = "Ramilu";

    request.open('POST', '/OrderHandler', true);
    request.onreadystatechange = function () {
        if (request.readyState == 4 && request.status == 200) {
            alert(request.responseText);
        }
    }
    request.send(JSON.stringify(o));
}