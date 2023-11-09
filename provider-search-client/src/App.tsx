import { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";

function App() {
  const [providers, setProviders] = useState();

  useEffect(() => {
    axios.get("http://localhost:5000/api/providers").then((response) => {
      setProviders(response.data);
    });
  });

  return <h1>Provider Search</h1>;
}

export default App;
