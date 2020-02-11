namespace NpvCalculator.Models
{
    public class ValidationMessage
    {
        public string Message { get; set; }

        public override bool Equals(object o)
        {
            bool result = false;
            ValidationMessage validationMessage = o as ValidationMessage;

            if (validationMessage is ValidationMessage)
            {
                //Verify Npv Result Item Data
                result = (Message == validationMessage.Message);
            }

            return result;
        }
    }
}
