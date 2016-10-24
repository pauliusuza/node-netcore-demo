# Running NetCore .dll library inside Node (demo project)

This project demonstrates the minimum setup needed to run a DLL compiled with NetCore 1.0 inside Node.js using Edge.js framework.

## SETUP for OSX

### Prerequisites

Install brew (if you don't have it):
http://brew.sh

Install prerequisites for NetCore using brew
```
brew update
brew install openssl
ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/
```

### Net Core:

Download latest version from 
https://go.microsoft.com/fwlink/?LinkID=831679

### Running the app

Install Node.js prerequisites
```
cd project_dir
npm i
```

Install .NET prerequisites
```
dotnet restore
```

Build .dll file and run the app
```
dotnet build
node node/app.js
```

## SETUP for Linux and Windows

Follow instructions on how to set up NetCore for your flavor of OS:
https://www.microsoft.com/net/core