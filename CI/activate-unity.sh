#!/bin/bash

# Script to activate Unity3D. The values are stored in the Settings, not in yaml file.

export UNITY_INSTALLATION=$(find / -mindepth 1 -maxdepth 1 -type d -name "unity*")

echo "Activating UNITY"
$UNITY_INSTALLATION/Editor/Unity \
    -batchmode \
    -nographics \
    -serial $UNITY_SERIAL \
    -username $UNITY_USERNAME \
    -password $UNITY_PASSWORD \
    -quit