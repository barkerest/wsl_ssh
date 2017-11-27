# wsl_ssh
This simple program simply launches the bash executable telling it to start the SSH service and then wait for the computer to shut down.

The bash executable is launched directly (no shell exec) and has output redirected so there should be no visible window for this program.
Adding the wsl_ssh.exe program to your startup will ensure that you can SSH into the WSL instance at any time that your computer is running
even if you haven't opened any WSL windows yourself.

## License
This utility and the extremely complex source code behind it are released under the MIT license.
