#!/bin/bash

# Installing Unity3D Editor in Linux using Env Variables defined in .travis.yml file.
# Current link is for 2017.2.0.f3, which is a beta for Unity3D Linux. The full information of
# latests Linux versions can be found in
# https://forum.unity.com/threads/unity-on-linux-release-notes-and-known-issues.350256/page-2

check_file_exists_or_download() {
    if [ -e $1 ]
    then
        echo "File $1 exists so it's not neccesary to download"
    else
        wget -q -O $1 $2
    fi
}

export UNITY_INSTALLER="Unity.sh"
echo 'Downloading Unity Installer'
if [ "$TRAVIS_OS_NAME" = "linux" ]
then
    export UNITY_INSTALLER="Unity.sh"
    check_file_exists_or_download $UNITY_INSTALLER $UNITY_LINUX_DOWNLOAD
    echo 'Installing $UNITY_INSTALLER for Linux in $UNITY_ROOT_PATH'
    sudo chmod +x $UNITY_INSTALLER
    sudo echo | sudo ./$UNITY_INSTALLER -o $UNITY_ROOT_PATH
else
    export UNITY_INSTALLER="Unity.pkg"
    check_file_exists_or_download $UNITY_INSTALLER $UNITY_MACOS_DOWNLOAD
    echo 'Installing $UNITY_INSTALLER for MacOS'
    sudo installer -dumplog -package $UNITY_INSTALLER -target $UNITY_ROOT_PATH
fi