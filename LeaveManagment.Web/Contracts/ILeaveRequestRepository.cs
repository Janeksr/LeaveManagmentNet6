using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveRequest(int leaveRequestId);
    }
}
