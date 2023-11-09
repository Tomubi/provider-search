import { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";

function App() {
  const [providers, setProviders] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/physicians").then((response) => {
      setProviders(response.data);
    });
  }, []);

  return (
    <div>
      <h1>Provider Search</h1>
      <ul>
        {providers.map((provider: any) => (
          <li key={provider.id}>{provider.name}</li>
        ))}
      </ul>
    </div>
  );
}

export default App;
