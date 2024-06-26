﻿using SharedModels.Entidades;

namespace PayrollAPI.Repository.IRepository
{
    public interface IDeductionRepository : IRepository<Deduction>
    {
        Task<Deduction> UpdateAsync(Deduction entity);
        Task<IEnumerable<Deduction>> GetByPayrollIdAsync(int payrollId);
    }
}
