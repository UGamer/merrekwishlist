var imagePath;
var title;
var want;
var price;
var deliveryTime;
var description;
var url;

function load() {
	var mydata = JSON.parse(data);
	alert(mydata[0].title);
	alert(mydata[1].title);
}