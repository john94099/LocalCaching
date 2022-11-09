# LocalCaching
install chocolatey

Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))

test choco
choco -? 

install redis
choco install redis-64 

set path
SET PATH=%PATH%;"c:\Program Files\Redis" 