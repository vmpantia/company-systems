using HRIS.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRIS.Api.Services
{
    public class RequestService
    {
        public static void InsertRequest_LST(Request_LST request, DatabaseEntities db)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            request.RequestID = db.GetNewRequestID().ToString();
            //request.FunctionID = ; [ Note: The value of this will be based on the Front End ] 
            //request.Status = ; [ Note: The value of this will be based on the Front End ] 
            request.CreatedDate = DateTime.Now;
            //request.CreatedBy = ; [ Note: The value of this will be based on the Front End ] 
            request.ApprovedDate = null;
            request.ApprovedBy = null;
            request.ModifiedDate = null;
            request.ModifiedBy = null;
            db.Request_LST.Add(request);
        }
    }
}