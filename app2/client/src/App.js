import React, { useState, useEffect } from 'react';
import './App.css';

// const WebSocketClient = new WebSocket('ws://localhost:5500'); // TESTANDO NO LOCALHOST DESENVOLVIMENTO 
const WebSocketClient = new WebSocket('wss://netzsch.onrender.com'); // TESTANDO EM HOMOLOGAÇÃO - NUVEM

function App() {
  const [inputText, setInputText] = useState('');
  const [outputText, setOutputText] = useState('');

  useEffect(() => {
    WebSocketClient.onopen = () => {
      console.log('WebSocket connected');
    };

    WebSocketClient.onmessage = (event) => {
      try {
        event.data.text().then(text => {
          setOutputText(text);
        }).catch(error => {
          console.error('Error converting Blob to text:', error);
        });
      } catch (error) {
        console.error('Unexpected error', error);
      }
    };
  }, []);

  const handleInputChange = (event) => {
    setInputText(event.target.value);
  };

  const handleInputKeyUp = (event) => {
    if (WebSocketClient.readyState === WebSocket.OPEN) {
      WebSocketClient.send(inputText);
    }
  };

  return (
    <div className="App">
      <h1>Web Application</h1>
      <input
        type="text"
        value={inputText}
        onChange={handleInputChange}
        onKeyUp={handleInputKeyUp}
        placeholder="Enter text"
      />
      <div>{outputText}</div>
    </div>
  );
}

export default App;
