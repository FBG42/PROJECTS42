import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import { DataStorage } from './dataContext.jsx'

ReactDOM.createRoot(document.getElementById('root')).render(
  <DataStorage>
    <App />
  </DataStorage>,
)
