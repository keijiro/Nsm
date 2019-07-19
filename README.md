Nsm - NDI Simple Monitor for Linux
==================================

![screenshot](https://i.imgur.com/k1aF4J0l.jpg)


**Nsm** is a small utility that receives a [NDI] video stream and simply show
it on a window or a full screen view.

[NDI]: https://www.newtek.com/ndi/

I made this simple and basic application because NewTek NDI Tools are not
compatible with Linux platforms. It's strongly recommended to use the NDI Tools
on Windows/Mac -- This app is only useful on Linux.

System requirements
-------------------

- Linux desktop system with Vulkan support
- NDI SDK

Nsm requires libndi.so included in the NDI SDK. To install it, download the SDK
package from the [NDI SDK] site, then run [install-ndi.sh] as root in the
extracted SDK directory.

[NDI SDK]: https://www.newtek.com/ndi/sdk/
[install-ndi.sh]: https://gist.github.com/keijiro/0cd095b54e5c2846fb683ad48e8292d2

Installation
------------

Prebuild binaries are vailable from the [Releases] page.

[Releases]: https://github.com/keijiro/Nsm/releases
