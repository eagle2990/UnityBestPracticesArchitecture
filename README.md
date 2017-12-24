# Unity VR / ML Agents / CI Experiment 
[![liberapay](https://liberapay.com/assets/widgets/donate.svg)](https://liberapay.com/eagle2990/donate)

This project is an experiment trying to achieve best practices in Unity, while also practicing/learning new skills like Machine Learning, ScriptableObjects and Continuous Integration using Travis CI.

---
## Table of Contents

    [TOC]

---
## Goals

1. Create a basic environment for data using ScriptableObjects.
2. Use automated testing.
3. Setup CI.
4. Optimize scene for VR.
5. Create an AI using ML.

## Takeaways

1. Editor tests should be focused in objects that **DON'T** require MonoBehaviour methods (like Start, Update), while Play tests are the opposite.
2. Activating Unity through command-line is almost impossible as it requires to accept their terms and conditions, which currently there is no option for that. I will be still searching, but so far I think I will require a dedicated server for CI/CD.

## FAQ

### Which Unity version is supported?
_Currently I'm working on **2017.2.0f3**_

### I have problems downloading the repository
_The repository is using Git LFS, so it requires to be downloaded cloaning the repository using_ `git clone https://github.com/eagle2990/UnityMLAgents.git` _as the current_ **Download ZIP** _doesn't support LFS._

## Contribution
_Just send me an email to eagle2990@gmail.com_

## Licensing
MIT