# install WCF basic docker image

FROM microsoft/wcf

# Next, this Dockerfile creates a directory for your application
RUN mkdir C:\WcfServiceTest

# configure the new site in IIS.
RUN powershell -NoProfile -Command \
    Import-module IISAdministration; \
    New-IISSite -Name "WcfServiceTest" -PhysicalPath C:\WcfServiceTest -BindingInformation "*:83:"

# This instruction tells the container to listen on port 83. 
EXPOSE 83

# The final instruction copies the site you published earlier into the container.
COPY WcfServiceTest/ /WcfServiceTest
