using System.Reflection;
using Evently.ArchitectureTests.Abstractions;
using Evently.Modules.Attendance.Domain.Attendees;
using Evently.Modules.Attendance.Infrastructure;
using Evently.Modules.Events.Domain.Events;
using Evently.Modules.Events.Infrastructure;
using Evently.Modules.Ticketing.Domain.Orders;
using Evently.Modules.Ticketing.Infrastructure;
using Evently.Modules.Users.Domain.Users;
using Evently.Modules.Users.Infrastructure;
using NetArchTest.Rules;

namespace Evently.ArchitectureTests.Layers;
public class ModuleTests : BaseTest
{
    [Fact]
    public void UsersModule_ShouldNotHaveDependencyOn_AnyOtherModule()
    {
        string[] otherModules = [EventsNamespace, AttendanceNamespace, TicketingNamespace];

        string[] integrationEventsModule = [
            EventsIntegrationEventsNamespace,
            TicketingIntegrationEventsNamespace,
            AttendanceIntegrationEventsNamespace
            ];

        List<Assembly> usersAssemblies =
            [
                typeof(User).Assembly,
                Modules.Users.Application.AssemblyReference.Assembly,
                Modules.Users.Presentation.AssemblyReference.Assembly,
                typeof(UsersModule).Assembly
            ];

        Types.InAssemblies(usersAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationEventsModule)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }

    [Fact]
    public void TicketingModule_ShouldNotHaveDependencyOn_OtherModules()
    {
        string[] otherModules = [EventsNamespace, AttendanceNamespace, UsersNamespace];

        string[] integrationEventsModule = [
            EventsIntegrationEventsNamespace,
            TicketingIntegrationEventsNamespace,
            UsersIntegrationEventsNamespace
            ];

        List<Assembly> ticketingsAssemblies =
            [
                typeof(Order).Assembly,
                Modules.Ticketing.Application.AssemblyReference.Assembly,
                Modules.Ticketing.Presentation.AssemblyReference.Assembly,
                typeof(TicketingModule).Assembly
            ];

        Types.InAssemblies(ticketingsAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationEventsModule)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }

    [Fact]
    public void EventsModule_ShouldNotHaveDependencyOn_OtherModules()
    {
        string[] otherModules = [TicketingNamespace, AttendanceNamespace, UsersNamespace];

        string[] integrationEventsModule = [
            TicketingIntegrationEventsNamespace,
            AttendanceIntegrationEventsNamespace,
            UsersIntegrationEventsNamespace
            ];

        List<Assembly> eventsAssemblies =
            [
                typeof(Event).Assembly,
                Modules.Events.Application.AssemblyReference.Assembly,
                Modules.Events.Presentation.AssemblyReference.Assembly,
                typeof(EventsModule).Assembly
            ];

        Types.InAssemblies(eventsAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationEventsModule)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }

    [Fact]
    public void AttendanceModule_ShouldNotHaveDependencyOn_OtherModules()
    {
        string[] otherModules = [TicketingNamespace, EventsNamespace, UsersNamespace];

        string[] integrationEventsModule = [
            TicketingIntegrationEventsNamespace,
            EventsIntegrationEventsNamespace,
            UsersIntegrationEventsNamespace
            ];

        List<Assembly> attendanceAssemblies =
            [
                typeof(Attendee).Assembly,
                Modules.Attendance.Application.AssemblyReference.Assembly,
                Modules.Attendance.Presentation.AssemblyReference.Assembly,
                typeof(AttendanceModule).Assembly
            ];

        Types.InAssemblies(attendanceAssemblies)
            .That()
            .DoNotHaveDependencyOnAny(integrationEventsModule)
            .Should()
            .NotHaveDependencyOnAny(otherModules)
            .GetResult()
            .ShouldBeSuccessful();
    }
}
