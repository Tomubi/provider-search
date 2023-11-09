import { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import { Header, List } from "semantic-ui-react";

function App() {
  const [providers, setProviders] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5000/api/providers").then((response) => {
      setProviders(response.data);
    });
  }, []);

  return (
    <div>
      <Header as="h2" icon="users" content="Provider Search" />
      <List>
        {providers.map((provider: any) => (
          <List.Item key={provider.id}>{provider.name}</List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;
