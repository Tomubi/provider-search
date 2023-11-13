import { useEffect, useState } from "react";
import axios from "axios";
import { Header, List } from "semantic-ui-react";
import { Provider } from "../models/provider";

function App() {
  const [providers, setProviders] = useState<Provider[]>([]);

  useEffect(() => {
    axios
      .get<Provider[]>("http://localhost:5000/api/providers")
      .then((response) => {
        setProviders(response.data);
      });
  }, []);

  return (
    <div>
      <Header as="h2" icon="users" content="Provider Search" />
      <List>
        {providers.map((provider) => (
          <List.Item key={provider.id}>{provider.name}</List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;
