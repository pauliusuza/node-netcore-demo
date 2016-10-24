# SETUP

### prerequisites:

brew update
brew install openssl
ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/

### net core:

https://go.microsoft.com/fwlink/?LinkID=831679

### running the app

cd project_dir
npm i
dotnet restore
dotnet build
node node/app.js