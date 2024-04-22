using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace netzch_test
{
    public class WebSocketClient
    {
        private ClientWebSocket _clientWebSocket;
        private TextBox _txtToReceive;
        public async Task<bool> ConnectAsync(Uri uri, TextBox txtToReceive)
        {
            try
            {
                _clientWebSocket = new ClientWebSocket();
                _txtToReceive = txtToReceive;
                await _clientWebSocket.ConnectAsync(uri, CancellationToken.None);
                await ReceiveLoopAsync();
                return true;
            }
            catch (Exception ex)
            {
                //log ex
                return false;
            }
        }

        public async Task SendAsync(string text)
        {
            try
            {
                if (_clientWebSocket != null && _clientWebSocket.State == WebSocketState.Open)
                {
                    var buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(text));
                    await _clientWebSocket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        private async Task ReceiveLoopAsync()
        {
            try
            {
                var buffer = new byte[1024];
                while (_clientWebSocket.State == WebSocketState.Open)
                {
                    var result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (new List<WebSocketMessageType>() { WebSocketMessageType.Binary, WebSocketMessageType.Text }.Contains(result.MessageType))
                    {
                        var receivedText = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        UpdateOutput(receivedText);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        private void UpdateOutput(string text)
        {
            _txtToReceive.Text = text;
        }
    }
}
