# Nsm - NDI Simple Monitor

![GIF](https://github.com/user-attachments/assets/061bc81e-5145-4b6b-a602-0acda3c7069a)

**Nsm** is a simple NDI monitor app that focuses on a single function:
displaying an NDI video stream.

[NDI]® (Network Device Interface) is a standard developed by [Vizrt] that
enables applications to deliver video streams over a local area network. For
more information about the technology, please visit [ndi.video][NDI].

[NDI]: https://ndi.video/
[Vizrt]: https://www.vizrt.com

## System Requirements

Nsm runs on the following systems:

- x86-64 based Linux system with Vulkan support
- arm64 Android devices with Vulkan support
- 64-bit iOS devices with Metal support

## Installation

Pre-built Linux binaries are available on the [Releases] page.

[Releases]: https://github.com/keijiro/Nsm/releases

There are no pre-built apps for other platforms (Android/iOS). You will need to
install Unity and manually build the project.

## How to Use

- Select an NDI source from the dropdown list.
- You can hide the dropdown list by clicking on an empty space on the screen.
  Click again to make the dropdown reappear.

## Command Line Arguments

The following arguments are available:

| Option                  | Description                          |
|-------------------------|--------------------------------------|
| `--source [NDI name]`   | Connect to the specified NDI source. |
| `--hide-ui`             | Hide the dropdown list on startup.   |

You can also use the [Unity Player command line arguments]. For instance, you
can launch the app in windowed mode by adding `-screen-fullscreen 0` to the arguments.

[Unity Player command line arguments]:
  https://docs.unity3d.com/Manual/PlayerCommandLineArguments.html
