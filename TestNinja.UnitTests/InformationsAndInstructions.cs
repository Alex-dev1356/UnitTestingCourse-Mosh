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


    }
}
