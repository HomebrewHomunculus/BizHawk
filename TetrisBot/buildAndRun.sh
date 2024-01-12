## Build the bot, then launch the emulator with it.

# Prerequisites: add your rom location to env
# export NES_ROM_PATH=yourpathhere

# Build
export DOTNET_ROOT=$HOME/dotnet
export PATH=$PATH:$HOME/dotnet
dotnet build src/


# Run emulator with the tool
../output/EmuHawkMono.sh --mono-no-redirect --open-ext-tool-dll=TetrisBot $NES_ROM_PATH

