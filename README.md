# SensorObjects


The aim of this project is to create an application which can simulate a closed system of objects capable of colliding with each other. At the moment, two types of objects are planned to be available: one that can sense it's close proximity and alter it's movement therefore increasing it's chance of avoiding collision, and one that's trajectory is only defined by it's initial velocity vector and later the objects it collides with. The model is in 2D with a top down view and the sole applied physics effect other than collision is fraction that can be also set to 0. The project in it's current state is designed to have only a reasonable number of objects added at the same time so as to make sure the calculations wouldn't slow down the application unnecessarily.


As of March 1st, 2023, the project is still unfinished. The main focus so far was implementing the physics to correctly determine the movement of the objects. The next goal is to add graphics and then test the accuracy of the calculations.
