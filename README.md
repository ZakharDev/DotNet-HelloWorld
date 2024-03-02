![logo](/Images/logo.png)
# 💙🤍DotNet-HelloWorld🤍💙

This is a simple .NET Core web application that displays "Hello, World!" of "Hello AppEngine!"

---

## 📘Table of Contents

1. [Introduction](#introduction)
2. [Steps](#steps)
    - [Step 0: Preparation](#step-0-preparation)
    - [Step 1: Clone The GitHub Repository](#step-1-clone-the-github-repository)
    - [Step 2: Restore & Build The Project](#step-2-restore--build-the-project)
    - [Step 3: Run The Project (Test)](#step-3-run-the-project-test)
    - [Step 4: Publish The Project On GCloud](#step-4-publish-the-project-on-gcloud)
3. [Links](#links)

---

## 🖖Introduction

This is a simple .NET Core web application that displays "Hello, World!" of "Hello AppEngine!". This application is intended to be used as a starting point for creating a .NET Core web application that can be deployed to Google Cloud.

## ✨Steps

### 👉 Step 0: Preparation

- Update and upgrade system
    ```bash	
    sudo apt-get update && sudo apt-get upgrade -y
    ```

- Install the .NET SDK 8.0 or later.
    ```bash	
    sudo apt-get install dotnet-sdk-8.0
    dotnet --version # Check if the installation was successful
    ```
- Insall the Google Cloud CLI [Instructions GCloud CLI](https://github.com/EliasDeHondt/IntegrationProject1-Deployment/blob/main/Documentation/Instructions-GCloud-CLI.md)

### 👉 Step 1: Clone The GitHub Repository

- Clone the repository
    ```bash
    git clone https://github.com/EliasDeHondt/DotNet-HelloWorld.git
    ```
- Navigate to the project folder
    ```bash
    cd DotNet-HelloWorld
    ```

### 👉 Step 2: Restore & Build The Project

- Restore the project
    ```bash
    dotnet restore
    ```

- Build the project
    ```bash
    dotnet build
    ```

### 👉 Step 3: Run The Project (Test)

- Run the project
    ```bash
    cd HelloWorld.Cloud/
    dotnet run
    ```

- Open a web browser and navigate to `http://localhost:5000` to see the application running.
- Press `Ctrl+C` to stop the application.

### 👉 Step 4: Publish The Project On GCloud

- Publish the project (`This can take a few minutes`)
    ```bash
    gcloud app deploy --quiet
    ```

- You can find your URL at the end of the output of the previous command.
    ```bash
    gcloud app browse
    ```
- Open a web browser and navigate to the URL to see the application running.

## 🔗Links
- 👯 Web hosting company [EliasDH.com](https://eliasdh.com).
- 📫 How to reach us eliasdehondt@outlook.com.