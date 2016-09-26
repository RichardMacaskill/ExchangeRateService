#
# InstantCloneDBProvider
#
Clear-Host
Show-InstantCloneOptions -Verbose
Show-InstantCloneClones -Verbose | Format-Table -AutoSize
#Remove-InstantCloneClone -CloneName ForexAppBuild -Verbose
#New-InstantCloneClone -NewDatabaseName ForexAppBuild -SnapshotName ForexSnapshot -Verbose
