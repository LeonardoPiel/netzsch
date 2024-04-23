const express = require('express');
const http = require('http');
const WebSocket = require('ws');

const app = express();
const server = http.createServer(app);
const wss = new WebSocket.Server({ server });

let clients = [];

wss.on('connection', (ws) => {
    console.log('Client connected');

    clients.push(ws);

    ws.on('message', (message) => {
        console.log(`Received message from client: ${message}`);
        // Enviar mensagem para todos os clientes conectados
        clients.forEach(client => {
            if (client !== ws && client.readyState === WebSocket.OPEN) {
                client.send(message);
            }
        });
    });

    ws.on('close', () => {
        console.log('Client disconnected');
        // Remover cliente da lista de clientes
        clients = clients.filter(client => client !== ws);
    });
});

app.use(express.static('public'));

const PORT = process.env.PORT || 5500;
server.listen(PORT, () => {
    console.log(`Server running on port ${PORT}`);
});
