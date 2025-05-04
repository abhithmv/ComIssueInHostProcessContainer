FROM mcr.microsoft.com/windows/nanoserver:ltsc2022

COPY bin c:/app/bin

EXPOSE 80 443
WORKDIR c:\\hpc\\app\\bin

CMD ["c:\\hpc\\app\\bin\\ComExample.exe"]
