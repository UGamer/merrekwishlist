var imagePath;
var title;
var want;
var price;
var deliveryTime;
var description;
var url;

function load() {
	var mydata = JSON.parse(data);
	
	var index;
	var code = "<table id=\"dataTable\"><tr id=\"heading\"><th></th><th style=\"width:15%;\">Title</th><th style=\"width:5%;\">Want Rating</th><th style=\"width:5%;\">Price</th><th style=\"width:5%;\">Delivery Time</th><th style=\"width:20%;\">Description</th></tr>";
	for (index = 0; index < mydata.length; index++)
	{
		code += "<tr><td><a href=\"" + mydata[index].url + "\" target=\"_blank\"><img src=\"img\\Christmas2019\\" + mydata[index].imageTitle + ".png\" style=\"width=100%;\"></a></td>";
		code += "<td style=\"width:15%;\">" + mydata[index].title + "</td>";
		code += "<td style=\"width:5%;\">" + mydata[index].want + "</td>";
		code += "<td style=\"width:5%;\">$" + mydata[index].price + "</td>";
		code += "<td style=\"width:5%;\">" + mydata[index].deliveryTime + "</td>";
		code += "<td style=\"width:20%;\">" + mydata[index].description + "</td></tr>";
	}
	
	code += "</table>";
	document.getElementById("data").innerHTML = code;
}