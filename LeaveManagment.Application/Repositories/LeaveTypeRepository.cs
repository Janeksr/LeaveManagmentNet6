using LeaveManagment.Application.Contracts;
using LeaveManagment.Data;

namespace LeaveManagment.Application.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
