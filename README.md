# BetterSinkholes-NWAPI
[![GitHub release](https://flat.badgen.net/github/release/Nakuliv/BetterSinkoles-NWAPI)](https://github.com/Nakuliv/BetterSinkoles-NWAPI/releases/)
![GitHub downloads](https://flat.badgen.net/github/assets-dl/Nakuliv/BetterSinkoles-NWAPI)

port of [Exiled BetterSinkholes plugin](https://github.com/warden161/BetterSinkholes2)
# Installation
1. Download the `BetterSinkholes-NWAPI.dll` and `0Harmony.dll` from the [latest release](https://github.com/Nakuliv/BetterSinkoles-NWAPI/releases/latest)
2. Put the `BetterSinkholes-NWAPI.dll` in your `plugins` folder (`/PluginAPI/plugins/<port>/`)
4. Put the `0Harmony.dll` in your `dependencies` folder (`/PluginAPI/plugins/<port>/dependencies`)
5. Restart your server

## Configs
| Config option | Value type | Default value | Description |
| --- | --- | --- | --- |
| `TeleportDistance` | float | 0.6f | Distance from a sinkhole where it teleports you to the pocket dimension. Set it to higher than 0!|
| `TeleportMessage` | string | '' | Set it to '' to disable sinkhole teleport message. Can use Unity's RichText. |
| `TeleportMessageDuration` | ushort | 0 | Duration of the sinkhole teleport message, when teleport message is not empty. |
