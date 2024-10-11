# TCS PackageWizard

![Status - Pre-Release](https://img.shields.io/badge/Status-Pre--Release-FFFF00)
![GitHub issues](https://img.shields.io/github/issues/Ddemon26/TCS-PackageWizard)
![GitHub pull requests](https://img.shields.io/github/issues-pr/Ddemon26/TCS-PackageWizard)
![License](https://img.shields.io/github/license/Ddemon26/TCS-PackageWizard)
![Unity Version](https://img.shields.io/badge/Unity-6%2B-blue)

## Overview

**TCS PackageWizard** is an advanced Unity development tool meticulously crafted to facilitate the creation, management, and organization of Unity packages. By leveraging the power of Unity's UI Toolkit, this tool provides an intuitive and sophisticated interface, enabling developers to efficiently create custom packages, integrate seamlessly with Git repositories, and optimize the overall package development workflow. The design philosophy emphasizes both usability and modularity, rendering it equally suitable for both novice developers and experts aiming for reusable, maintainable code.

## Key Features

- **Package Creation Wizard**: Offers a systematic, step-by-step approach to create Unity packages, ensuring adherence to best practices and accurate configuration.
- **Git Integration**: Provides seamless support for integrating Unity packages with Git repositories, allowing for easy cloning and management of packages from remote sources, thereby promoting collaborative development.
- **Intuitive User Interface**: Developed with Unity's UI Toolkit, the user interface is engineered to be modern, responsive, and easily navigable, contributing to an efficient package management experience.
- **Template Utilization**: Offers predefined templates to help developers maintain consistency, standardization, and best practices throughout the package development process.
- **Assembly Definition Management**: Automates the configuration of assembly definitions, thereby optimizing compilation times and ensuring that the package's internal structure remains organized and performant.

## Core Components

- **GitPackages.cs**: Handles Git-based operations related to Unity packages, including cloning repositories and linking to remote Git sources.
- **PackageSingleTemplate.cs**: Serves as the blueprint for structuring new Unity packages, ensuring a consistent starting point that adheres to predefined standards.
- **PackageWizardWindow.cs**: Implements the core editor window for the package wizard, providing an interactive graphical interface to simplify package creation and management.
- **TCSPackageWizard.cs**: Contains the core logic and operational functions that underpin the package wizard's functionality, acting as the central controller for package-related actions.
- **UIToolKit**: Encompasses the UI definitions for the wizard, including XML layout files (`.uxml`) and stylesheets (`.uss`), providing a foundation for the user interface's structure and aesthetic.

## Installation Guide

1. **Clone the Repository**:
   ```
   git clone https://github.com/Ddemon26/TCS-PackageWizard.git
   ```
2. **Import into Unity**:
   - Open your Unity project.
   - Import the `TCS PackageWizard` directory into the `Assets/Editor` folder of your project.

## Usage Instructions

1. **Opening the Package Wizard**:
   - In Unity, navigate to `Tools > TCS PackageWizard` to launch the main wizard interface.
2. **Creating a New Package**:
   - Select the `Create New Package` option.
   - Enter the necessary information, such as the package name, namespace, and destination directory.
   - Use the provided templates to maintain consistency and ensure adherence to project standards.
3. **Managing Git Packages**:
   - Use the `GitPackages` functionality to clone or establish links to remote Git repositories, facilitating external package integration.
4. **Customizing Package Contents**:
   - Modify the default UI configurations in the `UIToolKit` to adapt them to the specific requirements of your project.

## System Requirements

- **Unity Version**: 6 or higher
- **Dependencies**: Unity UI Toolkit (integrated from Unity 6 or higher)

## Contributing to the Project

We highly encourage and appreciate contributions. If you have ideas for enhancements or new features, please open an issue or submit a pull request for review.

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your modifications (`git commit -m 'Add some AmazingFeature'`).
4. Push to the feature branch (`git push origin feature/AmazingFeature`).
5. Open a pull request for evaluation and integration.

## License Information

This project is distributed under the MIT License. For more information, refer to the [LICENSE](LICENSE) file.

## Contact Information

- **Author**: Ddemon26
- **GitHub**: [https://github.com/Ddemon26](https://github.com/Ddemon26)
- **Issues**: [GitHub Issues](https://github.com/Ddemon26/TCS-PackageWizard/issues)

## Acknowledgments

- **Unity Documentation**: We extend our gratitude to the Unity community for their comprehensive documentation and valuable resources.
- **Contributors**: Special thanks to all contributors whose efforts have significantly improved this project.

---

Explore, contribute, and utilize TCS PackageWizard to enhance the modularity and efficiency of your Unity development workflow. We hope this tool empowers your development process and enhances your productivity. Happy coding!
