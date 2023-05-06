export default function Login() {
  return (
    <div>
      <h1>Login</h1>
      <form>
        <div>
          <label htmlFor="email">Email</label>
          <input type="email" id="email" />
        </div>
        <div>
          <label htmlFor="password">Password</label>
          <input type="password" id="password" />
        </div>
      </form>
    </div>
  )
}

