## Visual Programming
### Installation Guide For Linux .Net

``
wget https://packages.microsoft.com/config/ubuntu/22.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
``
<br/>
``
sudo dpkg -i packages-microsoft-prod.deb
``
<br/>
``
rm packages-microsoft-prod.deb
``
#### Install the SDK
``
sudo apt-get update && \sudo apt-get install -y dotnet-sdk-7.0
``

#### Install the runtime
``
sudo apt-get update && \sudo apt-get install -y aspnetcore-runtime-7.0
``
#### Check donet version
``
dotnet --version
``

#### Create new console project

``dotnet new console -o HelloWorld`` <br/>
``cd HelloWorld`` <br/>

#### Run the Project
``dotnet run``

### Installation Guide For Mac .Net
Download .net for mac form here
[Download](https://dotnet.microsoft.com/en-us/download)

After download install on your system then open terminal and check dotnet version.

``donet --version``

#### Create new console project

``dotnet new console -o HelloWorld`` <br/>
``cd HelloWorld`` <br/>

#### Run the Project
``dotnet run``



