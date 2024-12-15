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

        // <---- Testing Private Methods --->
        #region
        //WE SHOULD NOT TEST PRIVATE OR PROTECTED METHODS,  as the implementation of those methods may change or vary and our tests will fail every time we change the implementation.
        #endregion

        //Note: UNIT TESTS SHOULD NOT TOUCH EXTERNAL RESOURCES. A TEST THAT TOUCHES EXTERNAL RESOURCE
        //IS CONSIDERED TO BE INTEGRATION TEST.

        //Loosely-Coupled and Testable Code
        #region
        //Most leagacy applications are built w/o unit testing in mind. So inorder to Unit Test them
        //we need to REFACTOR them towards a testable and loosely-coupled design. In a loosely-coupled
        //design we can REPLACE ONE OBJECT W/ ANOTHER at run-time. So when Unit Testing a Class that
        //uses an object that talks to an EXTERNAL RESOURCE, we can replace that object w/ a fake object
        //w/c we call TEST DOUBLE. Here are the Three steps that we NEED TO FOLLOW to achieve a Testable
        //and Loosely-coupled design:

        //1. We need to extract the code that uses an external resource into a separate class. So we put 
        //the code that talks to an external resource into a separate class and ISOLATE IT FROM THE REST
        //OF OUR CODE.

        //2. We extract an Interface from that class. We use Interface becuase an Interfasce is like a 
        //contract, it simply declares a bunch of methods and properties but none of these have an 
        //implementation, none of these methods have code. An Interface simply tells C# compiler that
        //somewhere in the code, there are probably one or more classes that implements this contract.
        //So these classes implement the members declared in the interface. We can have two different 
        //classes that implement that Interface. One is the real implementation that uses an external
        //resource, the other IS THE FACE ONE which we call the TEST DOUBLE.

        //3. We modify the class under test. We talk to this interface instead of one of its concrete 
        //implementations. So instead of being dependent on a specific implementation, it will be dependent
        //only on the interface or the contract. We can pass any object that implements that interface
        //and this way the class becomes loosely-coupled and testable.

        //In practical terms, this means we should delete the lines where we create an instance of that
        //implementation using the new operator (delete this: var reader = new FileReader()). Beacause
        //when we use the new operator inside a class, we're making that class tightly coupled or tightly
        //dependent on a given implementation. So we cannot replace that implementation in our test with a
        //fake object. So instead of newing up a specific implementation, our program gains an interface or
        //a contract and then pass on the implementation of that interface from the outside. We can pass that
        //as a parameter to a method (Ex. public void MyMethod(IFileReader reader) {} ), we can also pass a
        //dependency by a constructor or a property.

        //So when we program against interfaces, we can provide different implementations at different times.
        //In our production code, we'll provide the real implementation that talks to an external resource and
        //in our tests we PROVIDE A FAKE IMPLEMENTATION, and this is called DEPENDENCY INJECTION. Instead of
        //newing up dependencies, we INJECT THEM FROM THE OUTSIDE. 

        //DEPENDENCY INJECTION SIMPLY MEANS WE INJECT OR SUPPLY THE DEPENDENCIES OF A CLASS FROM THE OUTSIDE,
        //AND THIS MAKES YOUR CLASSES LOOSELY-COUPLED AND TESTABLE.

        #endregion
    }
}
