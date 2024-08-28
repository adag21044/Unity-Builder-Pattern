# Unity Builder Pattern


This Unity project demonstrates the Builder Design Pattern through a robot construction system. It provides a practical and educational example of how to build complex objects step-by-step using flexible and maintainable code.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Design Patterns](#design-patterns)
- [Components](#components)


## Introduction

The Robot Builder Project showcases the Builder Design Pattern, allowing users to construct a customizable robot using different parts. The Builder Pattern is used to encapsulate the robot creation process, making the code more organized, maintainable, and easy to extend.

## Features

- **Modular Robot Construction:** Build robots using various interchangeable parts (head, body, arms, legs).
- **UI Controls:** Easily switch between different part options using UI buttons.
- **Interactive Part Selection:** Click on robot parts to select and replace them with different models.
- **Flexible Builder Interface:** Add or modify robot parts with a clean, maintainable builder interface.

## Design Patterns

### Builder Design Pattern

This project serves as a prime example of the Builder Design Pattern by separating the robot construction process from its representation. It allows step-by-step customization of a robot with clear, easy-to-understand methods.

### Other Patterns Used

- **Director Pattern:** The `RobotDirector` class directs the construction process using the builder.
- **Factory Pattern:** Although not directly implemented, the modular part selection hints at factory-like instantiation.

## Components

### 1. `IRobotBuilder`
Defines the interface for the robot builder, specifying the methods for setting each robot part and building the final robot.

### 2. `RobotBuilder`
Implements the `IRobotBuilder` interface to build a robot by setting its head, body, arms, and legs. Each part can be replaced dynamically.

### 3. `RobotDirector`
Guides the building process by using the builder to set each part in the correct order, ensuring a complete robot is constructed.

### 4. `PartSelector`
Handles the selection of robot parts through mouse interaction, allowing the user to pick and replace parts dynamically.

### 5. `RobotPartOptions`
Holds the available options for each robot part and manages the selection of the current option.

### 6. `UIController`
Manages the UI elements, such as buttons, to navigate through part options and trigger the robot-building process.

### 7. `RobotPart` (Enum)
Defines the available robot parts: Head, Body, Left Arm, Right Arm, Left Leg, and Right Leg.

