/** @type {import('next').NextConfig} */
const rewrites = () => {
  return [
    {
      source: '/api/:path*',
      destination: 'http://localhost:5204/api/:path*',
    },
  ]
}

const nextConfig = {
  reactStrictMode: true,
  experimental: {
    appDir: true,
  },
  rewrites,
}

module.exports = nextConfig
