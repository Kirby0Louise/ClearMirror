param(
    [Parameter(Mandatory)]
    [uint64]$TargetLuid
)

# Load WinRT types (built-in, no extra assemblies)
$null = [Windows.Devices.Display.Core.DisplayManager, Windows.Devices.Display.Core, ContentType=WindowsRuntime]
$null = [Windows.Devices.Display.Core.DisplayAdapter, Windows.Devices.Display.Core, ContentType=WindowsRuntime]
$null = [Windows.Graphics.DisplayAdapterId, Windows.Graphics, ContentType=WindowsRuntime]

$dm = $null
try {
    $dm = [Windows.Devices.Display.Core.DisplayManager]::Create([Windows.Devices.Display.Core.DisplayManagerOptions]::None)
    $adapters = $dm.GetCurrentAdapters()

    foreach ($adapter in $adapters) {
        $id = $adapter.Id
        # Reconstruct 64-bit LUID (HighPart is signed Int32)
        $luid = ([uint64]$id.HighPart -shl 32) -bor [uint64]$id.LowPart

        if ($luid -eq $TargetLuid) {
            $specific = "{0:X4}&{1:X4}&{2:X8}" -f $adapter.PciVendorId, $adapter.PciDeviceId, $adapter.PciSubSystemId
            Write-Output $specific
            return
        }
    }

    Write-Error "No adapter found matching LUID 0x$($TargetLuid.ToString('X16'))"
    exit 1
}
finally {
    if ($dm) { $dm.Dispose() }
}