@echo off
DISM.exe /Online /Cleanup-image /Restorehealth
Sfc /scannow
shutdown /r
exit