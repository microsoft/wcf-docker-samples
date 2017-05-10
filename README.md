
**WCF:4.6.2 Sample**
The WCF:4.6.2 samples demonstrates basic WCF services scenarios. It shows you how you can build and deploy WCF services in Windows Container relying on WCF base Docker image, which is built on top of .NET Full Framework 4.6.2 on Windows Server Core. Currently, this repo only contains some basic WCF service scenarios. We would like to continue enriching the repo with more samples based on customer feedbacks. 

**Script**
Follow these steps to try out this sample. They assume that you already have Git and Docker clients installed.
Since the .NET Framework only runs on Windows you must have Docker set to use Windows containers. You can find more information on that [here](https://docs.microsoft.com/en-us/virtualization/windowscontainers/quick-start/quick-start-windows-10). 

**Preparing your Environment**
Git clone this repository or download these samples to your machine: git clone https://github.com/dotnet/wcf-docker-samples/4.6.2
Navigate to the sample on your machine at the command prompt or terminal. Make sure terminal is open to the same folder that contains the Dockerfile.

**Build and run Docker image**

 - IIS Hosted WCF service
 -- Open a powershell window
 -- Go to the sample directory that contains the dockerfile for that sample, such as 4.6.2/WcfBasicIISHost
 -- Build the Docker image: "docker build -t vmwcfbasichttpiishost ."
 -- Run the IIS hosted WCF service in the container: "docker run -d -p 83:83 --name wcfbasichttpiishost vmwcfbasichttpiishost"
 - Selfhosted WCF service
 -- Open a powershell window
 -- Go to the sample directory that contains the dockerfile for that sample, such as 4.6.2/WcfBasicHttpSelfHost
 -- Build the Docker image: "docker build -t vmwcfbasichttpselfhost ."
 -- Run the selfhosted WCF service in the container: "docker run -a stdin -a stdout -i -p 83:83 --name wcfbasichttpselfhost vmwcfbasichttpselfhost"
Note, the selfhosted service host process needs to be run in froneground mode in order to hold the docker container alive while the host process is running.