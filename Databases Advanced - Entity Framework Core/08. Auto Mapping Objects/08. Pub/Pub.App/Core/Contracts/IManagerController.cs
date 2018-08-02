namespace Pub.App.Core.Contracts
{
    using Pub.App.Core.DTOs;

    public interface IManagerController
    {
        void SetManager(int employeeId, int managerId);

        ManagerDto GetManagerInfo(int employeeId);
    }
}
