﻿using System;
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

        //Injecting Dependencies via Method Parameters
        #region
        //In the ReadVideoTitle Method (Under VideoService Class), instead of working with the concrete
        //implementation which is the FileReader(), we're going to pass an IFileReader object as a parameter
        //to the ReadVideoTitle Method (ReadVideoTitle(IFileReader filereader)) and we can get rid of the 
        //new FileReader() operator, so now we use the fileReader Argument : var str = fileReader.Read("video.txt");
        //With this simple change, our VideoService Class becomes loosely-coupled and testable. Because in our prod
        //code we can pass a real file reader object to the project whereas in our test, we can pass a fake fileReader
        //object.

        //Dependency Injection Framework is responsible to newing up the objects and passing them to our methods.
        //For demo we're going to create a Program.cs file and there we're gonna call the VideoService() along with its
        //ReadTitle Method.

        //NOTE: It's a good practice that our Unit Testing Project mimic the SAME STRUCTURE we have on the project on
        //our test. So we're also going to create a "Mocking" Folder in our Unit Testing Project. And we're going to add
        //all the Unit Tests for the classes defined in the Mocking Namespace iside the Mocking folder.
        #endregion

        //Injecting Dependencies via Properties
        #region
        //One issue that we may encounter when Injecting Dependencies via Method Parameter is that, we may be
        //changing the signature of our Method. Let's imagine we're using the ReadVideoTitle Method in our code
        //10 different places and all of a sudden we Introduce the "IFileReader fileReader Parameter" then we're
        //gonna need to modify  those ten places in our code. The other issue we may run into is that some dependency
        //injection framework cannot inject dependencies via method parameters. There are quite a few dependency injection
        //frameworks out there, every team locves a different framework.

        //Instead of Injecting Depency using a parameter, we can Inject it using a property. We need to create a property
        //OF TYPE IFileReader and we need to instanciate the class who implemented that interface inside the constructor of 
        //our VideoService Class, with this we can now remove the IFileReader fileReader parameter inside the ReadVideoTitle()
        //method. When Testing the VideoServide Class just BEFORE CALLING THE ReadVideoTitle Method, we can replace the
        //new FileReader()(the real file reader) into new MockFileReader()(the fake one or Test Double).

        //On the Program Class and remove the new FileReader() parameter on the title variable, similarly on the VideoServiceTests
        //we remove the new MockFileReader() parameter on the var result variable. On the VideoServiceTests before acting we should 
        //replace the real FileReader with the fake one (var service = new VideoService(); then below service.FileReader = new MockFileReader();)
        #endregion

        //Injecting Dependencies via Constructor
        #region
        //On the constructor, we're gonna add IFileReader fileReader, and we're gonna change the public
        //property with a private field because we're going to inject a dependency at the time of creating 
        //a VideoService Object, so we're going to delete the getter and the setter, we repalce it with 
        //private readonly IFileReader _fileReader; and inside the constructor _fileReader = fileReader;.
        //On the VideoService Class we're gonna create another constructor that doesn't take any parameters,
        //so its a default constructor, on this constructor we can set a _fileReader = new FileReader(); object
        //So in our production code, we gonna use the default constructor , but in our test code we're
        //going to use the constructor with one parameter so we can pass a fake FileReader.

        //In our production code the Prgram.cs we're creating a new VideoService WITHOUT ANY ARGUMENTS to the constructor.
        //In this case OUR ARGUMENT IS NULL, so with this implementation we're gonna set _fileReader = new FileReader() Object.
        //In our UnitTest we're gonna pass a fake fileReader object. On our Unit Test var service = new VideoService(new MockFileReader());
        #endregion

        //Dependency Injection Framework
        #region
        //We have multiple dependency injection framework that we can use like (NInject, StructureMap, Spring.NET,
        //Autofac, Unity and etc...) almost all these frameworks follows the same principles. In a dependency
        //injection framework, we have a container and this container is a registry of all our interfaces and their
        //implementation, when our application starts, our DI Framework will automatically take care of creating object
        //graph based on the interfaces and types registered in the container.

        //NOTE: The two most popular DI Frameworks are NInject and Autofac. Read the documentation about what we need
        //to use them in our applications.
        #endregion

        //Creating Mock Objects Using Moq
        #region
        //On our Unit Test solution, go to "Manage Nuget Packages" then search for "Moq" then install it.

        //After the installation, we no longer need the MockFileReader Class and we can delete it in our Unit Test
        //Project. On the VideoServiceTests Class we create var mockFileReader = new Mock<IFileReader>(), here we're telling
        //the Moq Library we want an object that implements the IFileReader interface. The mockFileReader is NOT THE ACTUAL 
        //OBJECT its a MOCK OBJECT, because we set this to a new Mock of IFileReader.

        //We need to program this mock because by default, it doesn't have any behavior it's like an object that implements
        //the IFileReader interface but doesn't do anything, it doesn't have any code now let's go back to our VideoService Class
        //on the var str = _fileReader.Read("video.txt"); we're calling the Read Method of _fileReader and we're passing it "video.txt"
        //as an argument. So we need to program our Mock, so when we call the Read Method and give it "video.txt" as a string, its
        //going to return a string.

        //Back in our VideoServiceTest, the way we do this is via the SETUP METHOD, we call fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
        //and inside we're gonna pass a lambda expression fr in short for filereader goes to fr.Read and we specify the argument ("video.txt") so with
        //this we're telling this mock fileReader that when we call the Read Method with this argument (fr.Read("video.txt")) it should return some
        //string, in our case since the scenario we're testing is for an empty file, we're going to return an empty string ("")

        //Here (.Returns("")) we have an option, we can also throw an exception and specify the type of exception. This fileReader IS NOT that object
        //that implements IFileReader, it's a Mock Object but here (var service = new VideoService(new MockFileReader()) when initializing this video
        //service, we need to get that Object, we simply pass (fileReader.Object). So this is the actual object that implements IFileReader.

        //When we use Mocks our test methods get a little bit noisy, that's why we shoul reserve Mocks ONLY FOR DEALING WITH EXTERNAL DEPENDENCIES.
        //When we use Mocks, it is good to put on the Setup Method or Setup Attribute some of the arrange part, like var service = new VideoService(new MockFileReader())
        //and var service = new VideoService(fileReader.Object);

        //Note: To know about the list of feature of Moq Framework, read it's documentation here: https://github.com/devlooped/mog/wiki
        #endregion

        //State-based vs Interaction Testing
        #region
        //State-based Testing - we asserted that our methods returned the right value or set the right state.
        //We test the state changes in our application.

        //However when dealing with the code that touches external resources, we need to verify the class we're
        //testing interacts with another class properly.

        //Interaction Testing - we test the interaction of one class with another class.

        //Note: USE INTERACTION TESTING ONLY WHEN DEALING WITH EXTERNAL DEPENDENCIES. Our test should only test 
        //the EXTERNAL BEHAVIOUR and NOT THE IMPLEMENTATION.So PREFER STATE-BASED TESTING OVER INTERACTION TESTING.
        //AND USE INTERACTION TESTING ONLY WHEN DEALING WITH EXTERNAL RESOURCES.
        #endregion

        //Testing the Interaction between Two Objects
        #region
        //On the Mocking Folder, Inside the OrderService Class we want to write a test for this method (PlaceOrder(Order order))
        //and assert that _storage.Store(order) is called with the same object that we passed to the PlaceOrder Method.

        //Let's create a Test inside the Mock Folder on the Unit Test Project. Based on the OrderService Class we are Injecting the
        //IStorage Object on the constructor. So in our test we need to create a Mock Object for IStorage Interface. So in our 
        //OrderServiceTest Class we create a Mock Object for IStorage Interface. We create a var storage = new Mock<IStorage>(); then
        //we create an order service var orderService = new OrderService(storage.Object); then we need to act orderService.PlaceOrder(new Order());
        //and finally we need to assert that _storage.Store(order) is called with the same object that we passed to the PlaceOrder Method.
        //We do that by using Verify Method. Verify(storage => storage.Store(order)); through this we can verify if the given method is called with 
        //the right argument or not. We need to make sure that the right argument is passed to the method so we use the lambda expression and pass
        // the same object that we passed to the PlaceOrder Method so we add the Order Object.

        //Note: To test the interaction between two objects, we can use the Verify Method of Moq Objects. The Moq SetUp Method we use this to program
        //a Mock Object.
        #endregion

        //Fake as Little as Possible
        #region
        //USER MOCKS AS LITTLE AS POSSIBLE. Reserve them ONLY WHEN DEALING WITH EXTERNAL RESOURCES.
        //We wuse Mocks to remove the need for external resources from our Unit Tests so they can 
        //run quickly and reliably.

        //Note: Unit Tests SHOULD BE FAST.
        #endregion

        //Refactoring VideoService Class to test GetUnprocessedVideosAsCsv Method
        #region
        //We need to isolate the using (var context = new VideoContext()) part since that is the one that connects to an external dependency,
        //On the Mocking Folder we create VideoRepository Class and we use IEnumerable<Video> because we simply want to enumerate this list.
        //We just want to iterate over it, back on the VideoService Class we transfer the var videos = ...... to our VideoRepository Class.
        //We need to have a reference on the DbContext(context.Videos) so back in our VideoService Class we copy the using(var context = new VideoContext())
        //to our new class and we simply return videos, on the VideoService Class we no longer need the 'using' block. On the foreach block we need to get 
        //these videos from our video repository. So the next step of refactoring is these videos, we're gonna new up the VideoRepository Class and call
        //GetUnprocessedVideos Method and get the result and store it in the videos variable. However when we new up the VideoRepository Class the VideoService
        //Class would be tightly coupled to the VideoRepository Class. So we need to create an Interface for the VideoRepository Class then we can use any classes
        //that implements the IVideoRepository Interface.
        #endregion

        //Writing Unit Test for GetUnprocessedVideosAsCsv Method
        #region
        //On the VideoServiceTest Class we need to create a Mock Object for IVideoRepository Interface, which we already done earlier during the refactoring and now 
        //on the arrange part we need to program our Mock. we use _videoRepository.Setup(vr => vr.GetUnprocessedVideos()).Returns(new List<Video>()); to return an
        //empty list. Next we're gonna call _videoService.GetUnprocessedVideosAsCsv() get the result and assert that the result IsEqualTo an empty string.
        #endregion
    }
}
