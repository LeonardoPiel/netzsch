using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netzch_test
{
    public partial class FrmHome : Form
    {
        private readonly WebSocketClient _websocket;
        private readonly Uri _uri;

        public FrmHome()
        {
            InitializeComponent();
            _websocket = new WebSocketClient();
            _uri = new Uri("ws://localhost:5500"); // Usando ws:// para WebSocket
        }
        private async void FrmHome_Load(object sender, EventArgs e)
        {
            try
            {
                // Estabelecer a conexão WebSocket ao carregar o formulário
                var connected = await _websocket.ConnectAsync(_uri, txtOutput);
                if (!connected)
                {
                    var answer = MessageBox.Show("Error while connecting, retry?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        txtOutput.Text = "";
                        // Tente reconectar chamando FrmHome_Load novamente
                        FrmHome_Load(sender, e);
                    }
                    else
                    {
                        // O usuário optou por não reconectar
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to connect to WebSocket server: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Enviar automaticamente o texto inserido no txtInput para a aplicação web
                await _websocket.SendAsync(txtInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while sending data to websocket server: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
