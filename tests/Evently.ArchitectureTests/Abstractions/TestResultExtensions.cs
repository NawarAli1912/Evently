using FluentAssertions;
using NetArchTest.Rules;

namespace Evently.ArchitectureTests.Abstractions;
internal static class TestResultExtensions
{
    internal static void ShouldBeSuccessful(this TestResult result)
    {
        result.FailingTypes?.Should().BeEmpty();
    }
}
