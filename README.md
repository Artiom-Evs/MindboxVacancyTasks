# MindboxVacancyTasks

## Overview #

This repository contains solutions to test problems for the vacancy of an intern developer at Mindbox.

## Task #1 #

The project defines the ShapeBase, Triangle and Circle classes.
The ShapeBase class is abstract; it contains the abstract CalculateArea() method, which obliges child classes to implement the logic for calculating their area.
The Triangle and Circle classes inherit from ShapeBase and implement the abstract CalculateArea() method, which allows their area to be calculated without knowing their actual type.

## Task #2 #

The project uses an SQLite database accessed through Entity Framework Core. The ORM system was used to implicitly generate the database schema based on the data models.
The SQL query that solves the task is implemented in the StoreService class.
