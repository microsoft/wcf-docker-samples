# Install wcf base image
FROM microsoft/wcf

# Next, this Dockerfile creates a directory for your application
RUN mkdir C:\BasicHttpHost

# This instruction tells the container to listen on port 83. 
EXPOSE 83

# The final instruction copies the site you published earlier into the container.
ADD Bin/ /BasicHttpHost

