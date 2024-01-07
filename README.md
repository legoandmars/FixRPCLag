# Fix RPC Lag
Fixes lag that's caused by NetworkManager.LogLevel being set to `Developer`. When set to `Developer`, every RPC error will print the RPC Table Contents, causing a lag spike that lasts for several seconds.

This BepInEx mod was originally made for Lethal Company, but it should work for any game that uses NGO for networking.