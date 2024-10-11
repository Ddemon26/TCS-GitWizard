# TCS GitWizard

![Status - Pre-Release](https://img.shields.io/badge/Status-Pre--Release-FFFF00)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/Ddemon26/TCS-GitWizard)
![GitHub](https://img.shields.io/github/license/Ddemon26/TCS-GitWizard)
![GitHub issues](https://img.shields.io/github/issues/Ddemon26/TCS-GitWizard)
![GitHub last commit](https://img.shields.io/github/last-commit/Ddemon26/TCS-GitWizard)
[![Personal Discord](https://img.shields.io/discord/knwtcq3N2a?label=Personal%20Discord&logo=discord)](https://discord.gg/knwtcq3N2a)
[![Game Dev Discord](https://img.shields.io/discord/3NMF6PwuT2?label=Game%20Dev%20Discord&logo=discord)](https://discord.gg/3NMF6PwuT2)

## Overview

**TCS GitWizard** is a Unity editor-only plugin designed to simplify the process of managing Unity packages hosted on Git repositories. It provides a suite of editor tools that allows Unity developers to configure, install, update, and manage third-party or internal packages seamlessly. By integrating directly into the Unity Editor, TCS GitWizard aims to reduce the complexity of dealing with Git packages, making it easier to handle dependencies and improve development workflow.

The main goal of TCS GitWizard is to serve as a central hub for managing all your Git-based Unity packages, similar to how the Unity Package Manager handles store and core engine assets. This system allows you to store Git repository URLs in a central configuration, and lets these links do all the work for installing, updating, and managing packages in one convenient place.

The tool leverages editor scripts to create an intuitive user interface that enables developers to manage packages without needing to leave Unity. It is an ideal solution for teams that rely on Git-based packages for their projects, providing automation and ease of use.

## Features

- **Centralized Package Management**: Store all your Git package URLs in one place and manage them easily.
- **Package Management**: Easily add, update, and remove Unity packages hosted on Git repositories.
- **Custom Editor Windows**: User-friendly windows for configuring and managing packages, fully integrated into the Unity Editor.
- **Configuration Tools**: Maintain and edit package configuration settings to ensure compatibility across projects.
- **UI Toolkit Integration**: Uses Unity's UIToolkit for a consistent and customizable user experience.

## Getting Started

### Prerequisites

- **Unity Version**: TCS GitWizard has been tested with Unity 2021.3 or higher.
- **Git**: Ensure that Git is installed and accessible from your system's PATH, as it is required for cloning and updating packages.

### Installation

1. **Clone the Repository**: Clone this repository to your Unity project under the `Assets/Plugins` folder.
   ```bash
   git clone https://github.com/Ddemon26/TCS-GitWizard.git Assets/Plugins/TCS-GitWizard
   ```
2. **Open Unity**: Once the repository is added, open Unity, and the GitWizard tools should be available under the `Tools` menu.

### Usage

- **Opening GitWizard**: Navigate to `Tools > TCS GitWizard` in the Unity Editor to open the main window.

 <img src="" width="400" height="325">

- **Adding a Package**: Use the `Add Package` button to add a new Git-based package by providing the repository URL. This will allow you to centralize package management directly in Unity.

  ![Adding a Package](path/to/adding_package.png)

- **Updating Packages**: View and update packages directly through the interface, ensuring that all dependencies are up-to-date.

  ![Updating Packages](path/to/updating_packages.png)

## Configuration

- **PackageWizardConfig.asset**: This asset is used to store configuration data for the GitWizard. You can customize settings such as default Git branches, authentication methods, and other package-specific configurations.

  ![Configuration Settings](path/to/configuration_settings.png)

## Contribution

Contributions are welcome! If you'd like to contribute to the development of TCS GitWizard:

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes.
4. Open a pull request.

Please make sure to follow the coding standards and include relevant documentation/comments for any new features.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgements

- **Unity UIToolkit**: For providing the UI framework used to build the editor windows.
- **Git for Unity**: Inspiration for managing Git-based packages directly from the Unity interface.

## Support

If you encounter any issues or have questions, please open an issue on the [GitHub Issues](https://github.com/Ddemon26/TCS-GitWizard/issues) page.

---

Feel free to customize TCS GitWizard to suit your needs. We hope this tool helps streamline your Unity package management workflow!