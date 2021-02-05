const WebSocket = require('ws');

const server = new WebSocket.Server({ port: 5500 });

server.on('connection', function connect(myself) {console.log("connect")
    myself.on("message", function incoming(data) {
        server.clients.forEach(function each(client) {
            if (client !== myself && client.readyState === WebSocket.OPEN) {
                client.send(data)
            }
        })
    })
});