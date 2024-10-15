# TCS GitWizard

![Status - Pre-Release](https://img.shields.io/badge/Status-Pre--Release-FFFF00) ![GitHub](https://img.shields.io/github/license/Ddemon26/TCS-GitWizard) ![GitHub issues](https://img.shields.io/github/issues/Ddemon26/TCS-GitWizard) ![GitHub last commit](https://img.shields.io/github/last-commit/Ddemon26/TCS-GitWizard) 

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)
![Discord](https://img.shields.io/discord/1047781241010794506)

---

# Overview

**TCS GitWizard** is a Unity editor-exclusive plugin designed to centralize the management of Git repository URLs for Unity projects. It provides a focused tool that allows Unity developers to efficiently store and manage all Git URLs in one place, enabling quick and consistent project setups. By integrating seamlessly into the Unity Editor, TCS GitWizard simplifies the handling of Git-based package links, thus streamlining the project initialization process.

The primary purpose of TCS GitWizard is to serve as a centralized hub for managing all Git-based Unity packages, much like the Unity Package Manager's role in managing store assets and core engine resources. This plugin enables developers to centralize Git repository URLs within a single configuration file, automating the processes of installation, updates, and package management from a unified interface.

The plugin utilizes editor scripts to provide an intuitive user interface, allowing developers to manage packages directly within Unity without relying on external tools. It is particularly advantageous for teams using Git-based packages, offering a streamlined and automated solution to reduce manual intervention and enhance project consistency.

---

# Features

- **Centralized Package Management**: Consolidate all Git repository URLs in one unified configuration, ensuring a streamlined and efficient management process.
- **Efficient Package Handling**: Add, update, and remove Unity packages hosted on Git repositories with minimal effort.
- **Custom Editor Interface**: Integrated editor windows that provide a user-friendly interface for configuring and managing packages directly in Unity.
- **UI Toolkit Integration**: Built with Unity's UIToolkit, providing a consistent, customizable, and modern user interface.

---

# Getting Started

## Prerequisites

- **Unity Version**: TCS GitWizard is compatible with Unity 2021.3 or higher.
- **Git**: Ensure that Git is installed and accessible in your system's PATH, as it is required for cloning and updating repositories.

## Installation

1. **Clone the Repository**: Clone this repository into your Unity project within the `Assets/Plugins` directory.
   ```bash
   git clone https://github.com/Ddemon26/TCS-GitWizard.git Assets/Plugins/TCS-GitWizard
   ```
2. **Open Unity**: After adding the repository, open Unity. The GitWizard tool will be accessible via the `Tools` menu.

---

# Usage

- **Opening GitWizard**: Navigate to `Tools > TCS GitWizard` within the Unity Editor to access the main tool window.

- **Adding a Package**: Click the `Add Package` button to add a new Git-based package by specifying the repository URL. This feature enables efficient centralized package management within Unity.

     <img src="https://cdn.discordapp.com/attachments/1294049442248523877/1294541686323810367/image.png?ex=670b6365&is=670a11e5&hm=ac52f8267d3cc5fc1f475f4f0a3f5fabc7b05a65cba8ae868bca0b105e656c8e&" width="400" height="325">

- **Updating Packages**: Use the interface to view and update packages, ensuring all dependencies are maintained at their latest versions.

     <img src="https://cdn.discordapp.com/attachments/1294216396770906154/1294555490113687615/image.png?ex=670b7040&is=670a1ec0&hm=c3108c065a4f0ba70d5c387378db6469d551340892aeec0bb78101a0d366068f&" width="400" height="325">

---

# Configuration

- **PackageWizardConfig.asset**: This configuration asset stores data related to GitWizard. Users can modify settings such as default Git branches, authentication methods, and other package-specific preferences.

  ![Configuration Settings](path/to/configuration_settings.png)

---

# Contribution

Contributions are highly encouraged! If you wish to contribute to the development of TCS GitWizard, follow these steps:

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes with descriptive messages.
4. Submit a pull request for review.

Please adhere to the coding standards and provide relevant documentation or comments for any new features or changes.

---

# License

This project is licensed under the MIT License. Refer to the [LICENSE](LICENSE) file for additional details.

---

# Acknowledgements

- **Unity UIToolkit**: For providing the UI framework used to build the editor windows.
- **Git for Unity**: For inspiring the management of Git-based packages directly within the Unity interface.

---

# Support

If you experience issues or have questions, please open an issue on the [GitHub Issues](https://github.com/Ddemon26/TCS-GitWizard/issues) page.

---

We encourage you to customize TCS GitWizard to suit your project requirements. We hope this tool significantly enhances your Unity package management experience, contributing to a more efficient and organized workflow.
