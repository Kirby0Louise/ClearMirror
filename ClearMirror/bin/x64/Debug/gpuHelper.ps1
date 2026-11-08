param(
    [Parameter(Mandatory)]
    [uint64]$TargetLuid
)

$luidKey = '{60B193CB-5276-4D0F-96FC-F173ABAD3EC6} 2'
$devices = Get-PnpDevice -Class Display -PresentOnly -ErrorAction SilentlyContinue

foreach ($dev in $devices) {
    $luidProp = Get-PnpDeviceProperty -InstanceId $dev.InstanceId -KeyName $luidKey -ErrorAction SilentlyContinue
    if (-not $luidProp -or $luidProp.Data -eq $null) { continue }

    $luid = $null
    $data = $luidProp.Data

    if ($data -is [byte[]] -and $data.Length -ge 8) {
        $luid = [BitConverter]::ToUInt64($data, 0)
    }
    elseif ($data -is [uint64] -or $data -is [int64]) {
        $luid = [uint64]$data
    }
    else {
        try { $luid = [uint64]$data } catch { continue }
    }

    if ($luid -eq $TargetLuid) {
        $hwidProp = Get-PnpDeviceProperty -InstanceId $dev.InstanceId -KeyName 'DEVPKEY_Device_HardwareIds' -ErrorAction SilentlyContinue
        if (-not $hwidProp) { continue }

        foreach ($id in $hwidProp.Data) {
            if ($id -match 'VEN_([0-9A-F]{4})&DEV_([0-9A-F]{4})&SUBSYS_([0-9A-F]{8})') {
                $specific = "{0}&{1}&{2}" -f $matches[1], $matches[2], $matches[3]
                Write-Output $specific
                return
            }
        }
    }
}

Write-Error "No adapter found matching LUID 0x$($TargetLuid.ToString('X16'))"
exit 1