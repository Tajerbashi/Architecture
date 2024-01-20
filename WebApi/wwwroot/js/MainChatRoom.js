console.log("Start Program Chat Room")
var connection = new signalR.HubConnectionBuilder().withUrl('/ChatHub').build();