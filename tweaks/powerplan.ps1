Function Invoke-WPFUltimatePerformance {

    # GUID of the Ultimate Performance power plan
    $ultimateGUID = "e9a42b02-d5df-448d-aa00-03f14749eb61"

    $duplicateOutput = powercfg /duplicatescheme $ultimateGUID

    $guid = $null
    $nameFromFile = "ChrisTitus - Ultimate Power Plan"
    $description = "Ultimate Power Plan, added via VonOptimizer"

    foreach ($line in $duplicateOutput) {
        if ($line -match "\b[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}\b") {
            $guid = $matches[0]
            break
        }
    }

    if (-not $guid) {
        Write-Output "No GUID found. Check output."
        exit 1
    }

    powercfg /changename $guid "$nameFromFile" "$description"
    powercfg /setactive $guid

    Write-Host "> Ultimate Performance plan installed"
}

Invoke-WPFUltimatePerformance