# SETUP for OSX:

### prerequisites:

Install brew (if you don't have it):
http://brew.sh

Install prerequisites for NetCore using brew
```
brew update
brew install openssl
ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/
```

### net core:

Download latest version from 
https://go.microsoft.com/fwlink/?LinkID=831679

### running the app

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