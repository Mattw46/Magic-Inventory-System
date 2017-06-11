//using System;

/* Interface list methods common to all screens */
interface IScreen
{
    /* Calls helper functions to print screen and get valid input*/
    int RunScreen();

    void PrintScreen();

    int GetInput();
    
    /* thoughs might need multiple version of GetInput if non numeric
      values needed. maybe pass in the max value.
      may need a second method to check for invalid values */
}
