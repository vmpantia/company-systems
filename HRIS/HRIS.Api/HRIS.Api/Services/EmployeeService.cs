using HRIS.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRIS.Api.Services
{
    public class EmployeeService
    {
        public static void InsertEmployee_MST(Employee_MST employee, DatabaseEntities db)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            //employee.InternalID = ; [ Note: The value of this will be based on the Front End ] 
            employee.EmployeeID = db.GetNewEmployeeID().ToString();
            //employee.FirstName = ; [ Note: The value of this will be based on the Front End ] 
            //employee.MiddleName = ; [ Note: The value of this will be based on the Front End ] 
            //employee.LastName = ; [ Note: The value of this will be based on the Front End ] 
            //employee.BirthDate = ; [ Note: The value of this will be based on the Front End ] 
            //employee.Gender = ; [ Note: The value of this will be based on the Front End ] 
            //employee.CivilStatus = ; [ Note: The value of this will be based on the Front End ] 
            //employee.EmployeeStatus = ; [ Note: The value of this will be based on the Front End ] 
            //employee.EmployeeType = ; [ Note: The value of this will be based on the Front End ] 
            //employee.Department_InternalID = ; [ Note: The value of this will be based on the Front End ] 
            //employee.Status = ; [ Note: The value of this will be based on the Front End ] 
            employee.CreatedDate = DateTime.Now;
            //employee.ModifiedDate = ; [ Note: The value of this will be based on the Front End ] 

            db.Employee_MST.Add(employee);
        }

        public static void UpdateEmployee_MST(Employee_MST employee, DatabaseEntities db)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            employee.ModifiedDate = DateTime.Now;

            /*Get Employee Record in Employee_MST*/
            var currEmployee = db.Employee_MST.Find(employee.InternalID);
            if(currEmployee == null)
            {
                throw new ArgumentNullException(nameof(currEmployee));
            }

            /*Update Employee Record in Employee_MST*/
            currEmployee.InternalID = employee.InternalID;
            currEmployee.EmployeeID = employee.EmployeeID;
            currEmployee.FirstName = employee.FirstName;
            currEmployee.MiddleName = employee.MiddleName;
            currEmployee.LastName = employee.LastName;
            currEmployee.BirthDate = employee.BirthDate;
            currEmployee.Gender = employee.Gender;
            currEmployee.CivilStatus = employee.CivilStatus;
            currEmployee.EmployeeStatus = employee.EmployeeStatus;
            currEmployee.EmployeeType = employee.EmployeeType;
            currEmployee.Department_InternalID = employee.Department_InternalID;
            currEmployee.Status = employee.Status;
            currEmployee.CreatedDate = employee.CreatedDate;
            currEmployee.ModifiedDate = DateTime.Now;
        }

        public static void InsertEmployee_TRN(string RequestID, Employee_MST employee, DatabaseEntities db)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            var employeeTransaction = new Employee_TRN
            {
                RequestID = RequestID,
                InternalID = employee.InternalID,
                EmployeeID = employee.EmployeeID,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                Gender = employee.Gender,
                CivilStatus = employee.CivilStatus,
                EmployeeStatus = employee.EmployeeStatus,
                EmployeeType = employee.EmployeeType,
                Department_InternalID = employee.Department_InternalID,
                Status = employee.Status,
                CreatedDate = employee.CreatedDate,
                ModifiedDate = employee.ModifiedDate
            };

            db.Employee_TRN.Add(employeeTransaction);  
        }

    }
}