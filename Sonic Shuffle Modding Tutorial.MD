# Sonic Shuffle Character Modding Tutorial 

## Required Files:
- [GDI Builder](https://github.com/Sappharad/GDIbuilder/releases/) + [buildgdi.exe](https://github.com/Sappharad/GDIbuilder/releases/download/v2.1.1/gdibuilder211_cmd_win_x64.zip): Extract/Build GDI
- [sa-tools](https://github.com/X-Hax/sa_tools/releases): SAMDL, PVM Texture Editing, etc
- [SonicShuffleMDLTool](https://github.com/Psi-Hate/SonicShuffleMDLTool/releases): MDL Editor 
- [Blender 5.1+](https://www.blender.org/download/releases/5-1/): Model Editing
- [SonicAdventureBlenderIO](https://github.com/X-Hax/SonicAdventureBlenderIO): Blender Suite for SA1, SA2, Shuffle, etc.

## Extracting The GDI:
1) Open **GDIBuilder2.Wpf.exe**
2) Select "**Navigate or Extract**"
3) Select "**Open**" and find your Sonic Shuffle GDI
4) Select "**Extract all files**" and create an empty folder named "**Clean**"
5) Duplicate the newly extracted "**Clean**" folder and name the copy "**Modded**"

# Extracting The Character Model:
1) Open "**Sonic_Shuffle_MDL_Tool.exe**"
2) Select "**Open MDL** and select the **.MDL** of your choice from "**Clean/CHRDATA/**"
3) Select "**Extract MDL**" and create an empty folder named after the **.MDL** file you are extracting. It should have extracted many files, of which "**.nj**" are models, "**.njm**" are animations, and "**.pvr**" are texture archives
4) Duplicate the newly extracted folder, keeping the other as a **backup**

# Model Editing:
1) In a new Blender project, Select **"File->Import->SAIO Formats->Sonic Adv .mdl (.\*mdl)**" and open the "**.nj**" of your choice (ex: **008.nj** from **C00.MDL** is **Sonic**'s main model)
2) Edit your model using the [*SAIO Guides*](https://x-hax.github.io/SonicAdventureBlenderIO/guides/) as a reference
3) Once you are ready to export your model, select "**File->Export/SAIO Formats->SA2 Model (\*sa2mdl)**"
4) In the export settings, select the "**Encoding**" dropdown and make sure "**Export NJ**" is enabled
5) Save the exported **\*.nj**

# SAMDL Adjustments
1) Open "**SAMDL.exe**" and select "**File->Open**", opening your"**\*.nj**
2) Using the [*SAIO Texture Guide*](https://x-hax.github.io/SonicAdventureBlenderIO/guides/texturing/) to make your texture archive, open "**File->Load Textures**" and select the model's **\*.pvm**, ensuring the model looks correct in SAMDL
3) Select the **root** object in the top-right panel and make sure "**Skip Draw**" is set to "**False**" in the **bottom-right object properties**
4) Select "**File->Save Model As**" and overwrite the respective **\*.nj** in the **extracted MDL folder** (not the backup folder!), 
as well as overwriting the **\*.pvm** for your respective model with the new textures if needed

# Importing The Model
1) In "**Sonic_Shuffle_MDL_Tool.exe**", Select "**Create MDL**" and select **all files** in the **newly modified MDL folder**, this should create an MDL with the files you extracted and modified. Make sure the files you updated are **named the exact same** as what the originals were, **so if you are replacing "008.nj", then make sure your new model file is also named "008.nj"**
2) Select "**Save MDL**" and save it over the ***\.MDL** you are replacing in "**Modded/CHRDATA/**"

# Testing The Mod:
1) Make sure to extract **buildGUI.exe** into the same folder as **Sonic_Shuffle_MDL_Tool.exe**
2) Open the "**Test**" tab in **Sonic Shuffle Model Tool**
3) Select "**Original GDI**" and provide the **Orginal Sonic Shuffle GDI** used to initialy extract all the game files
4) Select "**Modified Folder**" and select the "**Modded**" folder
5) Select "**Output Folder**", create and select a new empty folder to output the modified ROM
6) Press "**Build GDI**" and wait for the console window to close.  Once finished, your modded ROM should be in the output folder you specified.
7) Press "**Test GDI**" will launch the modded GDI in a dreamcast emulator (ex: flycast) **if you already have the emulator set to open **.GDI** files by default**

