
# ClearMirror
Open Source Launcher for Accel World vs Sword Art Online with automatic fix for hybrid graphics
## How it Works
AWvsSAO’s launcher enumerates all GPUs on the system, and presents only those with displays connected as selectable.  Their LUID and display device path are written to the config file.  AWvsSAO then tries to find a `DXGI_OUTPUT_DESC` from these at boot.  If a `nullptr` is returned (because that display is unavailable to that GPU), it errors out.

ClearMirror works around this by ensuring the GPU selected by the launcher is the preferred GPU in Windows.  Windows will reparent the displays to that GPU and AWvsSAO will accept it.
