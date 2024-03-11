const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/Login"
    ],
    target: "https://localhost:7139",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
