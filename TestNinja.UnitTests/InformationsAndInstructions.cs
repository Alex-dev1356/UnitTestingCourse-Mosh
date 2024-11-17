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

        // <---- Naming and Organising Tests --->
        #region
        // For each project in our solution, WE SHOULD HAVE A UNIT TESTING PROJECT. So if you have a project called
        //TestNinja, WE SHOULD HAVE A SEPARATE PROJECT called TestNinja.UnitTests. As a Rule of Thumb we SHOULD 
        //SEPARATE UNIT AND INTEGRATION TESTS, because Unit Tests execute fast and Integration Tests takes longer so
        //we want to RUN UNIT TEST FREQUENTLY as we're writing code and Integration Test just BEFORE COMMITTING OUR 
        //CODE TO THE REPOSITORY to make sure everything works.

        //In the Project, we often have Test Class FOR EACH CLASS IN OUR PRODUCTION CODE. So if we have a class called
        //Reservation we should have a class called ReservationTests. FOR EACH METHOD IN RESERVATION CLASS, WE SHOULD HAVE 
        //ONE OR MORE TEST METHODS. The number of tests we need DEPENDS ON WHAT WE'RE TESTING often the NUMBER OF TESTS IS
        //GREATER OR EQUAL TO THE NUMBER OF EXECUTION PATHS.

        //The name of our tests SHOULD CLEARLY SPECIFY THE BUSINESS RULE WE'RE TESTING. The naming convention of naming our
        //tests. 
        //[MethodName]_[Scenario we're Testing]_[Expected Behavior].
        #endregion

        // <---- Writing Trustworthy Test --->
        #region
        //A trustworthy test is the kind of test we can rely upon. So if the test passes, you know that your code is working and if it fails
        //you know that there is something wrong with your code.

        //How can we write trustworthy tests?
        //1. Using the Test Driven Development (TDD) with TDD we start by writing a failing test and then we write production code to make that test pass.
        //   So if the test passes that means we have written the right productiojn code to make that test pass. And if the test fails that means something
        //   was wrong with the production code.
        //2. Using Code First Testing (CFT) we start by writing production code and then we write a test to make sure that code works. When writing a test
        //   after your production code we should go to the line that is suppossed to make that line or test pass and make a small change then run the test
        //   again. So if you create a bug on the production code and the test is still passing that means the test is not testing the right thing.

        //Key Takeaway: When writing our tests after the Production Code run our test if it passes, then go in the production code and make a small change
        //in the line that is supposed to make the test pass. Then create a bug, return a different value or maybe comment out that line, if you change the 
        //line that is supposed to make the test pass then our test still passes. That means that test is not testing the right thing. Because if we modify
        //that line and create a bug, the test should fail. So let's make sure to right trustworthy tests that will give us value. So when they pass we know 
        //our code is working and when they fail we know there is something wrong with our code.
        #endregion

        // <---- Writing Trustworthy Test --->
        #region
        //When testing methods that return an array or a collection,we need to do our own assessment on how general, or how specific your tests should be.
        
        //Key Takeaway: When Testing methods that return an array or a collection, make sure our test methods are not too general or too specific.     
        #endregion

        // <---- Naming and Organising Tests --->
        #region
        // For each project in our solution, WE SHOULD HAVE A UNIT TESTING PROJECT. So if you have a project called
        //TestNinja, WE SHOULD HAVE A SEPARATE PROJECT called TestNinja.UnitTests. As a Rule of Thumb we SHOULD 
        //SEPARATE UNIT AND INTEGRATION TESTS, because Unit Tests execute fast and Integration Tests takes longer so
        //we want to RUN UNIT TEST FREQUENTLY as we're writing code and Integration Test just BEFORE COMMITTING OUR 
        //CODE TO THE REPOSITORY to make sure everything works.

        //In the Project, we often have Test Class FOR EACH CLASS IN OUR PRODUCTION CODE. So if we have a class called
        //Reservation we should have a class called ReservationTests. FOR EACH METHOD IN RESERVATION CLASS, WE SHOULD HAVE 
        //ONE OR MORE TEST METHODS. The number of tests we need DEPENDS ON WHAT WE'RE TESTING often the NUMBER OF TESTS IS
        //GREATER OR EQUAL TO THE NUMBER OF EXECUTION PATHS.

        //The name of our tests SHOULD CLEARLY SPECIFY THE BUSINESS RULE WE'RE TESTING. The naming convention of naming our
        //tests. 
        //[MethodName]_[Scenario we're Testing]_[Expected Behavior].
        #endregion
    }
}
