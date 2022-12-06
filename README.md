# LocalCaching

# Step 1: install chocolatey
Set-ExecutionPolicy Bypass -Scope Process -Force; 
[System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072;
iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))


test choco
choco -? 

# Step 2: install redis
choco install redis-64 


# Step 3: set path excution
SET PATH=%PATH%;"c:\Program Files\Redis" 
