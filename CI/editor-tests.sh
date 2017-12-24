#!/bin/bash

# Script to run Editor Tests, finding the installation path of Unity3D

export UNITY_INSTALLATION=$(find / -mindepth 1 -maxdepth 1 -type d -name "unity*")

echo "Running tests of $UNITY_PROJECT"
$UNITY_INSTALLATION/Editor/Unity \
    -batchmode \
    -nographics \
    -runTests \
    -logFile "$(pwd)/unity-editor-tests.log" \
    -projectPath "$(pwd)" \
    -testResults "$(pwd)/editor-tests-results.xml" \
    -testPlatform editmode \
    -quit