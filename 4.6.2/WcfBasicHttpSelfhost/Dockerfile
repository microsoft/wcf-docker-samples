# install WCF basic docker image
FROM microsoft/wcf:4.6.2

# Next, this Dockerfile creates a directory for your application
WORKDIR BasicHttpHost

# This instruction tells the container to listen on port 83. 
EXPOSE 83

# The final instruction copies the site you published earlier into the container.
COPY BasicHttpHost/ .
ENTRYPOINT .\bin\Release\BasicHttpHost.exe

