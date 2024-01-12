# Medical Diagnosis System

## Overview

This project serves as the final assignment for a second-year academic course in software testing and quality. The primary objective is to evaluate the acquired knowledge in the field throughout the semester. The task involves the development of a medical software solution capable of identifying a patient's ailment and recommending suitable treatment. The ultimate goal is to deliver optimal care to the patient.

## Task Description

This software project is built using C# and features a graphical user interface (GUI) to facilitate effective GUI testing. The emphasis is on creating a user-friendly interface rather than a rudimentary display with simple print statements.

## Software Requirements

The software is expected to meet the following fundamental requirements:

- **Login Screen:** Login screen where the user can authenticate using a username and password stored in an Excel file. Any errors in login details will trigger appropriate error messages.

- **User Registration:** Functionality to register a new user with specific criteria:

  - Username: 6 to 8 characters, with at most 2 digits, and the rest letters (English).
  - Password: 8 to 10 characters, containing at least one letter, one digit, and one special character (!$, #, etc.).
  - ID number.
    Errors in registration details will trigger suitable error messages.

- **Patient Information:** Capability to input patient details and their medical condition. Relevant fields should be carefully considered.

- **Import Medical Data:** Option to import an Excel file with the patient's medical condition (blood test values). Ensure that data formatting aligns with system requirements.

- **Diagnosis and Treatment:** A button that, when clicked, displays the medical diagnosis and recommended treatment based on system algorithms.

- **Record Patient Visits:** Save details of the patient's visit to the system in an Excel file (patient details, measurements, diagnosis, and treatment).

- **Interactive Questions:** The system should be able to ask the patient questions (answerable with yes/no) during the diagnosis process, taking responses into account. The list of questions will be predefined in the software; there is no need to add extra questions.

## Software Structure

### Login

The application incorporates a login feature, managed by the Login.cs, Login.Designer.cs, and Login.resx files. User accounts are stored in the accountsTable.xlsx file.

### Patient Management

Patient management, handled by the Patient.cs, PatientPage.cs, PatientPage.Designer.cs, and PatientPage.resx files, includes inputting patient details and medical conditions, recording patient visits, and asking interactive questions during the diagnosis process.

### Blood Tests

Blood tests, managed by the BloodTest.cs, BloodTestPage.cs, BloodTestPage.Designer.cs, BloodTestPage.resx, and BloodTestX.cs files, involve importing an Excel file with patient blood test values. The system then displays the medical diagnosis and recommended treatment based on predefined algorithms.

### Other Medical Data

Other types of medical data, such as Hb.cs, HCT.cs, HDL.cs, Iron.cs, Lymph.cs, and Neut.cs files, are handled for comprehensive patient assessment.

### Excel File Handling

The Excel.cs file manages the reading from and writing to Excel files, ensuring seamless data handling.

### Utility Functions

The Functions.cs file contains various utility functions employed throughout the project, enhancing its efficiency and functionality.

### Main Form

The main form of the application is defined by the Form1.cs, Form1.Designer.cs, and Form1.resx files.

## Building and Running

To build and run the project, open life pulse clinic.sln in Visual Studio and use the build and run commands. Ensure all dependencies are installed for a smooth execution.

This project adheres to the principles of software testing and quality, offering a user-friendly graphical interface built in C#. A bit of color has been added to enhance the user experience.
