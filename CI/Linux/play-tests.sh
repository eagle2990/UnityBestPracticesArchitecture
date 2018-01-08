#!/bin/bash

# Script to run Play tests, finding the installation path of Unity3D

export UNITY_INSTALLATION=$(find / -mindepth 1 -maxdepth 1 -type d -name "unity*")

echo "Running tests of $UNITY_PROJECT"
$UNITY_INSTALLATION/Editor/Unity \
    -batchmode \
    -nographics \
    -runTests \
    -logFile "$(pwd)/unity-play-tests.log" \
    -projectPath "$(pwd)" \
    -testResults "$(pwd)/play-tests-results.xml" \
    -testPlatform playmodemode