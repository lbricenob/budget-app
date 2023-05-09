import { FormEvent, useState } from "react";
import { createUser } from "../services";

export default function Login() {
  interface User {
    email: string;
    password: string;
  }
  const [email, setEmail] = useState<string>("");
  const [password, setPassword] = useState<string>("");

  const handleSubmit = async(event : FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    const user: User = {
      email: email,
      password: password
    }
    await createUser(email, password);
  } 

  return (
    <div>
      <h1>Login</h1>
      <form onSubmit={e => handleSubmit(e)}>
        <div>
          <label htmlFor="email">Email</label>
          <input type="email" id="email" onChange={e => setEmail(e.target.value)} />
        </div>
        <div>
          <label htmlFor="password">Password</label>
          <input type="password" id="password" onChange={p => setPassword(p.target.value)} />
        </div>
        <div>
          <button type="submit">Login</button>
        </div>
      </form>
    </div>
  )
}

