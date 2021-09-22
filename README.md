Nsm - NDI Simple Monitor
========================

![screenshot](https://i.imgur.com/k1aF4J0l.jpg)

**Nsm** is a small utility app that receives an [NDI] video stream and displays
it with a full-screen view.

[NDI]: https://www.newtek.com/ndi/

I developed this app simply because NewTek doesn't provide NDI Monitor software
for some platforms (Linux and mobiles).

System requirements
-------------------

Nsm runs on the following systems:

- x86-64 based Linux system with Vulkan support
- arm64 Android devices with Vulkan support
- 64-bit iOS devices with Metal support

Installation
------------

Pre-built Linux binaries are available on the [Releases] page.

[Releases]: https://github.com/keijiro/Nsm/releases

For other platforms (Android/iOS), there is no pre-built app. You have to
install Unity and manually build the project.

How to use
----------

- Select a NDI source from the drop-down menu.
- You can hide the drop-down menu by clicking an empty space of the screen.
  Click again to make the menu reappear.
