# Simple-Injector
A simple DLL injector written in C# that injects a DLL into a running process

### Screenshot
![alt text](https://i.imgur.com/7pPS763.png)

### How does it work?
The address of the LoadLibraryA module is loaded from the Windows API (specifically kernel32.dll). The handle of the chosen process is then found using the method OpenProcess. Using the handle of the chosen process, memory is allocated within the chosen process for the dll name using the method VirtualAllocEx. Once the memory has been allocated, the name of the dll is then written into the chosen processes memory using the method WriteProcessMemory. Finally, a thread is created in the chosen process using the method CreateRemoteThread which calls the LoadLibraryA module (using the LoadLibraryA address), which in turn invokes the contents of the dll.

### How do I use Simple Injector?
* Compile the project (Change debug to release)
* Run the Simple Injector.exe file it creates in the release directory (Simple-Injector\Simple Injector\bin\Release)
