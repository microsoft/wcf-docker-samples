# Begin IIS

FROM microsoft/wcf

# Next, this Dockerfile creates a directory for your application
WORKDIR WCFTCPSelfHost

# This instruction tells the container to listen on port 81, 82. 
EXPOSE 82
EXPOSE 81

# The final instruction copies the site you published earlier into the container.
COPY WCFTCPSelfHost/ .
ENTRYPOINT .\bin\Release\WCFTCPSelfHost.exe
