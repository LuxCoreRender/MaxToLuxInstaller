# MaxToLux Installer
MaxToLux Installer, is an installer for 3ds max LuxCoreRenderer plugin.

![alt text](https://3dfine.com/content/MaxToLux-installer-Wix.jpg)

To build from source code you will need to install Wix Toolset v3 or higher from https://wixtoolset.org/ - The WiX toolset lets developers create installers for Windows Installer, the Windows installation engine. it is opensource and free of charge.
For best experience you can install Wix Toolset extention for visual studio from WixToolset website or visual studio market place.

Requre files should be in directories with same structure as appleseed-max build as you can find in Product.wxs
To add a new version or remove an old one, just remove all the line associated with it in Product.wxs and VersionSelectDlg.wxs
Easiest way to build the project without changing the folder struchture is to have all build file in one level down of the installer project. for example:

..\Build\v2019\
..\Build\v2020\
..\Build\v2021\

ect.
