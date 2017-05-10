# Begin IIS

FROM microsoft/iis

# Next, this Dockerfile creates a directory for your application
RUN mkdir C:\WCFTCPSelfHost

# This instruction tells the container to listen on port 81 and 82. 
EXPOSE 82
EXPOSE 81

# The final instruction copies the site you published earlier into the container.
ADD bin/ /WCFTCPSelfHost

RUN powershell -Command Add-WindowsFeature Web-WebSockets