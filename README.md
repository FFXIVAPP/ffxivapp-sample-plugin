## Initial Release:
Please make sure you change the GUID in the sample. A good idea would be to open the project up in VS2012 and export the entire thing as a project template.

Once you do that; you can create new project as you go and rename them to what you need. The build locations would need to be updated as well as the GUID in this case.

## Requirements

* Nuget package manager
 * Restore packages once installed
* VS2012
* .NET4.5 installed

You will have to copy the following files from the most recent version of the app and update the system references:

* FFXIVAPP.Common.dll
* FFXIVAPP.IPluginInterface.dll
* MahApps.Metro.dll
* System.Windows.Interactivity.dll

## Notes:

I've tried to give an example of most of the binding features available. The majority of the official plugins off the site are nearly 100% data bound so nothing appears in the app unless there's actual data.

If you have a question please post it in the issues section as such and I can address the response there for everyone to see.

Thanks!

## Entry Point:

* The log entry point to use what comes from the chat is under Utilities\LogPublishers\Process()
* The tab/window entry point is ShellView.xaml; with loading functions defined in the .cs file
* There is an option to make your plugin acts as a window which means once it's added to the main application you can make it have a separate appearance for the window.
* Plugin entry point is Plugin.cs and controls the plugin info/other functionality of commands being sent and recieved.