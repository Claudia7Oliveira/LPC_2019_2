using System;
namespace aula6CrudPeople.Models
{
    public class ErrorViewModel
   {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    }
