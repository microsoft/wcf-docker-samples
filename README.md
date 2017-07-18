
**WCF:4.6.2 Sample**

The WCF:4.6.2 samples demonstrate basic WCF services scenarios. It shows you how you can build and deploy WCF services in Windows Containers relying on WCF base Docker image, which is built on top of .NET Full Framework 4.6.2 on Windows Server Core. Currently, this repo only contains some basic WCF service scenarios. We would like to continue enriching the repo with more samples based on customer feedback. 

**Script**

Follow these steps to try out this sample. They assume that you already have Git and Docker clients installed.
Since the .NET Framework only runs on Windows you must have Docker set to use Windows containers. You can find more information on that [here](https://docs.microsoft.com/en-us/virtualization/windowscontainers/quick-start/quick-start-windows-10). 

**Preparing your Environment**

Git clone this repository or download these samples to your machine: git clone https://github.com/dotnet/wcf-docker-samples/4.6.2
Navigate to the sample on your machine at the command prompt or terminal. Make sure terminal is open to the same folder that contains the Dockerfile.

**Build and run Docker image**

 - IIS Hosted WCF service
   - Open the 4.6.2/WcfBasicIISHost/WcfServiceTest.sln in Visual Studio and build the Release project locally.
   - Open a powershell window
   - Go to the sample directory that contains the dockerfile for that sample, such as 4.6.2/WcfBasicIISHost
   - Build the Docker image: "docker build -t wcfbasichttpiishost ."
   - Run the IIS hosted WCF service in the container: "docker run -d -p 83:83 --name wcfbasichttpiishost wcfbasichttpiishost"
 - Selfhosted WCF service
   - Open a powershell window
   - Go to the sample directory that contains the dockerfile for that sample, such as 4.6.2/WcfBasicHttpSelfHost
   - Build the Docker image: "docker build -t wcfbasichttpselfhost ."
   - Run the selfhosted WCF service in the container: "docker run -a stdin -a stdout -i -p 83:83 --name wcfbasichttpselfhost wcfbasichttpselfhost"
 - Selfhosted WCF service using TCP
   - Open the 4.6.2/WcfBasicIISHost/WcfServiceTest.sln in Visual Studio and build the Release project locally.
   - Open a powershell window
   - Go to the sample directory that contains the dockerfile for that sample, such as 4.6.2/WCFTCPSelfHost
   - Build the Docker image: "docker build -t wcftcpselfhost ."
   - Run the selfhosted WCF service in the container: "docker run -a stdin -a stdout -i -p 83:83 --name wcftcpselfhost wcftcpselfhost"

**View sample running in the browser**
- There is currently a bug that affects how Windows 10 talks to Containers via "NAT" (Network Address Translation). It is fixed by the Windows Creator Update. If you have an earlier version of Windows 10 you must hit the IP of the container directly. You can get the IP address of your container with the following steps:
  - Run `docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" <image name>` where `<image name>` is replaced with your container ID. For example, `docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" wcfbasichttpiishost`
  - Copy the container ip address and paste into your browser with the correct port.

Note, the selfhosted service host process needs to be run in froneground mode in order to hold the docker container alive while the host process is running.



