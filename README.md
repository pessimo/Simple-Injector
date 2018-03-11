# Simple-Injector
A simple DLL injector written in C# that injects a DLL into a running process

### Screenshot
![alt text](https://i.imgur.com/7pPS763.png)

### How does it work?
This method of dll injection uses the windows api (specifically kernel32.dll). It first loads the address of 'LoadLibraryA' from the kernel32.dll. The handle of a specified process (the one you want to inject into) is then found. Using the the processes handle, memory is then allocated in the process for the dll name. Once memory is allocated, the dll name is written into the processes memory. Finally a thread is created in the process which calls LoadLibraryA, which in turn invokes the dll.

### Note
Make sure the dll you are trying to inject shares the same architecture as the process you are trying to inject into. For example only inject a 32 bit dll into 32 bit process. 

### How do I use Simple Injector?
* Compile the project (Change debug to release)
* Run the Simple Injector.exe file it creates in the release directory (Simple-Injector\Simple Injector\bin\Release)
