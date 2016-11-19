FROM microsoft/dotnet

ADD . /HelloMvc
WORKDIR /HelloMvc
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 5000
#CMD  ["dotnet" ,"run"]. 
ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]