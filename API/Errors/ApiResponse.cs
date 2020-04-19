using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Nieprawidłowe żądanie",
                401 => "Brak autoryzacji do tej strony",
                404 => "Nie istniejąca lokalizacja",
                500 => "Wewnętrzny błąd serwera",
                _ => null
            };
        }
    }
}