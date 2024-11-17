using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    public class InformationsAndInstructions
    {
        // <---- Installing NUnit Test ---->
        #region
        //Installing NUnit Test Framework: https://www.nuget.org/packages/NUnit
        //Open Package Manager Console make sure the selected "Default Project" is TestNinja.UnitTests and run: Install-Package NUnit -Version 3.8.1

        //Installing MSTest.TestAdapter: https://www.nuget.org/packages/MSTest.TestAdapter
        //Open Package Manager Console make sure the selected "Default Project" is TestNinja.UnitTests and run: Install-Package NUnit3TestAdapter -Version 3.8.0
        #endregion

        // <---- Characteristics of Good Unit Tests --->
        #region
        // 1. Unit Tests are first Class Citizens meaning they are as important if not MORE THAN the production code.
        // 2. Clean, Readable and Maintainable means all the good practices we have learned in writing clean and readable
        //    code should be applied to our test methods as well. More specifically each test should have a SINGLE RESPONSIBILITY
        //    and should ideally be SHOULD BE LESS THAN TEN LINES OF CODE.
        // 3. No Logic meaning a good unit test should not have any logic, no conditional statements or loops in our tests. 
        //    Just simply call a method and make an Assertions.
        // 4. Isolated meaning each tests should be WRITTEN AND EXECUTED AS IF IT'S THE ONLY TEST IN THE WORLD. So our test 
        //    methods SHOULD NOT CALL EACH OTHER and they SHOULD NOT ASSUME ANY STATE CREATED BY ANOTHER TESTS.
        // 5. Tests should not be too specific or too general meaning if its too general they may not give you much confidence
        //    that your production code is working.
        #endregion

        // <---- What to Test and What Not to Test --->
        #region
        // Unit Testing and Clean coding goes hand in hand. If our code is clean and properly structured, its easier to test.
        //Now assuming that our code is clean:

        //<--- WHAT TO TEST --->
        #region
        //As a Rule Of Thumb, WE SHOULD TEST THE OUTCOME OF A FUNCTION OR METHOD. In programming we have two types of functions:
        //Queries and Commands.

        //Query functions RETURNS SOME VALUE they don't necessarily have to query a Database, this just
        //means their role is to return some value. For Testing a Query Function:
        //We should WRITE A TEST and VERIFY THAT OUR FUNCTION IS RETURNING THE RIGHT VALUE. If we have multiple executions paths
        //on our function then WE SHOULD TEST ALL THE EXECUTION PATHS AND MAKE SURE THAT EACH EXECUTION PATH RESULTS IN THE 
        //RIGHT VALUE.

        //Command Functions PERFORMS AN ACTION, this often involves changing the state of an object in memory and or writing to a 
        //databse or calling a web service or sending a message to a message queue. They're making change in the system and such 
        //functions MAY RETURN A VALUE AS WELL (Ex. The method that creates a new order and writes it to a Database ) may return
        //an object that may includes a unique ID. To test this kind of method we should also test the outcome of this method, if
        //the outcome is TO CHANGE THE STATE OF AN OBJECT IN MEMORY, YOU SHOULD TEST THAT THE GIVEN OBJECT IS NOW IN THE RIGHT STATE.
        //IF THE OUTCOME IS TO TALK ABOUT AN EXTERNAL RESOUCE (Database, wen service) WE SHOULD VERIFY THAT THE CLASS ON THE TEST IS
        //MAKING THE RIGHT CALL TO THESE EXTERNAL DEPENDENCIES.
        #endregion

        //<--- WHAT NOT TO TEST --->
        #region
        //We SHOULD NEVER TEST LANGUAGE FEATURES. For Example if you have a simple C# Class that is mainly a property bag.
        //We SHOULD NOT TEST THESE PROPERTIES. WE SHOULD NOT SET THEM AND THEN READ THEIR VALUE to make sure the property is working.
        //Because this way we're testing C# language features.

        //We SHOULD NEVER TEST 3rd-PARTY CODE. If we're using 3rd-Party library like ANY FRAMEWORK, WE SHOULD NOT WRITE TESTS AROUND
        //THEIR METHODS. WE SHOULD ASSUME THEY'RE PROPERLY TESTED AND WE SHOULD ONLY TEST OUR CODE.
        #endregion

        #endregion
    }
}
