# install WCF basic docker image
FROM microsoft/wcf:4.6.2

# Next, this Dockerfile creates a directory for your application
WORKDIR WCFTCPSelfHost

# This instruction tells the container to listen on port 81, 82. 
EXPOSE 82
EXPOSE 81

# Copies the site you published earlier into the container.
COPY WCFTCPSelfHost/ .

# start WCFTCPSElfHost service process in container as entrypoint process.
ENTRYPOINT .\bin\Release\WCFTCPSelfHost.exe
