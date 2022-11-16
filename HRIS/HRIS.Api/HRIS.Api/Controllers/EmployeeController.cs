using HRIS.Api.Models;
using HRIS.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRIS.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        DatabaseEntities _db;

        public EmployeeController()
        {
            _db = new DatabaseEntities();
        }

        [HttpPost]
        [Route("SaveEmployee")]
        public IHttpActionResult SaveEmployeeRecord(EmployeeRecord employeeRecord)
        {
            var transaction = _db.Database.BeginTransaction();
            try
            {
                if (employeeRecord == null)
                {
                    throw new ArgumentNullException(nameof(employeeRecord));
                }

                RequestService.InsertRequest_LST(employeeRecord.InputRequest, _db);
                switch (employeeRecord.InputRequest.FunctionID)
                {
                    case "00A00": /*Save New Employee Record*/
                        RequestService.InsertRequest_LST(employeeRecord.InputRequest, _db);
                        EmployeeService.InsertEmployee_MST(employeeRecord.InputEmployee, _db);
                        EmployeeService.InsertEmployee_TRN(employeeRecord.InputRequest.RequestID, employeeRecord.InputEmployee, _db);
                        break;
                    case "00C00": /*Save Updates in Employee Record*/
                    case "00D00": /*Pre Deletion of Employee Record*/
                        EmployeeService.UpdateEmployee_MST(employeeRecord.InputEmployee, _db);
                        EmployeeService.InsertEmployee_TRN(employeeRecord.InputRequest.RequestID, employeeRecord.InputEmployee, _db);
                        break;

                }

                _db.SaveChanges();
                transaction.Commit();
                transaction.Dispose();

                //TODO: Successfully Saved must be logged here
                return Ok(employeeRecord);
            }
            catch (Exception ex)
            {
                //TODO: Error Log must be here
                transaction.Rollback();
                transaction.Dispose();
                return BadRequest(ex.Message);
            }
        }

    }
}