
Somehow I was lucky enough to get this working again as of 9/12/2016

![wubba lubba dub dub](/screenshot.png?raw=true "Main View")

## Site
Server is being redesigned at a new address:
https://ffxivmc-1361.appspot.com/

## Installation
download net.japura.ffxivmc.zip and unzip it to the plugins folder for FFXIVAPP
set your server in character settings

The plugin only works if ffxivapp can parse your network traffic. this can be a bit finnicky.

Winpcap is good, however it does not work on windows 10. Maybe win10pcap will work with some fiddling?

If you are unfortunately on windows 10 like I am:
- run ffxivapp as admin
- set your network interface
- enable network reading
- set winpcap to OFF

the plugin should say "initialized" with the current timestamp.

Go to the market board and start looking at items. a ton of crap should be output on the main view for ffxivmc. this means it's working! good job.

##TODO
- make UI less crappy, my WPF skills are rusty.
- add setting input for api key once auth stuff is setup on the server
