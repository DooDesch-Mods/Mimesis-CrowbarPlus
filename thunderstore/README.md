# CrowbarPlus

Tune the crowbar knockback and throw. All defaults preserve native combat, gravity and recovery of the thrown crowbar.

> 🛟 **Need help or found a bug?** Get support at [support.doodesch.de/crowbarplus](https://support.doodesch.de/crowbarplus).

[![Discord](https://mods.doodesch.de/img/badge.svg)](https://mods.doodesch.de)

![CrowbarPlus in MIMESIS](https://raw.githubusercontent.com/DooDesch-Mods/Mimesis-CrowbarPlus/main/docs/img/header.jpg)

For MIMESIS and MelonLoader 0.7.3. A separate mod for the **Crowbar** (item 2900). Install any combination of the six weapon mods. No MimicAPI or separate weapon-core DLL is required.

## Install

1. In Steam, open MIMESIS > Manage > Browse local files.
2. Install MelonLoader 0.7.3 for the game.
3. Copy `CrowbarPlus.dll` into `Mods` beside `MIMESIS.exe`.
4. Start the game once to create `UserData/MelonPreferences.cfg`.
5. Set your options in `[CrowbarPlus]`, then restart the game. Settings changed through a live preferences editor apply to the next attack.

```text
MIMESIS/
  MIMESIS.exe
  Mods/
    CrowbarPlus.dll
  UserData/
    MelonPreferences.cfg
```

## Multiplayer

Gameplay settings follow the lobby host. Each host controls only the weapon mods they have installed. If the host does not have this mod, clients use native gameplay. Client preferences stay saved for their own lobbies. `ShowInfinity` remains local.

All settings in this mod are safe to update live. Damage, reach, cooldown and reload changes apply to the next action; they do not replace an action that is already running. Use the same mod versions on host and clients for the matching HUD and input behavior.

## Configuration

Optional tuning starts at **1.0 = native**. The primary unlimited mode is enabled by default as described above. Invalid values fall back to the native behavior recorded by the host-settings layer.

| Setting | Default | Effect |
| --- | --- | --- |
| `Enabled` | `true` | Enable gameplay changes for this weapon |
| `Unbreakable` | `false` | Prevent combat durability loss; the native normal swing already has no wear |
| `KnockbackMultiplier` | `1.0` | Swing knockback distance multiplier, 0-4 |
| `ThrowSpeedMultiplier` | `1.0` | Initial throw-speed multiplier, 0.25-4 |
| `ThrowDamageMultiplier` | `1.0` | Throw damage multiplier, 0-10 |
| `DamageMultiplier` | `1.0` | Attack damage multiplier, 0-10; Amped Smash and crowbar throws use their separate settings |
| `RangeMultiplier` | `1.0` | Attack reach multiplier, 0.25-4 |
| `CooldownMultiplier` | `1.0` | Attack skill cooldown multiplier, 0.1-5; animation duration stays native |
| `ShowInfinity` | `true` | Local HUD only: show infinity for unlimited ammunition, energy or protected bat durability |

Thrown crowbars leave the inventory and can be recovered after collision as in the original game. This mod does not teleport thrown items back into the inventory. Swing damage includes the native crowbar hit effect.

## In game

![The native Crowbar staged on the Maintenance floor.](https://raw.githubusercontent.com/DooDesch-Mods/Mimesis-CrowbarPlus/main/docs/img/in-game.jpg)

The native Crowbar staged on the Maintenance floor.

## Build

Build with .NET SDK 8 and the shared Mimesis workspace reference set. The project uses the same shared build, deployment guards and host-settings source as the other Mimesis mods. Shared helpers are compiled into this DLL.

## Community

[![DooDesch Mods on Discord](https://mods.doodesch.de/img/card.svg)](https://mods.doodesch.de)

Join the DooDesch Mods Discord: update pings, polls on what comes next, and playtests of new mods.
