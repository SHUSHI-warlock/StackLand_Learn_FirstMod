# StackLand Learn To Make First Mod

学习如何创建Mod

## Mod配置

1. `In Mod.csproj.user`, set `stacklands` to the directory where you installed Stacklands.
2. In `manifest.json`, configure your mods name and ID. Make sure the ID doesn’t include any spaces or other special characters!
3. In `Mod.csproj`, set `AssemblyName` to your mods ID. By default this is “ExampleMod”.
4. In `Mod.cs`, change ExampleMod to your mods ID, and ExampleModNS to your mods ID followed by “NS”. This is used to differentiate between your mod and others.
