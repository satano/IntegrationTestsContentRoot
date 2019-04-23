# IntegrationTestsContentRoot

This si demo project for bug [#9218](https://github.com/aspnet/AspNetCore/issues/9218).

Integration tests are not working when these conditions are met:

- Test projects are located in some subfolder.
- Inherited `Startup` class or inherited `WebApplicationFactory` is used in the test projects.

The tests are failing with the message

> Message: System.ArgumentException : The content root '...\WebApiIntegrationTests\SubFolder_InheritedStartupTests_Workaround' does not exist.
> Parameter name: contentRootPath

The correct content root folder should be '...\WebApiIntegrationTests\tests\SubFolder_InheritedStartupTests_Workaround' - so the subfolder name `tests` is missing in the middle.

**The tests are failing even when the content root is explicitly set (`UseContentRoot(...)`).** It does not matter if content root is set to some arbitrary non-existing folder, or to the correct one, the tests will always fail with the same folder name in the message.
