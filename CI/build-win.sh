#!/bin/bash

# Command-line to build project finding the Unity3d Installation Path, saving it in a variable
# and building for Windows

UNITY_INSTALLATION=$(find / -mindepth 1 -maxdepth 1 -type d -name "unity*")

echo "Attempting to build $UNITY_PROJECT"
$UNITY_INSTALLATION/Editor/Unity \
    -batchmode \
    -nographics \
    -logFile "$(pwd)/unity.log" \
    -projectPath "$(pwd)" \
    -buildWindowsPlayer "$(pwd)/Build/$UNITY_PROJECT.exe" \
    -quit