using System.Data.Common;

namespace CleanArchitecture.Application.FunctionalTests;

public interface ITestDatab ase
{
    Task InitialiseAsync();

    DbConnection GetConnection();

    Task ResetAsync();

    Task DisposeAsync();
}
